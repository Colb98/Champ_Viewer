namespace Champ_Viewer
{
    partial class ChampView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChampView));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.selecthl = new System.Windows.Forms.Panel();
            this.skill = new System.Windows.Forms.Button();
            this.skin = new System.Windows.Forms.Button();
            this.champion = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.banner = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.skinUC1 = new Champ_Viewer.SkinUC();
            this.homeUC1 = new Champ_Viewer.HomeUC();
            this.championUC1 = new Champ_Viewer.ChampionUC();
            this.skillUC1 = new Champ_Viewer.SkillUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.selecthl);
            this.panel1.Controls.Add(this.skill);
            this.panel1.Controls.Add(this.skin);
            this.panel1.Controls.Add(this.champion);
            this.panel1.Controls.Add(this.home);
            this.transition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 397);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.transition2.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(158, 6);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(36, 36);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // selecthl
            // 
            this.selecthl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selecthl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            this.transition2.SetDecoration(this.selecthl, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.selecthl, BunifuAnimatorNS.DecorationType.None);
            this.selecthl.Location = new System.Drawing.Point(195, 109);
            this.selecthl.Name = "selecthl";
            this.selecthl.Size = new System.Drawing.Size(6, 62);
            this.selecthl.TabIndex = 1;
            // 
            // skill
            // 
            this.transition1.SetDecoration(this.skill, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.skill, BunifuAnimatorNS.DecorationType.None);
            this.skill.FlatAppearance.BorderSize = 0;
            this.skill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skill.ForeColor = System.Drawing.Color.White;
            this.skill.Image = ((System.Drawing.Image)(resources.GetObject("skill.Image")));
            this.skill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skill.Location = new System.Drawing.Point(0, 295);
            this.skill.Margin = new System.Windows.Forms.Padding(0);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(195, 62);
            this.skill.TabIndex = 0;
            this.skill.Text = "Skill";
            this.skill.UseVisualStyleBackColor = true;
            this.skill.Click += new System.EventHandler(this.skill_Click);
            // 
            // skin
            // 
            this.transition1.SetDecoration(this.skin, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.skin, BunifuAnimatorNS.DecorationType.None);
            this.skin.FlatAppearance.BorderSize = 0;
            this.skin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skin.ForeColor = System.Drawing.Color.White;
            this.skin.Image = ((System.Drawing.Image)(resources.GetObject("skin.Image")));
            this.skin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skin.Location = new System.Drawing.Point(0, 233);
            this.skin.Margin = new System.Windows.Forms.Padding(0);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(195, 62);
            this.skin.TabIndex = 0;
            this.skin.Text = "Skin";
            this.skin.UseVisualStyleBackColor = true;
            this.skin.Click += new System.EventHandler(this.skin_Click);
            // 
            // champion
            // 
            this.transition1.SetDecoration(this.champion, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.champion, BunifuAnimatorNS.DecorationType.None);
            this.champion.FlatAppearance.BorderSize = 0;
            this.champion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.champion.ForeColor = System.Drawing.Color.White;
            this.champion.Image = ((System.Drawing.Image)(resources.GetObject("champion.Image")));
            this.champion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.champion.Location = new System.Drawing.Point(0, 171);
            this.champion.Margin = new System.Windows.Forms.Padding(0);
            this.champion.Name = "champion";
            this.champion.Size = new System.Drawing.Size(195, 62);
            this.champion.TabIndex = 0;
            this.champion.Text = "Champion";
            this.champion.UseVisualStyleBackColor = true;
            this.champion.Click += new System.EventHandler(this.champion_Click);
            // 
            // home
            // 
            this.transition1.SetDecoration(this.home, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.home, BunifuAnimatorNS.DecorationType.None);
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(0, 109);
            this.home.Margin = new System.Windows.Forms.Padding(0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(195, 62);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            this.banner.Controls.Add(this.bunifuImageButton2);
            this.banner.Controls.Add(this.bunifuImageButton1);
            this.transition2.SetDecoration(this.banner, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.banner, BunifuAnimatorNS.DecorationType.None);
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(201, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(505, 30);
            this.banner.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.transition2.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(437, 0);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.transition2.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(475, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.banner;
            this.bunifuDragControl1.Vertical = true;
            // 
            // transition1
            // 
            this.transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition1.DefaultAnimation = animation1;
            // 
            // pictureBox1
            // 
            this.transition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // transition2
            // 
            this.transition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transition2.DefaultAnimation = animation2;
            // 
            // pictureBox2
            // 
            this.transition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // skinUC1
            // 
            this.skinUC1.AutoScroll = true;
            this.skinUC1.AutoSize = true;
            this.skinUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.transition1.SetDecoration(this.skinUC1, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.skinUC1, BunifuAnimatorNS.DecorationType.None);
            this.skinUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinUC1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinUC1.ForeColor = System.Drawing.Color.White;
            this.skinUC1.Location = new System.Drawing.Point(201, 30);
            this.skinUC1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.skinUC1.Name = "skinUC1";
            this.skinUC1.Size = new System.Drawing.Size(505, 367);
            this.skinUC1.TabIndex = 5;
            // 
            // homeUC1
            // 
            this.homeUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.transition1.SetDecoration(this.homeUC1, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.homeUC1, BunifuAnimatorNS.DecorationType.None);
            this.homeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUC1.Location = new System.Drawing.Point(201, 30);
            this.homeUC1.Margin = new System.Windows.Forms.Padding(5);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(505, 367);
            this.homeUC1.TabIndex = 4;
            // 
            // championUC1
            // 
            this.championUC1.AutoScroll = true;
            this.championUC1.AutoSize = true;
            this.championUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.transition2.SetDecoration(this.championUC1, BunifuAnimatorNS.DecorationType.None);
            this.transition1.SetDecoration(this.championUC1, BunifuAnimatorNS.DecorationType.None);
            this.championUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.championUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championUC1.Location = new System.Drawing.Point(201, 30);
            this.championUC1.Name = "championUC1";
            this.championUC1.Size = new System.Drawing.Size(505, 367);
            this.championUC1.TabIndex = 2;
            // 
            // skillUC1
            // 
            this.skillUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.transition1.SetDecoration(this.skillUC1, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this.skillUC1, BunifuAnimatorNS.DecorationType.None);
            this.skillUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillUC1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.skillUC1.ForeColor = System.Drawing.Color.White;
            this.skillUC1.Location = new System.Drawing.Point(201, 30);
            this.skillUC1.Name = "skillUC1";
            this.skillUC1.Size = new System.Drawing.Size(505, 367);
            this.skillUC1.TabIndex = 6;
            // 
            // ChampView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(706, 397);
            this.Controls.Add(this.skillUC1);
            this.Controls.Add(this.skinUC1);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.championUC1);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.panel1);
            this.transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChampView";
            this.Text = "Champion Viewer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel banner;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button skill;
        private System.Windows.Forms.Button skin;
        private System.Windows.Forms.Button champion;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel selecthl;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private BunifuAnimatorNS.BunifuTransition transition2;
        private BunifuAnimatorNS.BunifuTransition transition1;
        private ChampionUC championUC1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HomeUC homeUC1;
        private SkinUC skinUC1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SkillUC skillUC1;
    }
}

