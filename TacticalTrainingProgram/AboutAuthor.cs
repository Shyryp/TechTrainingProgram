using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TacticalTrainingProgram
{
    public partial class AboutAuthor : Form
    {
        public AboutAuthor()
        {
            InitializeComponent();
            DateTime date1 = new DateTime();
            date1 = DateTime.Today;
            if (date1.Year >= 2018)
            {
                this.label1.Text = "Данная учебная программа разработана в целях получения практических и теоретических знаний и навыков по преодолению водных преград военной техники. \nАвторы программы: Пепеляев А.В; Шмаков Е.А.; Приёмко А.А., студент. \n\nБиблеографический список:\nТанки под водой [Электронный ресурс]. - Режим доступа: www.url: http://www.xliby.ru/transport_i_aviacija/tehnika_i_vooruzhenie_1999_01/p9.php. - 10.10.2017.";
            }
        }
    }
}
