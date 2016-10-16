namespace Taxi_management_system.Select_forms
{
    partial class GetCallsByCarIdForm
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
            this.callsByCarIdListView = new System.Windows.Forms.ListView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.carIdTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // callsByCarIdListView
            // 
            this.callsByCarIdListView.Location = new System.Drawing.Point(12, 125);
            this.callsByCarIdListView.Name = "callsByCarIdListView";
            this.callsByCarIdListView.Size = new System.Drawing.Size(632, 166);
            this.callsByCarIdListView.TabIndex = 0;
            this.callsByCarIdListView.UseCompatibleStateImageBehavior = false;
            this.callsByCarIdListView.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Enter ID:";
            // 
            // carIdTextBox
            // 
            this.carIdTextBox.Location = new System.Drawing.Point(84, 82);
            this.carIdTextBox.Name = "carIdTextBox";
            this.carIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.carIdTextBox.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findButton.Depth = 0;
            this.findButton.Location = new System.Drawing.Point(601, 75);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.findButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.findButton.Name = "findButton";
            this.findButton.Primary = false;
            this.findButton.Size = new System.Drawing.Size(42, 36);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // GetCallsByCarIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(656, 300);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.carIdTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.callsByCarIdListView);
            this.Name = "GetCallsByCarIdForm";
            this.Text = "Get calls by car id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView callsByCarIdListView;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox carIdTextBox;
        private MaterialSkin.Controls.MaterialFlatButton findButton;
    }
}