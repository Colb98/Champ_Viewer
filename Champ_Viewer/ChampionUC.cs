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
    public partial class ChampionUC : UserControl
    {
        List<string> names;
        List<string> links;
        List<BunifuImageButton> btn_list = new List<BunifuImageButton>();
        public string select { get; private set; }
        bool expand = false;

        public ChampionUC()
        {
            InitializeComponent();

            names = new List<string>();
            select = "";

            //Some security things
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            OnLoad();
            this.Controls.AddRange(btn_list.ToArray());
        }

        List<string> GetChampNames()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/Champion";
            List<string> ans = new List<string>();
            WebClient web = new WebClient();
            
            String Html = web.DownloadString(Url);
            MatchCollection m1 = Regex.Matches(Html, "champion-icon\"\\s*data\\s*-\\s*champion\\s*=\\s*\"(.+?)\"\\sdata\\s*-\\s*sea", RegexOptions.Singleline);

            foreach(Match m in m1)
            {
                string name = m.Groups[1].Value;
                name = name.Replace("&#39;", @"'");
                ans.Add(name);
            }
            return ans;
        }

        List<string> GetChampPortrait()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/Champion";
            List<string> ans = new List<string>();

            WebClient web = new WebClient();

            String Html = web.DownloadString(Url);
            MatchCollection m1 = Regex.Matches(Html, "data-src=\"(.+?)/revision/latest/scale-to", RegexOptions.Singleline);

            foreach (Match m in m1)
            {
                string link = m.Groups[1].Value;
                if(link.Contains("OriginalCircle"))
                    ans.Add(link);
            }
            return ans;
        }

        Point GetPosition(int i)
        {
            int row, col;
            if (!expand)
            {
                row = i / 5;
                col = i % 5;
            }
            else
            {
                row = i / 7;
                col = i % 7;
            }
            return new Point(20 + col*90, 20 + row*90);
        }

        public void ChangeLayout()
        {
            this.VerticalScroll.Value = 0;
            expand = !expand;
            for(int i = 0; i < btn_list.Count; i++)
            {
                btn_list[i].Location = GetPosition(i);
            }
        }

        public void OnLoad()
        {            
            names = GetChampNames();
            links = GetChampPortrait();
            int n = names.Count;            

            for(int i = 0; i < n; i++)
            {
                BunifuImageButton tmp = new BunifuImageButton();
                tmp.Width = tmp.Height = 70;
                tmp.Location = GetPosition(i);
                tmp.ImageLocation = links[i];
                tmp.BackColor = Color.Transparent;
                tmp.Zoom = 10;

                ToolTip tooltip = new ToolTip();
                btn_list.Add(tmp);
                btn_list[i].Name = names[i];
                tooltip.SetToolTip(btn_list[i], names[i]);
                btn_list[i].Click += Select_Champ_Click;
            }
        }

        private void Select_Champ_Click(object sender, EventArgs e)
        {
            BunifuImageButton btn = (BunifuImageButton)sender;
            select = btn.Name;
            ChampView parent = (ChampView)this.Parent;
            parent.GetChamp();
        }
    }
}
