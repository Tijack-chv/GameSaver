namespace GameSaver.View
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelUp = new Panel();
            pictureBoxPlayer = new PictureBox();
            labelPseudo = new Label();
            labelNameProg = new Label();
            pictureBoxLogo = new PictureBox();
            panelLeft = new Panel();
            buttonGame = new Button();
            buttonStat = new Button();
            buttonShop = new Button();
            buttonPlayerInfo = new Button();
            buttonMenu = new Button();
            buttonHome = new Button();
            buttonMoreInfo = new Button();
            panel1 = new Panel();
            panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.BackColor = Color.FromArgb(55, 60, 65);
            panelUp.Controls.Add(pictureBoxPlayer);
            panelUp.Controls.Add(labelPseudo);
            panelUp.Controls.Add(labelNameProg);
            panelUp.Controls.Add(pictureBoxLogo);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(1432, 99);
            panelUp.TabIndex = 0;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(1342, 15);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(70, 70);
            pictureBoxPlayer.TabIndex = 2;
            pictureBoxPlayer.TabStop = false;
            // 
            // labelPseudo
            // 
            labelPseudo.AutoSize = true;
            labelPseudo.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold);
            labelPseudo.Location = new Point(1088, 40);
            labelPseudo.Name = "labelPseudo";
            labelPseudo.Size = new Size(237, 28);
            labelPseudo.TabIndex = 1;
            labelPseudo.Text = "Pseudo connecté";
            // 
            // labelNameProg
            // 
            labelNameProg.AutoSize = true;
            labelNameProg.Font = new Font("SimSun-ExtB", 24.2F, FontStyle.Bold);
            labelNameProg.Location = new Point(142, 31);
            labelNameProg.Name = "labelNameProg";
            labelNameProg.Size = new Size(238, 41);
            labelNameProg.TabIndex = 1;
            labelNameProg.Text = "Game Saver";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(17, 9);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(111, 84);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(35, 40, 45);
            panelLeft.Controls.Add(buttonGame);
            panelLeft.Controls.Add(buttonStat);
            panelLeft.Controls.Add(buttonShop);
            panelLeft.Controls.Add(buttonPlayerInfo);
            panelLeft.Controls.Add(buttonMenu);
            panelLeft.Controls.Add(buttonHome);
            panelLeft.Controls.Add(buttonMoreInfo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 99);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(143, 604);
            panelLeft.TabIndex = 0;
            // 
            // buttonGame
            // 
            buttonGame.BackColor = Color.FromArgb(35, 40, 45);
            buttonGame.BackgroundImage = (Image)resources.GetObject("buttonGame.BackgroundImage");
            buttonGame.BackgroundImageLayout = ImageLayout.Center;
            buttonGame.FlatStyle = FlatStyle.Popup;
            buttonGame.Location = new Point(2, 314);
            buttonGame.Name = "buttonGame";
            buttonGame.Size = new Size(140, 60);
            buttonGame.TabIndex = 2;
            buttonGame.UseVisualStyleBackColor = false;
            // 
            // buttonStat
            // 
            buttonStat.BackColor = Color.FromArgb(35, 40, 45);
            buttonStat.BackgroundImage = (Image)resources.GetObject("buttonStat.BackgroundImage");
            buttonStat.BackgroundImageLayout = ImageLayout.Center;
            buttonStat.FlatStyle = FlatStyle.Popup;
            buttonStat.Location = new Point(2, 255);
            buttonStat.Name = "buttonStat";
            buttonStat.Size = new Size(140, 60);
            buttonStat.TabIndex = 5;
            buttonStat.UseVisualStyleBackColor = false;
            // 
            // buttonShop
            // 
            buttonShop.BackColor = Color.FromArgb(35, 40, 45);
            buttonShop.BackgroundImage = (Image)resources.GetObject("buttonShop.BackgroundImage");
            buttonShop.BackgroundImageLayout = ImageLayout.Center;
            buttonShop.FlatStyle = FlatStyle.Popup;
            buttonShop.Location = new Point(2, 470);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(140, 60);
            buttonShop.TabIndex = 6;
            buttonShop.UseVisualStyleBackColor = false;
            // 
            // buttonPlayerInfo
            // 
            buttonPlayerInfo.BackColor = Color.FromArgb(35, 40, 45);
            buttonPlayerInfo.BackgroundImage = (Image)resources.GetObject("buttonPlayerInfo.BackgroundImage");
            buttonPlayerInfo.BackgroundImageLayout = ImageLayout.Center;
            buttonPlayerInfo.FlatStyle = FlatStyle.Popup;
            buttonPlayerInfo.Location = new Point(2, 196);
            buttonPlayerInfo.Name = "buttonPlayerInfo";
            buttonPlayerInfo.Size = new Size(140, 60);
            buttonPlayerInfo.TabIndex = 3;
            buttonPlayerInfo.UseVisualStyleBackColor = false;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.FromArgb(35, 40, 45);
            buttonMenu.BackgroundImage = (Image)resources.GetObject("buttonMenu.BackgroundImage");
            buttonMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonMenu.FlatStyle = FlatStyle.Popup;
            buttonMenu.Location = new Point(2, 78);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(140, 60);
            buttonMenu.TabIndex = 1;
            buttonMenu.UseVisualStyleBackColor = false;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(35, 40, 45);
            buttonHome.BackgroundImage = (Image)resources.GetObject("buttonHome.BackgroundImage");
            buttonHome.BackgroundImageLayout = ImageLayout.Center;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Location = new Point(2, 137);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(140, 60);
            buttonHome.TabIndex = 2;
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.BackColor = Color.FromArgb(35, 40, 45);
            buttonMoreInfo.BackgroundImage = (Image)resources.GetObject("buttonMoreInfo.BackgroundImage");
            buttonMoreInfo.BackgroundImageLayout = ImageLayout.Center;
            buttonMoreInfo.FlatStyle = FlatStyle.Popup;
            buttonMoreInfo.Location = new Point(2, 529);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(140, 60);
            buttonMoreInfo.TabIndex = 4;
            buttonMoreInfo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(143, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 604);
            panel1.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1432, 703);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Controls.Add(panelUp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1450, 750);
            MinimumSize = new Size(1450, 750);
            Name = "Home";
            Text = "Home";
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp;
        private Panel panelLeft;
        private PictureBox pictureBoxLogo;
        private Label labelNameProg;
        private PictureBox pictureBoxPlayer;
        private Label labelPseudo;
        private Button buttonMenu;
        private Button buttonStat;
        private Button buttonShop;
        private Button buttonPlayerInfo;
        private Button buttonHome;
        private Button buttonMoreInfo;
        private Button buttonGame;
        private Panel panel1;
    }
}