using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Champ_Viewer
{
    public partial class SkinUC : UserControl
    {
        bool expand = false;
        List<BunifuImageButton> btn_list = new List<BunifuImageButton>();
        List<string> links = new List<string>();
        string champ = "";

        public SkinUC()
        {
            InitializeComponent();

            label1.Visible = false;
        }

        public void SetChamp(string name)
        {
            if (champ == name)
                return;

            if (btn_list.Count > 0)
                for(int i=0;i<btn_list.Count;i++)
                    this.Controls.Remove(btn_list[i]);

            btn_list.RemoveRange(0,btn_list.Count);
            champ = name;
            OnLoad();
            this.Controls.AddRange(btn_list.ToArray());

            label1.Visible = true;
            label2.Visible = false;
        }

        List<string> LoadSkinList()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/";
            List<string> ans = new List<string>();
            WebClient web = new WebClient();

            champ = champ.Replace(" ", "_");
            champ = champ.Replace("'", "%27");
            Url += champ + "/Skins";

            String Html = web.DownloadString(Url);
            MatchCollection m1 = Regex.Matches(Html, "data-src=\"(.+?)/revision/latest/", RegexOptions.Singleline);

            foreach (Match m in m1)
            {
                string links = m.Groups[1].Value;
                if (links.Contains(champ) && links.Contains("Skin") && !links.Contains("Screenshot")) 
                    ans.Add(links);
            }

            return ans;
        }

        void OnLoad()
        {
            links = LoadSkinList();
            int n = links.Count;

            for(int i = 0; i < n; i++)
            {
                BunifuImageButton tmp = new BunifuImageButton();
                tmp.Width = 300;
                tmp.Height = 180;
                tmp.SizeMode = PictureBoxSizeMode.Zoom;
                tmp.ImageLocation = links[i];
                tmp.BackColor = Color.Transparent;
                tmp.Zoom = 5;
                tmp.Location = SetPosition(i);

                ToolTip tooltip = new ToolTip();
                btn_list.Add(tmp);
                btn_list[i].Name = champ + "Skin" + i.ToString();
                btn_list[i].Tag = i;
                btn_list[i].Click += Skin_Select_Click;
                tooltip.SetToolTip(btn_list[i], System.IO.Path.GetFileName(links[i]));
                //btn_list[i].MouseHover += Skin_Select_MouseHover;
                btn_list[i].MouseEnter += Skin_Select_MouseHover;
            }
        }

        public void ChangeLayout()
        {
            this.VerticalScroll.Value = 0;
            expand = !expand;

            for (int i = 0; i < btn_list.Count; i++)
            {
                btn_list[i].Location = SetPosition(i);
            }

            if (expand)
                label1.Left = 197;
            else
                label1.Left = 122;
        }

        void ButtonsOrder(int index)
        {
            for (int i = btn_list.Count - 1; i > index; i--)
                btn_list[i].BringToFront();
            for (int i = 0; i < index; i++)
                btn_list[i].BringToFront();

            btn_list[index].BringToFront();
        }

        private void Skin_Select_MouseHover(object sender, EventArgs e)
        {
            BunifuImageButton btn = (BunifuImageButton)sender;
            ButtonsOrder((int)btn.Tag);
        }

        private void Skin_Select_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = (BunifuImageButton)sender;
            int i = (int) btn.Tag;
            SkinViewForm skinfrm = new SkinViewForm(links[i]);
            skinfrm.Show();
        }

        Point SetPosition(int i)
        {
            int d;
            if (expand)
                d = (530 + 150 - 50 - 300) / links.Count;
            else
                d = (530 - 50 - 300) / links.Count;

            return new Point(15 + i * d, (367 - 180) / 2);
        }
    }
}
