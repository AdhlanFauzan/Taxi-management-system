namespace Taxi_management_system.Add_forms
{
    partial class AddCarForm
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.addCarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "License plate";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Model";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Mileage";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "State";
            // 
            // addCarButton
            // 
            this.addCarButton.AutoSize = true;
            this.addCarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCarButton.Depth = 0;
            this.addCarButton.Location = new System.Drawing.Point(117, 268);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Primary = false;
            this.addCarButton.Size = new System.Drawing.Size(62, 36);
            this.addCarButton.TabIndex = 4;
            this.addCarButton.Text = "Submit";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Location = new System.Drawing.Point(148, 89);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensePlateTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(148, 131);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(148, 174);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 7;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(148, 217);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 8;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 327);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.licensePlateTextBox);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddCarForm";
            this.Text = "Register new car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton addCarButton;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
    }
}