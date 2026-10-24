namespace Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(619, 111);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(574, 186);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "UserName";
            txt_username.Size = new Size(208, 27);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(574, 249);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(208, 27);
            txt_password.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.GradientInactiveCaption;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(574, 325);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(208, 43);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(877, 487);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
    }
}