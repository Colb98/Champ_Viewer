using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champ_Viewer
{
    public partial class SkinViewForm : Form
    {
        public SkinViewForm(string ImgLocation)
        {
            InitializeComponent();

            pictureBox1.ImageLocation = ImgLocation;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
