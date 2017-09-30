using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TacticalTrainingProgram
{
    public partial class TestForm : Form
    {

        private List<DeButton> listButton = new List<DeButton>();
        private List<Label> listLabel = new List<Label>();
        private List<TextBox> listTextBox = new List<TextBox>();
        private List<DeCheckBox> listCheckBox = new List<DeCheckBox>();
        private List<DeRadioButton> listRadioButton = new List<DeRadioButton>();
        private List<PictureBox> listPictureStaticBox = new List<PictureBox>();
        private List<DePictureDinamicBox> listPictureDinamicBox = new List<DePictureDinamicBox>();
        public List<DePictureBox> listPictureBox = new List<DePictureBox>();
        private SerializableForm newFormForSerializable;
        private string[] nameFile;
        private int TrueTest = 0;
        private int FinalTrue = 0;
        private int AllTestTrue = 0;
        private int FinalAllTestTrue = 0;
        private int[] Test = new int[30];
        private int integerTest = 0;
        private int testN = 0;
        private MainForm parentF;
        private bool RandomTest = false;
        private int[] RandomTestInt = new int[10];

        public TestForm(int numTest, MainForm parentForm)
        {
            InitializeComponent();
            
            parentF = parentForm;
            testN = numTest;
            this.bBack.Enabled = false;
            for (int i = 0; i < 30; i++)
            {
                Test[i] = 0;
            }
            for (int i = 0; i < 10; i++)
            {
                RandomTestInt[i] = -1;
            }
            if (numTest == 0)
            {
                string buffer = @"Tests\Random tests";
                this.labelText1.Text = "      Вопрос 1" ;
                nameFile = Directory.GetFiles(buffer, "*.xml");
                if (nameFile.Length < 10)
                {
                    AllTestTrue = nameFile.Length;
                    if (nameFile.Length == 1)
                    {
                        this.bNext.Enabled = false;
                        this.openFile(nameFile[0]);
                    }
                    else if (nameFile.Length == 0)
                    {
                        parentF.Visible = true;
                        this.Close();
                    }
                    else {
                        this.openFile(nameFile[0]);
                    }
                }
                else
                {
                    RandomTest = true;
                    Random rand = new Random();
                    AllTestTrue = 10;
                    RandomTestInt[0] = rand.Next(0, nameFile.Length);
                    for (int k = 0; k < 10; k++) {
                        int randInt = rand.Next(0, nameFile.Length);
                        for (int i = 0; i < k; i++)
                        {
                            if (RandomTestInt[i] != randInt)
                            {
                                RandomTestInt[k] = randInt;
                            }
                            else {
                                RandomTestInt[k] = -1;
                                k--;
                                break;
                            }
                        }
                    }
                    
                    this.openFile(nameFile[0]);
                }
                
            }
            else if (numTest > 0)
            {
                string buffer = @"Tests\Variant " + numTest;

                nameFile = Directory.GetFiles(buffer, "*.xml");
                AllTestTrue = nameFile.Length;
                if (nameFile.Length == 1)
                {
                    this.bNext.Enabled = false;
                }
                if (nameFile.Length == 0)
                {
                    parentF.Visible = true;
                    this.Close();
                }
                else
                {
                    this.openFile(nameFile[0]);
                }
            }

        }



        private void openFile(string nameFile)
        {

            newFormForSerializable = new SerializableForm();
            for (int i = 0; i < listButton.Count; i++)
                listButton[i].Dispose();
            for (int i = 0; i < listLabel.Count; i++)
                listLabel[i].Dispose();
            for (int i = 0; i < listTextBox.Count; i++)
                listTextBox[i].Dispose();
            for (int i = 0; i < listCheckBox.Count; i++)
                listCheckBox[i].Dispose();
            for (int i = 0; i < listRadioButton.Count; i++)
                listRadioButton[i].Dispose();
            for (int i = 0; i < listPictureStaticBox.Count; i++)
                listPictureStaticBox[i].Dispose();
            for (int i = 0; i < listPictureDinamicBox.Count; i++)
                listPictureDinamicBox[i].Dispose();
            for (int i = 0; i < listPictureBox.Count; i++)
                listPictureBox[i].Dispose();

            listButton = new List<DeButton>();
            listLabel = new List<Label>();
            listTextBox = new List<TextBox>();
            listCheckBox = new List<DeCheckBox>();
            listRadioButton = new List<DeRadioButton>();
            listPictureStaticBox = new List<PictureBox>();
            listPictureDinamicBox = new List<DePictureDinamicBox>();
            listPictureBox = new List<DePictureBox>();
            XmlSerializer formatter = new XmlSerializer(typeof(SerializableForm));
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                newFormForSerializable = (SerializableForm)formatter.Deserialize(fs);
                for (int i = 0; i < newFormForSerializable.seButton.Count; i++)
                {
                    this.listButton.Add(new DeButton()); //создаём кнопку
                    this.listButton[i].Name = newFormForSerializable.seButton[i].Name;
                    this.listButton[i].Text = newFormForSerializable.seButton[i].Text;
                    this.listButton[i].Width = newFormForSerializable.seButton[i].SizeX;
                    this.listButton[i].Height = newFormForSerializable.seButton[i].SizeY;
                    this.listButton[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.seButton[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listButton[i].Location = new Point(newFormForSerializable.seButton[i].X, newFormForSerializable.seButton[i].Y);
                    this.listButton[i].index = i;
                    this.listButton[i].trueAnswer = newFormForSerializable.seButton[i].TrueOrFalse;
                    TrueTest += newFormForSerializable.seButton[i].TrueOrFalse;
                    this.listButton[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    this.listButton[i].Click += new System.EventHandler(this.buttonInTest_Click);
                    //this.listButton[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(listButton[i]);
                    //indexButton++;

                }
                for (int i = 0; i < newFormForSerializable.seLabel.Count; i++)
                {
                    this.listLabel.Add(new Label());
                    this.listLabel[i].Name = newFormForSerializable.seLabel[i].Name;
                    this.listLabel[i].Text = newFormForSerializable.seLabel[i].Text;
                    this.listLabel[i].Width = newFormForSerializable.seLabel[i].SizeX;
                    this.listLabel[i].Height = newFormForSerializable.seLabel[i].SizeY;
                    this.listLabel[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.seLabel[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listLabel[i].Location = new Point(newFormForSerializable.seLabel[i].X, newFormForSerializable.seLabel[i].Y);
                    this.listLabel[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    //this.listLabel[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(this.listLabel[i]);
                    //this.indexLabel++;

                }
                for (int i = 0; i < newFormForSerializable.seTextBox.Count; i++)
                {
                    this.listTextBox.Add(new TextBox());
                    this.listTextBox[i].Name = newFormForSerializable.seTextBox[i].Name;
                    //this.listTextBox[i].Text = newFormForSerializable.seTextBox[i].Text;
                    this.listTextBox[i].Width = newFormForSerializable.seTextBox[i].SizeX;
                    this.listTextBox[i].Height = newFormForSerializable.seTextBox[i].SizeY;
                    this.listTextBox[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.seTextBox[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listTextBox[i].Location = new Point(newFormForSerializable.seTextBox[i].X, newFormForSerializable.seTextBox[i].Y);
                    TrueTest++;
                    this.listTextBox[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    //this.listTextBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(this.listTextBox[i]);
                    //this.indexTextBox++;

                }
                for (int i = 0; i < newFormForSerializable.seCheckBox.Count; i++)
                {
                    this.listCheckBox.Add(new DeCheckBox());
                    this.listCheckBox[i].Name = newFormForSerializable.seCheckBox[i].Name;
                    this.listCheckBox[i].Text = newFormForSerializable.seCheckBox[i].Text;
                    this.listCheckBox[i].Width = newFormForSerializable.seCheckBox[i].SizeX;
                    this.listCheckBox[i].Height = newFormForSerializable.seCheckBox[i].SizeY;
                    this.listCheckBox[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.seCheckBox[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listCheckBox[i].Location = new Point(newFormForSerializable.seCheckBox[i].X, newFormForSerializable.seCheckBox[i].Y);
                    this.listCheckBox[i].index = i;
                    this.listCheckBox[i].trueAnswer = newFormForSerializable.seCheckBox[i].TrueOrFalse;
                    this.listCheckBox[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    TrueTest += newFormForSerializable.seCheckBox[i].TrueOrFalse;
                    this.listCheckBox[i].Click += new System.EventHandler(this.checkBox_Click);
                    //this.listCheckBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(this.listCheckBox[i]);

                    //this.indexCheckBox++;

                }
                for (int i = 0; i < newFormForSerializable.seRadioButton.Count; i++)
                {
                    this.listRadioButton.Add(new DeRadioButton());
                    this.listRadioButton[i].Name = newFormForSerializable.seRadioButton[i].Name;
                    this.listRadioButton[i].Text = newFormForSerializable.seRadioButton[i].Text;
                    this.listRadioButton[i].Width = newFormForSerializable.seRadioButton[i].SizeX;
                    this.listRadioButton[i].Height = newFormForSerializable.seRadioButton[i].SizeY;
                    this.listRadioButton[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.seRadioButton[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listRadioButton[i].Location = new Point(newFormForSerializable.seRadioButton[i].X, newFormForSerializable.seRadioButton[i].Y);
                    this.listRadioButton[i].index = i;
                    this.listRadioButton[i].trueAnswer = newFormForSerializable.seRadioButton[i].TrueOrFalse;
                    TrueTest += newFormForSerializable.seRadioButton[i].TrueOrFalse;
                    this.listRadioButton[i].CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
                    this.listRadioButton[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    //this.listRadioButton[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(this.listRadioButton[i]);
                    //this.indexRadioButton++;

                }

                for (int i = 0; i < newFormForSerializable.sePictureStaticBox.Count; i++)
                {

                    this.listPictureStaticBox.Add(new PictureBox());

                    this.listPictureStaticBox[i].Name = newFormForSerializable.sePictureStaticBox[i].Name;
                    this.listPictureStaticBox[i].Text = newFormForSerializable.sePictureStaticBox[i].Text;
                    this.listPictureStaticBox[i].Width = newFormForSerializable.sePictureStaticBox[i].SizeX;
                    this.listPictureStaticBox[i].Height = newFormForSerializable.sePictureStaticBox[i].SizeY;
                    this.listPictureStaticBox[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.sePictureStaticBox[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listPictureStaticBox[i].Location = new Point(newFormForSerializable.sePictureStaticBox[i].X, newFormForSerializable.sePictureStaticBox[i].Y);
                    this.listPictureStaticBox[i].Image = Image.FromFile(@newFormForSerializable.sePictureStaticBox[i].wayPictures);
                    this.listPictureStaticBox[i].SizeMode = PictureBoxSizeMode.Zoom;
                    this.listPictureStaticBox[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    //this.listPictureStaticBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.panelTest.Controls.Add(this.listPictureStaticBox[i]);

                    //this.indexPictureStaticBox++;

                }
                for (int i = 0; i < newFormForSerializable.sePictureDinamicBox.Count; i++)
                {
                    this.listPictureDinamicBox.Add(new DePictureDinamicBox(this));
                    this.listPictureBox.Add(new DePictureBox());
                    this.listPictureBox[i].Name = newFormForSerializable.sePictureDinamicBox[i].childName;
                    this.listPictureDinamicBox[i].Name = newFormForSerializable.sePictureDinamicBox[i].Name;
                    this.listPictureBox[i].Text = this.listPictureDinamicBox[i].Text = newFormForSerializable.sePictureDinamicBox[i].Text;
                    this.listPictureDinamicBox[i].Width = newFormForSerializable.sePictureDinamicBox[i].SizeX;
                    this.listPictureDinamicBox[i].Height = newFormForSerializable.sePictureDinamicBox[i].SizeY;
                    this.listPictureBox[i].Width = newFormForSerializable.sePictureDinamicBox[i].childSizeX;
                    this.listPictureBox[i].Height = newFormForSerializable.sePictureDinamicBox[i].childSizeY;
                    this.listPictureBox[i].Font = this.listPictureDinamicBox[i].Font = new System.Drawing.Font("Microsoft Sans Serif", newFormForSerializable.sePictureDinamicBox[i].fontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.listPictureDinamicBox[i].Location = new Point(newFormForSerializable.sePictureDinamicBox[i].X, newFormForSerializable.sePictureDinamicBox[i].Y);
                    this.listPictureDinamicBox[i].Image = Image.FromFile(@newFormForSerializable.sePictureDinamicBox[i].wayPictures);
                    this.listPictureDinamicBox[i].Yfrom = newFormForSerializable.sePictureDinamicBox[i].Y;
                    this.listPictureDinamicBox[i].Xfrom = newFormForSerializable.sePictureDinamicBox[i].X;
                    this.listPictureBox[i].Location = new Point(newFormForSerializable.sePictureDinamicBox[i].childX, newFormForSerializable.sePictureDinamicBox[i].childY);
                    this.listPictureBox[i].SizeMode = this.listPictureDinamicBox[i].SizeMode = PictureBoxSizeMode.Zoom;
                    this.listPictureDinamicBox[i].indexPictureDinamicB = i;
                    this.listPictureBox[i].index = i;
                    this.listPictureBox[i].Click += new System.EventHandler(this.pictureBoxFrom_Click);
                    this.listPictureBox[i].BackColor = System.Drawing.Color.WhiteSmoke;
                    this.listPictureDinamicBox[i].BackColor = System.Drawing.Color.WhiteSmoke;

                    //this.listPictureBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    //this.listPictureDinamicBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;

                    this.panelTest.Controls.Add(this.listPictureBox[i]);
                    this.panelTest.Controls.Add(this.listPictureDinamicBox[i]);
                    this.listPictureBox[i].BringToFront();
                    TrueTest++;
                    this.listPictureDinamicBox[i].BringToFront();

                    //this.indexPictureDinamicBox++;

                }
            }
        }

        private void pictureBoxFrom_Click(object sender, EventArgs e)
        {
            DePictureBox picBox = sender as DePictureBox;
            if (picBox.activity == true)
            {
                picBox.Image = null;
                picBox.trueOrfal = 0;
            }
        }

        private void buttonInTest_Click(object sender, EventArgs e) //при нажатии на первую кнопку в панеле инструментов
        {
            DeButton buffButton = sender as DeButton;
            if (buffButton.active == 0)
            {
                FinalTrue += buffButton.trueAnswer;
                listButton[buffButton.index].active = 1;
            }
            else
            {
                FinalTrue -= buffButton.trueAnswer;
                listButton[buffButton.index].active = 0;
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            DeCheckBox buffCheck = sender as DeCheckBox;
            if (buffCheck.Checked == true)
            {
                if (buffCheck.trueAnswer == 0)
                {
                    FinalTrue -= 1;
                }
                else
                {
                    FinalTrue += buffCheck.trueAnswer;
                }
            }
            else
            {
                if (buffCheck.trueAnswer == 0)
                {
                    FinalTrue += 1;
                }
                else
                {
                    FinalTrue -= buffCheck.trueAnswer;
                }

            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            DeRadioButton buffRadioButton = sender as DeRadioButton;
            if (buffRadioButton.Checked == true)
            {
                FinalTrue += buffRadioButton.trueAnswer;
            }
            else
            {
                FinalTrue -= buffRadioButton.trueAnswer;
            }
        }


        private void bNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPictureBox.Count; i++)
            {
                this.FinalTrue += listPictureBox[i].trueOrfal;
            }
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.Compare(listTextBox[i].Text, newFormForSerializable.seTextBox[i].Text, true) == 0)
                    this.FinalTrue += 1;
            }

            if (TrueTest == FinalTrue)
            {
                FinalAllTestTrue++;
                Test[integerTest] = 1;
            }
            else
            {
                FinalAllTestTrue -= Test[integerTest];
                Test[integerTest] = 0;
            }
            for (int i = 0; i < listPictureBox.Count; i++)
            {
                this.FinalTrue -= listPictureBox[i].trueOrfal;
            }
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.Compare(listTextBox[i].Text, newFormForSerializable.seTextBox[i].Text, true) == 0)
                    this.FinalTrue -= 1;
            }
            integerTest++;
            TrueTest = 0;
            FinalTrue = 0;
            if (integerTest <= AllTestTrue - 1)
            {
                
                if (RandomTest == false)
                {
                    if (testN == 0)
                    {
                        this.labelText1.Text = "      Вопрос " + (integerTest + 1);
                    }
                    else
                    {
                        this.labelText1.Text = "Вариант " + testN + " Вопрос " + (integerTest + 1);
                    }
                    openFile(nameFile[integerTest]);
                }
                else {
                    this.labelText1.Text = "         Вопрос " + (integerTest + 1);
                    openFile(nameFile[RandomTestInt[integerTest]]);
                }
                this.bBack.Enabled = true;
            }
            if (integerTest == AllTestTrue - 1)
            {
                this.bNext.Enabled = false;
            }
            
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPictureBox.Count; i++)
            {
                this.FinalTrue += listPictureBox[i].trueOrfal;
            }
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.Compare(listTextBox[i].Text, newFormForSerializable.seTextBox[i].Text, true) == 0)
                    this.FinalTrue += 1;
            }

            if (TrueTest == FinalTrue)
            {
                FinalAllTestTrue++;
                Test[integerTest] = 1;
            }
            else
            {
                FinalAllTestTrue -= Test[integerTest];
                Test[integerTest] = 0;
            }

            this.bBack.Enabled = false;
            this.bNext.Enabled = false;
            for (int i = 0; i < listButton.Count; i++)
                listButton[i].Dispose();
            for (int i = 0; i < listLabel.Count; i++)
                listLabel[i].Dispose();
            for (int i = 0; i < listTextBox.Count; i++)
                listTextBox[i].Dispose();
            for (int i = 0; i < listCheckBox.Count; i++)
                listCheckBox[i].Dispose();
            for (int i = 0; i < listRadioButton.Count; i++)
                listRadioButton[i].Dispose();
            for (int i = 0; i < listPictureStaticBox.Count; i++)
                listPictureStaticBox[i].Dispose();
            for (int i = 0; i < listPictureDinamicBox.Count; i++)
                listPictureDinamicBox[i].Dispose();
            for (int i = 0; i < listPictureBox.Count; i++)
                listPictureBox[i].Dispose();
            this.labelText1.Text = "      Результат: ";
            Label newLabelText = new Label();
            newLabelText.Location = new Point((int)(this.panelTest.Width / 2 / 2), (int)(this.panelTest.Height / 2/1.2));
            newLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            newLabelText.TextAlign = ContentAlignment.MiddleCenter;
            newLabelText.Height = 100;
            newLabelText.Width = this.panelTest.Width / 2;
            newLabelText.BackColor = System.Drawing.Color.Transparent;
            newLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.None)));
            if ((AllTestTrue == FinalAllTestTrue) && ((float)AllTestTrue / (float)FinalAllTestTrue >= 0.9))
            {
                newLabelText.Text = "Тест пройден на оценку\n \"Отлично\"!";
            }
            else if (((float)FinalAllTestTrue / (float)AllTestTrue < 0.9) && (((float)FinalAllTestTrue / (float)AllTestTrue >= 0.75)))
            {
                newLabelText.Text = "Тест пройден на оценку\n \"Хорошо\"!";
            }
            else if (((float)FinalAllTestTrue / (float)AllTestTrue < 0.75) && (((float)FinalAllTestTrue / (float)AllTestTrue >= 0.5)))
            {
                newLabelText.Text = "Тест пройден на оценку\n \"Удовлетворительно\"!";
            }
            else if (((float)FinalAllTestTrue / (float)AllTestTrue < 0.5))
            {
                newLabelText.Text = "Тест пройден на оценку\n \"Неудовлетворительно\"!";
            }
            this.panelTest.Controls.Add(newLabelText);
            this.bBack.Enabled = true;
            this.bBack.Text = "Закрыть";
            this.bStop.Enabled = false;
            this.bStop.Visible = false;
            this.bNext.Enabled = true;
            this.bNext.Text = "Начать заново";
            this.bNext.Click -= new System.EventHandler(this.bNext_Click);
            this.bBack.Click -= new System.EventHandler(this.bBack_Click);
            this.bNext.Click += new System.EventHandler(this.bNew_Click);
            this.bBack.Click += new System.EventHandler(this.bClose_Click);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listPictureBox.Count; i++)
            {
                this.FinalTrue += listPictureBox[i].trueOrfal;
            }
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.Compare(listTextBox[i].Text, newFormForSerializable.seTextBox[i].Text, true) == 0)
                    this.FinalTrue += 1;
            }

            if (TrueTest == FinalTrue)
            {
                FinalAllTestTrue++;
                Test[integerTest] = 1;
            }
            else
            {
                FinalAllTestTrue -= Test[integerTest];
                Test[integerTest] = 0;
            }
            for (int i = 0; i < listPictureBox.Count; i++)
            {
                this.FinalTrue -= listPictureBox[i].trueOrfal;
            }
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (string.Compare(listTextBox[i].Text, newFormForSerializable.seTextBox[i].Text, true) == 0)
                    this.FinalTrue -= 1;
            }
            TrueTest = 0;
            FinalTrue = 0;
            integerTest--;
            
            if (integerTest <= AllTestTrue - 1)
            {

                if (RandomTest == false)
                {
                    if (testN == 0)
                    {
                        this.labelText1.Text = "      Вопрос " + (integerTest + 1);
                    }
                    else {
                        this.labelText1.Text = "Вариант " + testN + " Вопрос " + (integerTest + 1);
                    }
                    
                    openFile(nameFile[integerTest]);
                }
                else
                {
                    this.labelText1.Text = "         Вопрос " + (integerTest + 1);
                    openFile(nameFile[RandomTestInt[integerTest]]);
                }
                this.bNext.Enabled = true;
            }

            if (integerTest == 0)
            {
                this.bBack.Enabled = false;
            }
            
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(testN, parentF);
            if (testForm.IsDisposed != true)
            {
                this.Visible = false;
                this.Close();
                testForm.Show();
            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            parentF.Visible = true;
            this.Close();

        }

        private void TestForm_FormClosing(object sender, CancelEventArgs e)
        {
            parentF.Visible = true;
        }
    }
}
