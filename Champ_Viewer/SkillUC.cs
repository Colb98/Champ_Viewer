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
using System.Runtime.InteropServices;

namespace Champ_Viewer
{
    public partial class SkillUC : UserControl
    {
        //Auto size textbox 
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);


        bool expand = false;
        List<string> skill_list;
        List<string> icon_list;
        List<string> des_list;

        List<PictureBox> pb_list;
        List<Label> lb_list;
        string champ = "";

        public SkillUC()
        {
            InitializeComponent();
        }

        public void ChangeLayout()
        {
            this.VerticalScroll.Value = 0;
            expand = !expand;

            if(expand == true)
            {
                if(lb_list != null)
                {
                    for(int i = 0; i < lb_list.Count; i++)
                    {
                        lb_list[i].MaximumSize = new Size(385 + 150, 0);
                        pb_list[i].Location = PictureBoxLocation(i);
                        lb_list[i].Location = TextboxLocation(i);
                    }
                }
            }
            else
            {
                if (lb_list != null)
                {
                    for (int i = 0; i < lb_list.Count; i++)
                    {
                        lb_list[i].MaximumSize = new Size(385, 0);
                        pb_list[i].Location = PictureBoxLocation(i);
                        lb_list[i].Location = TextboxLocation(i);
                    }
                }
            }
        }

        public void OnLoad()
        {
            //Get Champ's skills informations
            skill_list = LoadSkillList();
            icon_list = LoadSkillIcon();
            des_list = LoadSkillDescription();
            //textBox2.Text = "0";
            //textBox3.Text = skill_list.Count.ToString();

            //Delete old List
            if (pb_list != null && lb_list != null)
                if(pb_list.Count > 0 || lb_list.Count > 0)
                {
                    for(int i = 0; i < pb_list.Count; i++)
                    {
                       this.Controls.Remove(pb_list[i]);
                        this.Controls.Remove(lb_list[i]);
                    }
                }


            //Create new List
            if(skill_list.Count > 0 && icon_list.Count > 0)
            {
                //pictureBox1.ImageLocation = icon_list[0];
                //textBox1.Text = skill_list[0];
                //textBox4.Text = des_list[0];
                pb_list = new List<PictureBox>();
                lb_list = new List<Label>();
            }

            //Add generated info into the User Control
            for(int i = 0; i < skill_list.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Location = PictureBoxLocation(i);
                pb.Width = pb.Height = 64;
                pb.ImageLocation = icon_list[i];
                pb_list.Add(pb);
                this.Controls.Add(pb_list[i]);

                Label lb = new Label();

                lb.BorderStyle = BorderStyle.None;
                lb.Location = TextboxLocation(i);
                lb.Text = des_list[i];
                lb.MaximumSize = new Size(385, 0);
                if (expand)
                    lb.MaximumSize = new Size(385 + 150, 0);
                lb.AutoSize = true;

                lb.BackColor = Color.FromArgb(9, 20, 26);
                lb.ForeColor = Color.White;
                lb_list.Add(lb);
                this.Controls.Add(lb_list[i]);                
            }
        }

        Point PictureBoxLocation(int i)
        {
            // If the first skills => position zero
            if (i == 0)
                return new Point(20, 20);

            // Else: calc the sum of the before labels to get Y
            else
            {
                int sum = 0;
                for(int j = 0; j < i; j++)
                {
                    sum += lb_list[j].Height + 20;
                }

                return new Point(20, 20 + sum);
            }
        }

        Point TextboxLocation(int i)
        {
            Point ans = PictureBoxLocation(i);

            ans.X += 80;
            return ans;
        }

        public void ChangeChamp(string name)
        {
            champ = name;

            OnLoad();
        }

        List<string> LoadSkillList()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/";
            List<string> ans = new List<string>();
            WebClient web = new WebClient();

            champ = champ.Replace(" ", "_");
            champ = champ.Replace("'", "%27");
            Url += champ + "/Abilities";

            String Html = web.DownloadString(Url);
            MatchCollection m1 = Regex.Matches(Html, "<td\\s*style=\"white\\s*-\\s*space:\\s*nowrap;\\s*font\\s*-\\s*size:140\\s*%;\\s*color:\\s*#9797fc;\\s*font-weight:bold;\\s*text-shadow:\\s*0\\s*2px\\s*black;\\s*padding-right:14px;\">\\s*(.+?)\\s*</\\s*td\\s*><\\s*td\\s*style\\s*=\\s*\"width:\\s*99%;\\s*text-align:left;\\s*font-weight:\\s*bold;font-size:89%;\\s*padding-right:50px;\"\\s*>\\s*", RegexOptions.Singleline);

