namespace Taxi_management_system.Select_forms
{
    partial class MonetaryDayInfoForm
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
            this.carMonetaryListView = new System.Windows.Forms.ListView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.totalMoneyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.oilCostsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.employeesSalariesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.profitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // carMonetaryListView
            // 
            this.carMonetaryListView.Location = new System.Drawing.Point(12, 118);
            this.carMonetaryListView.Name = "carMonetaryListView";
            this.carMonetaryListView.Size = new System.Drawing.Size(473, 199);
            this.carMonetaryListView.TabIndex = 0;
            this.carMonetaryListView.UseCompatibleStateImageBehavior = false;
            this.carMonetaryListView.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(360, 31);
            this.dateTimePicker.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 10, 14, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2016, 10, 15, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 69);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(97, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Total money:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Oil costs:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(230, 69);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(144, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Employees salaries:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(230, 96);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Profir:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(115, 69);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(0, 19);
            this.materialLabel4.TabIndex = 11;
            // 
            // totalMoneyLabel
            // 
            this.totalMoneyLabel.AutoSize = true;
            this.totalMoneyLabel.Depth = 0;
            this.totalMoneyLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalMoneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalMoneyLabel.Location = new System.Drawing.Point(111, 69);
            this.totalMoneyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalMoneyLabel.Name = "totalMoneyLabel";
            this.totalMoneyLabel.Size = new System.Drawing.Size(61, 19);
            this.totalMoneyLabel.TabIndex = 12;
            this.totalMoneyLabel.Text = "0000.00";
            // 
            // oilCostsLabel
            // 
            this.oilCostsLabel.AutoSize = true;
            this.oilCostsLabel.Depth = 0;
            this.oilCostsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.oilCostsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.oilCostsLabel.Location = new System.Drawing.Point(111, 96);
            this.oilCostsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.oilCostsLabel.Name = "oilCostsLabel";
            this.oilCostsLabel.Size = new System.Drawing.Size(61, 19);
            this.oilCostsLabel.TabIndex = 13;
            this.oilCostsLabel.Text = "0000.00";
            // 
            // employeesSalariesLabel
            // 
            this.employeesSalariesLabel.AutoSize = true;
            this.employeesSalariesLabel.Depth = 0;
            this.employeesSalariesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.employeesSalariesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.employeesSalariesLabel.Location = new System.Drawing.Point(386, 69);
            this.employeesSalariesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.employeesSalariesLabel.Name = "employeesSalariesLabel";
            this.employeesSalariesLabel.Size = new System.Drawing.Size(61, 19);
            this.employeesSalariesLabel.TabIndex = 14;
            this.employeesSalariesLabel.Text = "0000.00";
            // 
            // profitLabel
            // 
            this.profitLabel.AutoSize = true;
            this.profitLabel.Depth = 0;
            this.profitLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.profitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profitLabel.Location = new System.Drawing.Point(386, 96);
            this.profitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(61, 19);
            this.profitLabel.TabIndex = 15;
            this.profitLabel.Text = "0000.00";
            // 
            // MonetaryDayInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(497, 329);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.employeesSalariesLabel);
            this.Controls.Add(this.oilCostsLabel);
            this.Controls.Add(this.totalMoneyLabel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.carMonetaryListView);
            this.Name = "MonetaryDayInfoForm";
            this.Text = "Monetary day info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carMonetaryListView;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel totalMoneyLabel;
        private MaterialSkin.Controls.MaterialLabel oilCostsLabel;
        private MaterialSkin.Controls.MaterialLabel employeesSalariesLabel;
        private MaterialSkin.Controls.MaterialLabel profitLabel;
    }
}