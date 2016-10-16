namespace Taxi_management_system.Update_forms
{
    partial class ChangeCarStateForm
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
            this.oldCarStateTextBox = new System.Windows.Forms.TextBox();
            this.newCarStateTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 91);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Old car state";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 132);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(102, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "New car state";
            // 
            // oldCarStateTextBox
            // 
            this.oldCarStateTextBox.Enabled = false;
            this.oldCarStateTextBox.Location = new System.Drawing.Point(166, 89);
            this.oldCarStateTextBox.Name = "oldCarStateTextBox";
            this.oldCarStateTextBox.ReadOnly = true;
            this.oldCarStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.oldCarStateTextBox.TabIndex = 2;
            // 
            // newCarStateTextBox
            // 
            this.newCarStateTextBox.Location = new System.Drawing.Point(166, 133);
            this.newCarStateTextBox.Name = "newCarStateTextBox";
            this.newCarStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.newCarStateTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitButton.Depth = 0;
            this.SubmitButton.Location = new System.Drawing.Point(111, 180);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SubmitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Primary = false;
            this.SubmitButton.Size = new System.Drawing.Size(62, 36);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ChangeCarStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 231);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.newCarStateTextBox);
            this.Controls.Add(this.oldCarStateTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ChangeCarStateForm";
            this.Text = "Change car state form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox oldCarStateTextBox;
        private System.Windows.Forms.TextBox newCarStateTextBox;
        private MaterialSkin.Controls.MaterialFlatButton SubmitButton;
    }
}