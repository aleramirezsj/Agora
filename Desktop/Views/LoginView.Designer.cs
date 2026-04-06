namespace Desktop.Views
{
    partial class LoginView
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
            pictureBox1 = new PictureBox();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnIniciarSesion = new FontAwesome.Sharp.IconButton();
            CheckVerContraseña = new CheckBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            TxtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Generated_Image_September_02__2025___4_57PM_removebg_preview;
            pictureBox1.Location = new Point(-25, -6);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancelar.BackColor = Color.LightGray;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(543, 197);
            BtnCancelar.Margin = new Padding(2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(146, 53);
            BtnCancelar.TabIndex = 25;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnIniciarSesion.BackColor = Color.DarkGray;
            BtnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            BtnIniciarSesion.IconColor = Color.Black;
            BtnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnIniciarSesion.Location = new Point(353, 197);
            BtnIniciarSesion.Margin = new Padding(2);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(147, 53);
            BtnIniciarSesion.TabIndex = 24;
            BtnIniciarSesion.Text = "Iniciar sesión";
            BtnIniciarSesion.TextAlign = ContentAlignment.MiddleRight;
            BtnIniciarSesion.UseVisualStyleBackColor = false;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // CheckVerContraseña
            // 
            CheckVerContraseña.AutoSize = true;
            CheckVerContraseña.Location = new Point(433, 150);
            CheckVerContraseña.Margin = new Padding(2);
            CheckVerContraseña.Name = "CheckVerContraseña";
            CheckVerContraseña.Size = new Size(128, 24);
            CheckVerContraseña.TabIndex = 23;
            CheckVerContraseña.Text = "Ver contraseña";
            CheckVerContraseña.UseVisualStyleBackColor = true;
            CheckVerContraseña.CheckedChanged += CheckVerContraseña_CheckedChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(433, 103);
            TxtPassword.Margin = new Padding(2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(240, 27);
            TxtPassword.TabIndex = 22;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 21;
            label2.Text = "Password:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(433, 50);
            TxtEmail.Margin = new Padding(2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(240, 27);
            TxtEmail.TabIndex = 20;
            TxtEmail.KeyPress += TxtEmail_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 19;
            label1.Text = "Email:";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 291);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(CheckVerContraseña);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public FontAwesome.Sharp.IconButton BtnCancelar;
        public FontAwesome.Sharp.IconButton BtnIniciarSesion;
        private CheckBox CheckVerContraseña;
        private TextBox TxtPassword;
        private Label label2;
        private TextBox TxtEmail;
        private Label label1;
    }
}