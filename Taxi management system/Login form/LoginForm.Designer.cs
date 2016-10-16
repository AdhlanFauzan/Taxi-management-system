namespace Taxi_management_system.Login_form
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
            this.signInButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loginTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.AutoSize = true;
            this.signInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInButton.Depth = 0;
            this.signInButton.Location = new System.Drawing.Point(115, 214);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInButton.Name = "signInButton";
            this.signInButton.Primary = false;
            this.signInButton.Size = new System.Drawing.Size(60, 36);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Login:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 148);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password:";
            // 
            // loginTextField
            // 
            this.loginTextField.Depth = 0;
            this.loginTextField.Hint = "";
            this.loginTextField.Location = new System.Drawing.Point(137, 103);
            this.loginTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextField.Name = "loginTextField";
            this.loginTextField.PasswordChar = '\0';
            this.loginTextField.SelectedText = "";
            this.loginTextField.SelectionLength = 0;
            this.loginTextField.SelectionStart = 0;
            this.loginTextField.Size = new System.Drawing.Size(106, 23);
            this.loginTextField.TabIndex = 3;
            this.loginTextField.UseSystemPasswordChar = false;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Depth = 0;
            this.passwordTextField.Hint = "";
            this.passwordTextField.Location = new System.Drawing.Point(137, 148);
            this.passwordTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '\0';
            this.passwordTextField.SelectedText = "";
            this.passwordTextField.SelectionLength = 0;
            this.passwordTextField.SelectionStart = 0;
            this.passwordTextField.Size = new System.Drawing.Size(106, 23);
            this.passwordTextField.TabIndex = 4;
            this.passwordTextField.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 279);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.loginTextField);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.signInButton);
            this.Name = "LoginForm";
            this.Text = "Taxi management system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton signInButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTextField;
    }
}