            foreach (Match m in m1)
            {
                string name = m.Groups[1].Value;
                if (true)
                    ans.Add(name);
            }

            return ans;
        }

        List<string> LoadSkillIcon()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/";
            List<string> ans = new List<string>();
            WebClient web = new WebClient();

            string regex = "<noscript><img\\s*src=\"(.+?)\"\\s*alt=";
            
            champ = champ.Replace("'", "%27");
            Url += champ + "/Abilities";

            String Html = web.DownloadString(Url);
            for(int i = 0; i < skill_list.Count; i++)
            {
                string regex1 = regex + "\"" + skill_list[i].Replace(" (PBE)", "");
                string short_name = skill_list[i].Split(' ')[0];
                short_name = short_name.Split(',')[0];
                short_name = short_name.Split('.')[0];
                short_name = short_name.Split('!')[0];
                short_name = short_name.Replace("'", "%27");

                regex1 = regex1.Replace(" ", "\\s*");
                regex1 = regex1.Replace("'", "&amp;#039;");
                MatchCollection m1 = Regex.Matches(Html, regex1, RegexOptions.Singleline);

                foreach (Match m in m1) {
                    string links = m.Groups[1].Value;
                    if (links.Length > 300)
                        continue;
                    if (links.Contains(short_name))
                    {
                        int index = links.IndexOf("png");
                        if(index + 3 < links.Length)
                            links = links.Remove(index + 3);

                        if (ans.Contains(links))
                            continue;

                        ans.Add(links);
                        break;
                    }
                }
            }
            
            return ans;
        }

        List<string> LoadSkillDescription()
        {
            string Url = "http://leagueoflegends.wikia.com/wiki/";
            List<string> ans = new List<string>();
            WebClient web = new WebClient();

            string regex = "<td style=\"white - space: nowrap; font - size:140 %; color: #9797fc; font-weight:bold; text-shadow: 0 2px black; padding-right:14px;\"> (.+?) Ability Details";
            
            Url += champ.Replace("'", "%27").Replace(" ", "_") + "/Abilities";

            //Rollback the Replaces
            champ = champ.Replace("%27", "'").Replace("_", " ");

            String Html = web.DownloadString(Url);
            
            regex = regex.Replace(" ", "\\s*");
            MatchCollection m1 = Regex.Matches(Html, regex, RegexOptions.Singleline);

            foreach (Match m in m1)
            {
                string par = m.Groups[1].Value;
                //if (par.Contains("<table>") || par.Contains("</table>"))
                //    continue;
                //if (par.Contains("Active") || par.Contains("Innate"))

                //Some champ don't have their name in the skill des (Nunu - Willump for example)
                //if (par.Contains(champ))
                {
                    par = deleteTags(par);
                    par = par.Replace("\n", "\r\n");
                    par = AddNewLine(par);
                    par = RemoveMultiNewline(par);
                    ans.Add(par);
                }
            }
            

            return ans;
        }

        // Add new line charaters to some positions
        string AddNewLine(string s)
        {
            s = s.Replace("COST", "\rCOST");
            s = s.Replace("EFFECT", "\rEFFECT");
            s = s.Replace("COOLDOWN", "\rCOOLDOWN");
            s = s.Replace("SPEED", "\rSPEED");
            s = s.Replace("Maximum", "\rMaximum");
            return s;
        }

        //Delete HTML formatting tags
        string deleteTags(string htmldoc)
        {
            int len = htmldoc.Length;
            string newdoc = "";
            for(int i = 0; i < len; i++)
            {
                if (htmldoc[i] != '<')
                {
                    if (htmldoc[i] != '&' || htmldoc[i + 1] != '#')
                        newdoc = newdoc.Insert(newdoc.Length, htmldoc[i].ToString());
                    else
                        while (htmldoc[i] != ';')
                            i++;
                }
                else
                    while (htmldoc[i] != '>')
                       i++;
            }

            return newdoc;
        }

        //Fix after debugs, Messsssssssyyyyy
        string RemoveMultiNewline(string s)
        {
            while(s.Contains("\r\n\r\n") || s.Contains("\r\n "))
            {
                s = s.Replace("\r\n\r\n", "\r\n");
                s = s.Replace("\r\n ", "\r\n");
            }

            s = s.Replace("\r\n", "\r\n\r\n");
            s = s.Replace("\r\n\r\n\r", "\r\n\r\n");
            return s;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                return;
            int i = Convert.ToInt32(textBox2.Text);
            if(i < skill_list.Count)
                textBox1.Text = skill_list[i];

            if (i < icon_list.Count)
                pictureBox1.ImageLocation = icon_list[i];

            if(i<des_list.Count)
                textBox4.Text = des_list[i];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
