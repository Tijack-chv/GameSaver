namespace GameSaver.View
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            labelErrorName = new Label();
            labelErrorSurname = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelErrorUsername = new Label();
            labelErorPassword = new Label();
            textBoxVerPassword = new TextBox();
            labelErrorVerPassword = new Label();
            labelName = new Label();
            labelVerPassword = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelSurname = new Label();
            buttonValidate = new Button();
            buttonBack = new Button();
            labelShow = new Label();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.BackColor = Color.ForestGreen;
            textBoxSurname.BorderStyle = BorderStyle.None;
            textBoxSurname.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxSurname.Location = new Point(429, 165);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(238, 34);
            textBoxSurname.TabIndex = 13;
            textBoxSurname.Text = "Surname";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.BackColor = Color.ForestGreen;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxName.Location = new Point(430, 99);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 34);
            textBoxName.TabIndex = 12;
            textBoxName.Text = "Name";
            // 
            // labelErrorName
            // 
            labelErrorName.Anchor = AnchorStyles.None;
            labelErrorName.AutoSize = true;
            labelErrorName.BackColor = Color.Transparent;
            labelErrorName.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorName.ForeColor = Color.Red;
            labelErrorName.Location = new Point(429, 136);
            labelErrorName.Name = "labelErrorName";
            labelErrorName.Size = new Size(208, 18);
            labelErrorName.TabIndex = 11;
            labelErrorName.Text = "message d'erreur nom";
            // 
            // labelErrorSurname
            // 
            labelErrorSurname.Anchor = AnchorStyles.None;
            labelErrorSurname.AutoSize = true;
            labelErrorSurname.BackColor = Color.Transparent;
            labelErrorSurname.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorSurname.ForeColor = Color.Red;
            labelErrorSurname.Location = new Point(424, 202);
            labelErrorSurname.Name = "labelErrorSurname";
            labelErrorSurname.Size = new Size(237, 18);
            labelErrorSurname.TabIndex = 10;
            labelErrorSurname.Text = "message d'erreur prénom";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.BackColor = Color.ForestGreen;
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxPassword.Location = new Point(429, 297);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(238, 34);
            textBoxPassword.TabIndex = 17;
            textBoxPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.BackColor = Color.ForestGreen;
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxUsername.Location = new Point(430, 231);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(238, 34);
            textBoxUsername.TabIndex = 16;
            textBoxUsername.Text = "Username";
            // 
            // labelErrorUsername
            // 
            labelErrorUsername.Anchor = AnchorStyles.None;
            labelErrorUsername.AutoSize = true;
            labelErrorUsername.BackColor = Color.Transparent;
            labelErrorUsername.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorUsername.ForeColor = Color.Red;
            labelErrorUsername.Location = new Point(429, 268);
            labelErrorUsername.Name = "labelErrorUsername";
            labelErrorUsername.Size = new Size(238, 18);
            labelErrorUsername.TabIndex = 15;
            labelErrorUsername.Text = "message d'erreur pseudo";
            // 
            // labelErorPassword
            // 
            labelErorPassword.Anchor = AnchorStyles.None;
            labelErorPassword.AutoSize = true;
            labelErorPassword.BackColor = Color.Transparent;
            labelErorPassword.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErorPassword.ForeColor = Color.Red;
            labelErorPassword.Location = new Point(424, 334);
            labelErorPassword.Name = "labelErorPassword";
            labelErorPassword.Size = new Size(298, 18);
            labelErorPassword.TabIndex = 14;
            labelErorPassword.Text = "message d'erreur mot de passe";
            // 
            // textBoxVerPassword
            // 
            textBoxVerPassword.Anchor = AnchorStyles.None;
            textBoxVerPassword.BackColor = Color.ForestGreen;
            textBoxVerPassword.BorderStyle = BorderStyle.None;
            textBoxVerPassword.Font = new Font("SimSun-ExtB", 20.25F, FontStyle.Bold | FontStyle.Italic);
            textBoxVerPassword.Location = new Point(430, 363);
            textBoxVerPassword.Name = "textBoxVerPassword";
            textBoxVerPassword.PasswordChar = '*';
            textBoxVerPassword.Size = new Size(238, 34);
            textBoxVerPassword.TabIndex = 19;
            textBoxVerPassword.Text = "P@ssw0rd";
            // 
            // labelErrorVerPassword
            // 
            labelErrorVerPassword.Anchor = AnchorStyles.None;
            labelErrorVerPassword.AutoSize = true;
            labelErrorVerPassword.BackColor = Color.Transparent;
            labelErrorVerPassword.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold);
            labelErrorVerPassword.ForeColor = Color.Red;
            labelErrorVerPassword.Location = new Point(425, 400);
            labelErrorVerPassword.Name = "labelErrorVerPassword";
            labelErrorVerPassword.Size = new Size(298, 18);
            labelErrorVerPassword.TabIndex = 18;
            labelErrorVerPassword.Text = "message d'erreur mot de passe";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("SimSun-ExtB", 13.2000008F, FontStyle.Bold);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(349, 105);
            labelName.Name = "labelName";
            labelName.Size = new Size(75, 23);
            labelName.TabIndex = 20;
            labelName.Text = "Nom :";
            // 
            // labelVerPassword
            // 
            labelVerPassword.AutoSize = true;
            labelVerPassword.BackColor = Color.Transparent;
            labelVerPassword.Font = new Font("SimSun-ExtB", 13.2000008F, FontStyle.Bold);
            labelVerPassword.ForeColor = Color.White;
            labelVerPassword.Location = new Point(192, 369);
            labelVerPassword.Name = "labelVerPassword";
            labelVerPassword.Size = new Size(231, 23);
            labelVerPassword.TabIndex = 21;
            labelVerPassword.Text = "2* Mot de passe :";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("SimSun-ExtB", 13.2000008F, FontStyle.Bold);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(231, 302);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(192, 23);
            labelPassword.TabIndex = 22;
            labelPassword.Text = "Mot de passe :";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("SimSun-ExtB", 13.2000008F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(310, 237);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 23);
            labelUsername.TabIndex = 23;
            labelUsername.Text = "Pseudo :";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.BackColor = Color.Transparent;
            labelSurname.Font = new Font("SimSun-ExtB", 13.2000008F, FontStyle.Bold);
            labelSurname.ForeColor = Color.White;
            labelSurname.Location = new Point(312, 170);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(111, 23);
            labelSurname.TabIndex = 24;
            labelSurname.Text = "Prénom :";
            // 
            // buttonValidate
            // 
            buttonValidate.BackColor = Color.LightGreen;
            buttonValidate.FlatStyle = FlatStyle.Popup;
            buttonValidate.Font = new Font("SimSun-ExtB", 20.2F, FontStyle.Bold);
            buttonValidate.Location = new Point(355, 455);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(170, 42);
            buttonValidate.TabIndex = 25;
            buttonValidate.Text = "Valider";
            buttonValidate.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.LightGreen;
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("SimSun-ExtB", 20.2F, FontStyle.Bold);
            buttonBack.Location = new Point(738, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(133, 42);
            buttonBack.TabIndex = 26;
            buttonBack.Text = "Retour";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelShow
            // 
            labelShow.Anchor = AnchorStyles.None;
            labelShow.AutoSize = true;
            labelShow.BackColor = Color.Transparent;
            labelShow.Font = new Font("SimSun-ExtB", 10F, FontStyle.Bold | FontStyle.Italic);
            labelShow.ForeColor = Color.White;
            labelShow.Location = new Point(417, 435);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(48, 17);
            labelShow.TabIndex = 27;
            labelShow.Text = "show";
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(875, 509);
            Controls.Add(labelShow);
            Controls.Add(buttonBack);
            Controls.Add(buttonValidate);
            Controls.Add(labelSurname);
            Controls.Add(labelUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelVerPassword);
            Controls.Add(labelName);
            Controls.Add(textBoxVerPassword);
            Controls.Add(labelErrorVerPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelErrorUsername);
            Controls.Add(labelErorPassword);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelErrorName);
            Controls.Add(labelErrorSurname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inscription";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label labelErrorName;
        private Label labelErrorSurname;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelErrorUsername;
        private Label labelErorPassword;
        private TextBox textBoxVerPassword;
        private Label labelErrorVerPassword;
        private Label labelName;
        private Label labelVerPassword;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelSurname;
        private Button buttonValidate;
        private Button buttonBack;
        private Label labelShow;
    }
}