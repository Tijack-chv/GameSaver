namespace GameSaver
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            labelInscription = new Label();
            labelErrorPassword = new Label();
            labelPassForget = new Label();
            labelVisitor = new Label();
            labelErrorPseudo = new Label();
            labelShow = new Label();
            textBoxPseudo = new TextBox();
            textBoxPassword = new TextBox();
            pictureBoxPseudo = new PictureBox();
            pictureBoxPassword = new PictureBox();
            buttonConnexion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPseudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            SuspendLayout();
            // 
            // labelInscription
            // 
            labelInscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelInscription.AutoSize = true;
            labelInscription.BackColor = Color.Transparent;
            labelInscription.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic);
            labelInscription.ForeColor = Color.White;
            labelInscription.Location = new Point(755, 9);
            labelInscription.Name = "labelInscription";
            labelInscription.Size = new Size(108, 20);
            labelInscription.TabIndex = 0;
            labelInscription.Text = "Nouveau ?";
            // 
            // labelErrorPassword
            // 
            labelErrorPassword.Anchor = AnchorStyles.None;
            labelErrorPassword.AutoSize = true;
            labelErrorPassword.BackColor = Color.Transparent;
            labelErrorPassword.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorPassword.ForeColor = Color.Red;
            labelErrorPassword.Location = new Point(314, 336);
            labelErrorPassword.Name = "labelErrorPassword";
            labelErrorPassword.Size = new Size(298, 18);
            labelErrorPassword.TabIndex = 3;
            labelErrorPassword.Text = "message d'erreur mot de passe";
            // 
            // labelPassForget
            // 
            labelPassForget.Anchor = AnchorStyles.None;
            labelPassForget.AutoSize = true;
            labelPassForget.BackColor = Color.Transparent;
            labelPassForget.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic);
            labelPassForget.ForeColor = Color.White;
            labelPassForget.Location = new Point(319, 407);
            labelPassForget.Name = "labelPassForget";
            labelPassForget.Size = new Size(238, 20);
            labelPassForget.TabIndex = 4;
            labelPassForget.Text = "Mot de passe oublié ?";
            // 
            // labelVisitor
            // 
            labelVisitor.Anchor = AnchorStyles.None;
            labelVisitor.AutoSize = true;
            labelVisitor.BackColor = Color.Transparent;
            labelVisitor.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold | FontStyle.Italic);
            labelVisitor.ForeColor = Color.White;
            labelVisitor.Location = new Point(344, 480);
            labelVisitor.Name = "labelVisitor";
            labelVisitor.Size = new Size(172, 20);
            labelVisitor.TabIndex = 5;
            labelVisitor.Text = "Accès visiteurs";
            // 
            // labelErrorPseudo
            // 
            labelErrorPseudo.Anchor = AnchorStyles.None;
            labelErrorPseudo.AutoSize = true;
            labelErrorPseudo.BackColor = Color.Transparent;
            labelErrorPseudo.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorPseudo.ForeColor = Color.Red;
            labelErrorPseudo.Location = new Point(318, 246);
            labelErrorPseudo.Name = "labelErrorPseudo";
            labelErrorPseudo.Size = new Size(238, 18);
            labelErrorPseudo.TabIndex = 6;
            labelErrorPseudo.Text = "message d'erreur pseudo";
            // 
            // labelShow
            // 
            labelShow.Anchor = AnchorStyles.None;
            labelShow.AutoSize = true;
            labelShow.BackColor = Color.Transparent;
            labelShow.Font = new Font("SimSun-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            labelShow.ForeColor = Color.White;
            labelShow.Location = new Point(568, 307);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(48, 17);
            labelShow.TabIndex = 7;
            labelShow.Text = "show";
            // 
            // textBoxPseudo
            // 
            textBoxPseudo.Anchor = AnchorStyles.None;
            textBoxPseudo.BackColor = Color.ForestGreen;
            textBoxPseudo.BorderStyle = BorderStyle.None;
            textBoxPseudo.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxPseudo.Location = new Point(319, 209);
            textBoxPseudo.Name = "textBoxPseudo";
            textBoxPseudo.Size = new Size(238, 34);
            textBoxPseudo.TabIndex = 8;
            textBoxPseudo.Text = "Pseudo";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = Color.ForestGreen;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxPassword.Location = new Point(319, 299);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(238, 34);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.Text = "Password";
            // 
            // pictureBoxPseudo
            // 
            pictureBoxPseudo.Anchor = AnchorStyles.None;
            pictureBoxPseudo.BackColor = Color.Transparent;
            pictureBoxPseudo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPseudo.Image = (Image)resources.GetObject("pictureBoxPseudo.Image");
            pictureBoxPseudo.Location = new Point(229, 198);
            pictureBoxPseudo.Name = "pictureBoxPseudo";
            pictureBoxPseudo.Size = new Size(84, 62);
            pictureBoxPseudo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPseudo.TabIndex = 10;
            pictureBoxPseudo.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Anchor = AnchorStyles.None;
            pictureBoxPassword.BackColor = Color.Transparent;
            pictureBoxPassword.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
            pictureBoxPassword.Location = new Point(229, 284);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(84, 62);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 11;
            pictureBoxPassword.TabStop = false;
            // 
            // buttonConnexion
            // 
            buttonConnexion.Anchor = AnchorStyles.None;
            buttonConnexion.BackColor = Color.LightGreen;
            buttonConnexion.FlatStyle = FlatStyle.Popup;
            buttonConnexion.Font = new Font("SimSun-ExtB", 20.2F, FontStyle.Bold);
            buttonConnexion.Location = new Point(337, 438);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(189, 39);
            buttonConnexion.TabIndex = 12;
            buttonConnexion.Text = "CONNEXION";
            buttonConnexion.UseVisualStyleBackColor = false;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 509);
            Controls.Add(buttonConnexion);
            Controls.Add(pictureBoxPassword);
            Controls.Add(pictureBoxPseudo);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxPseudo);
            Controls.Add(labelShow);
            Controls.Add(labelErrorPseudo);
            Controls.Add(labelVisitor);
            Controls.Add(labelPassForget);
            Controls.Add(labelErrorPassword);
            Controls.Add(labelInscription);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Connexion";
            Text = "GameSaver";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPseudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInscription;
        private Label labelErrorPassword;
        private Label labelPassForget;
        private Label labelVisitor;
        private Label labelErrorPseudo;
        private Label labelShow;
        private TextBox textBoxPseudo;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxPseudo;
        private PictureBox pictureBoxPassword;
        private Button buttonConnexion;
    }
}