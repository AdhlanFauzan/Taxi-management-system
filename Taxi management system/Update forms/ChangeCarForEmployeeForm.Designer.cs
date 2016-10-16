namespace Taxi_management_system.Update_forms
{
    partial class ChangeCarForEmployeeForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.oldCarIdTextBox = new System.Windows.Forms.TextBox();
            this.newCarIdTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Old car ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 140);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "New car ID";
            // 
            // oldCarIdTextBox
            // 
            this.oldCarIdTextBox.Enabled = false;
            this.oldCarIdTextBox.Location = new System.Drawing.Point(167, 94);
            this.oldCarIdTextBox.Name = "oldCarIdTextBox";
            this.oldCarIdTextBox.ReadOnly = true;
            this.oldCarIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldCarIdTextBox.TabIndex = 2;
            // 
            // newCarIdTextBox
            // 
            this.newCarIdTextBox.Location = new System.Drawing.Point(167, 139);
            this.newCarIdTextBox.Name = "newCarIdTextBox";
            this.newCarIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCarIdTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Depth = 0;
            this.submitButton.Location = new System.Drawing.Point(111, 180);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.Primary = false;
            this.submitButton.Size = new System.Drawing.Size(62, 36);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ChangeCarForEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 231);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newCarIdTextBox);
            this.Controls.Add(this.oldCarIdTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ChangeCarForEmployeeForm";
            this.Text = "Change car for employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox oldCarIdTextBox;
        private System.Windows.Forms.TextBox newCarIdTextBox;
        private MaterialSkin.Controls.MaterialFlatButton submitButton;
    }
}