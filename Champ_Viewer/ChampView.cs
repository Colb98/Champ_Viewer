using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Champ_Viewer
{
    public partial class ChampView : Form
    {
        string selected_champ = "";

        public ChampView()
        {
            InitializeComponent();

            selecthl.Width = home.Width;
            selecthl.Top = home.Top;
            homeUC1.BringToFront();
            championUC1.Parent = this;
        }

        public void GetChamp()
        {
            selected_champ = championUC1.select;
            skinUC1.SetChamp(selected_champ);
            skillUC1.ChangeChamp(selected_champ);
            //MessageBox.Show("Selected Champion: " + selected_champ);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void home_Click(object sender, EventArgs e)
        {
            selecthl.Height = home.Height;
            selecthl.Top = home.Top;
            homeUC1.BringToFront();
        }

        private void champion_Click(object sender, EventArgs e)
        {
            selecthl.Height = champion.Height;
            selecthl.Top = champion.Top;

            championUC1.BringToFront();                        
        }

        private void skin_Click(object sender, EventArgs e)
        {
            selecthl.Height = skin.Height;
            selecthl.Top = skin.Top;

            skinUC1.BringToFront();
        }

        private void skill_Click(object sender, EventArgs e)
        {
            selecthl.Height = skill.Height;
            selecthl.Top = skill.Top;

            skillUC1.BringToFront();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            championUC1.ChangeLayout();
            homeUC1.ChangeLayout();
            skinUC1.ChangeLayout();
            skillUC1.ChangeLayout();

            pictureBox2.Visible = !pictureBox2.Visible;
            if (panel1.Width == 201)
            {                
                panel1.Visible = false;
                panel1.Width = 50;
                transition2.ShowSync(panel1);                
            }
            else
            {
                panel1.Visible = false;
                panel1.Width = 201;
                transition1.ShowSync(panel1);
            }
        }        
    }
}
