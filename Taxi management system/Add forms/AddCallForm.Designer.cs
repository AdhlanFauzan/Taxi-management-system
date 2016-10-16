namespace Taxi_management_system.Add_forms
{
    partial class AddCallForm
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
            this.carIdTextBox = new System.Windows.Forms.TextBox();
            this.departurePlaceTextBox = new System.Windows.Forms.TextBox();
            this.arrivalPlaceTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
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
            this.materialLabel1.Location = new System.Drawing.Point(13, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "CarID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(114, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Departure place";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(13, 164);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Arrival place";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 204);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Distance";
            // 
            // carIdTextBox
            // 
            this.carIdTextBox.Location = new System.Drawing.Point(146, 84);
            this.carIdTextBox.Name = "carIdTextBox";
            this.carIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.carIdTextBox.TabIndex = 5;
            // 
            // departurePlaceTextBox
            // 
            this.departurePlaceTextBox.Location = new System.Drawing.Point(146, 126);
            this.departurePlaceTextBox.Name = "departurePlaceTextBox";
            this.departurePlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.departurePlaceTextBox.TabIndex = 6;
            // 
            // arrivalPlaceTextBox
            // 
            this.arrivalPlaceTextBox.Location = new System.Drawing.Point(146, 165);
            this.arrivalPlaceTextBox.Name = "arrivalPlaceTextBox";
            this.arrivalPlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.arrivalPlaceTextBox.TabIndex = 7;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(146, 205);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.distanceTextBox.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Depth = 0;
            this.submitButton.Location = new System.Drawing.Point(113, 266);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.submitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.submitButton.Name = "submitButton";
            this.submitButton.Primary = false;
            this.submitButton.Size = new System.Drawing.Size(62, 36);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 327);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.arrivalPlaceTextBox);
            this.Controls.Add(this.departurePlaceTextBox);
            this.Controls.Add(this.carIdTextBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddCallForm";
            this.Text = "Register new call";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox carIdTextBox;
        private System.Windows.Forms.TextBox departurePlaceTextBox;
        private System.Windows.Forms.TextBox arrivalPlaceTextBox;
        private System.Windows.Forms.TextBox distanceTextBox;
        private MaterialSkin.Controls.MaterialFlatButton submitButton;
    }
}