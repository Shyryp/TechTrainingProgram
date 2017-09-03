using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TacticalTrainingProgram
{
    class DePictureDinamicBox : PictureBox
    {
        public int indexPictureDinamicB = 0;
        public int Yfrom = 0;
        public int Xfrom = 0;
        //точка перемещения
        Point DownPoint;
        bool IsDragMode;
        TestForm fatherForm;
        public DePictureDinamicBox(TestForm father)
        {
            fatherForm = father;
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            DownPoint = mevent.Location;
            Yfrom = Location.Y;
            Xfrom = Location.X;
            this.BringToFront();
            IsDragMode = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            IsDragMode = false;
            if (Location.Y < 0)
            {
                Location = new Point(Location.X, 0);
            }
            else if (Location.Y > (fatherForm.Height - 1))
            {
                Location = new Point(Location.X, (fatherForm.Height - 1));
            }

            if (Location.X < 0)
            {
                Location = new Point(0, Location.Y);
            }
            else if (Location.X > (fatherForm.Width - 1))
            {
                Location = new Point((fatherForm.Width - 10), Location.Y);
            }

            for (int i = 0; i < fatherForm.listPictureBox.Count; i++)
            {
                if (((Location.X > fatherForm.listPictureBox[i].Location.X)
                    && (Location.X < fatherForm.listPictureBox[i].Location.X
                    + fatherForm.listPictureBox[i].Width))
                    && ((Location.Y > fatherForm.listPictureBox[i].Location.Y)
                    && (Location.Y < fatherForm.listPictureBox[i].Location.Y
                    + fatherForm.listPictureBox[i].Height)))
                {
                    fatherForm.listPictureBox[i].Image =
                        this.Image;
                    fatherForm.listPictureBox[i].activity = true;
                    if (fatherForm.listPictureBox[i].index == this.indexPictureDinamicB)
                    {
                        fatherForm.listPictureBox[i].trueOrfal = 1;
                    }
                    else
                    {
                        fatherForm.listPictureBox[i].trueOrfal = 0;
                    }
                }
            }
            Location = new Point(Xfrom, Yfrom);
            base.OnMouseUp(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            //если кнопка мыши нажата
            if (IsDragMode)
            {
                Point p = mevent.Location;
                //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(mevent);
        }
    }
}
