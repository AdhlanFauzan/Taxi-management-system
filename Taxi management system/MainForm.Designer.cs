namespace Taxi_management_system
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.callsTabPage = new System.Windows.Forms.TabPage();
            this.addCallButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeCallButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.callsListView = new System.Windows.Forms.ListView();
            this.carsTabPage = new System.Windows.Forms.TabPage();
            this.getEmployeesByCarIdButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.getCallsByCarIdButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.changeCarStateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.addCarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.carsListView = new System.Windows.Forms.ListView();
            this.EmployeesTabPage = new System.Windows.Forms.TabPage();
            this.changeCarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeEmployeeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.addEmployeeButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.employeesListView = new System.Windows.Forms.ListView();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dayInfoButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeCarButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.callsTabPage.SuspendLayout();
            this.carsTabPage.SuspendLayout();
            this.EmployeesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.callsTabPage);
            this.materialTabControl1.Controls.Add(this.carsTabPage);
            this.materialTabControl1.Controls.Add(this.EmployeesTabPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 65);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(751, 470);
            this.materialTabControl1.TabIndex = 0;
            // 
            // callsTabPage
            // 
            this.callsTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.callsTabPage.Controls.Add(this.addCallButton);
            this.callsTabPage.Controls.Add(this.removeCallButton);
            this.callsTabPage.Controls.Add(this.callsListView);
            this.callsTabPage.Location = new System.Drawing.Point(4, 22);
            this.callsTabPage.Name = "callsTabPage";
            this.callsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.callsTabPage.Size = new System.Drawing.Size(743, 444);
            this.callsTabPage.TabIndex = 0;
            this.callsTabPage.Text = "Calls";
            // 
            // addCallButton
            // 
            this.addCallButton.AutoSize = true;
            this.addCallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCallButton.BackColor = System.Drawing.SystemColors.Window;
            this.addCallButton.Depth = 0;
            this.addCallButton.Location = new System.Drawing.Point(7, 24);
            this.addCallButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCallButton.Name = "addCallButton";
            this.addCallButton.Primary = false;
            this.addCallButton.Size = new System.Drawing.Size(144, 36);
            this.addCallButton.TabIndex = 2;
            this.addCallButton.Text = "Register new call";
            this.addCallButton.UseVisualStyleBackColor = false;
            this.addCallButton.Click += new System.EventHandler(this.addCallButton_Click);
            // 
            // removeCallButton
            // 
            this.removeCallButton.AutoSize = true;
            this.removeCallButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeCallButton.Depth = 0;
            this.removeCallButton.Location = new System.Drawing.Point(159, 24);
            this.removeCallButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeCallButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeCallButton.Name = "removeCallButton";
            this.removeCallButton.Primary = false;
            this.removeCallButton.Size = new System.Drawing.Size(66, 36);
            this.removeCallButton.TabIndex = 1;
            this.removeCallButton.Text = "Remove";
            this.removeCallButton.UseVisualStyleBackColor = true;
            this.removeCallButton.Click += new System.EventHandler(this.removeCallButton_Click);
            // 
            // callsListView
            // 
            this.callsListView.FullRowSelect = true;
            this.callsListView.Location = new System.Drawing.Point(8, 69);
            this.callsListView.MultiSelect = false;
            this.callsListView.Name = "callsListView";
            this.callsListView.Size = new System.Drawing.Size(732, 366);
            this.callsListView.TabIndex = 0;
            this.callsListView.UseCompatibleStateImageBehavior = false;
            this.callsListView.View = System.Windows.Forms.View.Details;
            // 
            // carsTabPage
            // 
            this.carsTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.carsTabPage.Controls.Add(this.removeCarButton);
            this.carsTabPage.Controls.Add(this.getEmployeesByCarIdButton);
            this.carsTabPage.Controls.Add(this.getCallsByCarIdButton1);
            this.carsTabPage.Controls.Add(this.changeCarStateButton);
            this.carsTabPage.Controls.Add(this.addCarButton);
            this.carsTabPage.Controls.Add(this.carsListView);
            this.carsTabPage.Location = new System.Drawing.Point(4, 22);
            this.carsTabPage.Name = "carsTabPage";
            this.carsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsTabPage.Size = new System.Drawing.Size(743, 444);
            this.carsTabPage.TabIndex = 1;
            this.carsTabPage.Text = "Cars";
            // 
            // getEmployeesByCarIdButton
            // 
            this.getEmployeesByCarIdButton.AutoSize = true;
            this.getEmployeesByCarIdButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getEmployeesByCarIdButton.Depth = 0;
            this.getEmployeesByCarIdButton.Location = new System.Drawing.Point(328, 24);
            this.getEmployeesByCarIdButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getEmployeesByCarIdButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getEmployeesByCarIdButton.Name = "getEmployeesByCarIdButton";
            this.getEmployeesByCarIdButton.Primary = false;
            this.getEmployeesByCarIdButton.Size = new System.Drawing.Size(151, 36);
            this.getEmployeesByCarIdButton.TabIndex = 4;
            this.getEmployeesByCarIdButton.Text = "Show car\'s drivers";
            this.getEmployeesByCarIdButton.UseVisualStyleBackColor = true;
            this.getEmployeesByCarIdButton.Click += new System.EventHandler(this.getEmployeesByCarIdButton_Click);
            // 
            // getCallsByCarIdButton1
            // 
            this.getCallsByCarIdButton1.AutoSize = true;
            this.getCallsByCarIdButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getCallsByCarIdButton1.Depth = 0;
            this.getCallsByCarIdButton1.Location = new System.Drawing.Point(171, 24);
            this.getCallsByCarIdButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getCallsByCarIdButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.getCallsByCarIdButton1.Name = "getCallsByCarIdButton1";
            this.getCallsByCarIdButton1.Primary = false;
            this.getCallsByCarIdButton1.Size = new System.Drawing.Size(137, 36);
            this.getCallsByCarIdButton1.TabIndex = 3;
            this.getCallsByCarIdButton1.Text = "Show car\'s calls";
            this.getCallsByCarIdButton1.UseVisualStyleBackColor = true;
            this.getCallsByCarIdButton1.Click += new System.EventHandler(this.getCallsByCarIdButton_Click);
            // 
            // changeCarStateButton
            // 
            this.changeCarStateButton.AutoSize = true;
            this.changeCarStateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeCarStateButton.Depth = 0;
            this.changeCarStateButton.Location = new System.Drawing.Point(505, 24);
            this.changeCarStateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeCarStateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeCarStateButton.Name = "changeCarStateButton";
            this.changeCarStateButton.Primary = false;
            this.changeCarStateButton.Size = new System.Drawing.Size(112, 36);
            this.changeCarStateButton.TabIndex = 2;
            this.changeCarStateButton.Text = "Change state";
            this.changeCarStateButton.UseVisualStyleBackColor = true;
            this.changeCarStateButton.Click += new System.EventHandler(this.changeCarStateButton_Click);
            // 
            // addCarButton
            // 
            this.addCarButton.AutoSize = true;
            this.addCarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCarButton.BackColor = System.Drawing.Color.Yellow;
            this.addCarButton.Depth = 0;
            this.addCarButton.Location = new System.Drawing.Point(6, 24);
            this.addCarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Primary = false;
            this.addCarButton.Size = new System.Drawing.Size(138, 36);
            this.addCarButton.TabIndex = 1;
            this.addCarButton.Text = "Register new car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // carsListView
            // 
            this.carsListView.FullRowSelect = true;
            this.carsListView.Location = new System.Drawing.Point(6, 69);
            this.carsListView.MultiSelect = false;
            this.carsListView.Name = "carsListView";
            this.carsListView.Size = new System.Drawing.Size(732, 366);
            this.carsListView.TabIndex = 0;
            this.carsListView.UseCompatibleStateImageBehavior = false;
            this.carsListView.View = System.Windows.Forms.View.Details;
            // 
            // EmployeesTabPage
            // 
            this.EmployeesTabPage.BackColor = System.Drawing.Color.AliceBlue;
            this.EmployeesTabPage.Controls.Add(this.changeCarButton);
            this.EmployeesTabPage.Controls.Add(this.removeEmployeeButton);
            this.EmployeesTabPage.Controls.Add(this.addEmployeeButton);
            this.EmployeesTabPage.Controls.Add(this.employeesListView);
            this.EmployeesTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeesTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTabPage.Name = "EmployeesTabPage";
            this.EmployeesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesTabPage.Size = new System.Drawing.Size(743, 444);
            this.EmployeesTabPage.TabIndex = 2;
            this.EmployeesTabPage.Text = "Employees";
            // 
            // changeCarButton
            // 
            this.changeCarButton.AutoSize = true;
            this.changeCarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeCarButton.Depth = 0;
            this.changeCarButton.Location = new System.Drawing.Point(192, 24);
            this.changeCarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeCarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeCarButton.Name = "changeCarButton";
            this.changeCarButton.Primary = false;
            this.changeCarButton.Size = new System.Drawing.Size(97, 36);
            this.changeCarButton.TabIndex = 3;
            this.changeCarButton.Text = "Change car";
            this.changeCarButton.UseVisualStyleBackColor = true;
            this.changeCarButton.Click += new System.EventHandler(this.changeCarButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.AutoSize = true;
            this.removeEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeEmployeeButton.Depth = 0;
            this.removeEmployeeButton.Location = new System.Drawing.Point(297, 24);
            this.removeEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Primary = false;
            this.removeEmployeeButton.Size = new System.Drawing.Size(66, 36);
            this.removeEmployeeButton.TabIndex = 2;
            this.removeEmployeeButton.Text = "Remove";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEmployeeButton.Depth = 0;
            this.addEmployeeButton.Location = new System.Drawing.Point(4, 24);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addEmployeeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Primary = false;
            this.addEmployeeButton.Size = new System.Drawing.Size(180, 36);
            this.addEmployeeButton.TabIndex = 1;
            this.addEmployeeButton.Text = "Register new employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // employeesListView
            // 
            this.employeesListView.FullRowSelect = true;
            this.employeesListView.Location = new System.Drawing.Point(6, 69);
            this.employeesListView.MultiSelect = false;
            this.employeesListView.Name = "employeesListView";
            this.employeesListView.Size = new System.Drawing.Size(732, 366);
            this.employeesListView.TabIndex = 0;
            this.employeesListView.UseCompatibleStateImageBehavior = false;
            this.employeesListView.View = System.Windows.Forms.View.Details;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.DarkRed;
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(270, 27);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(416, 32);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // dayInfoButton
            // 
            this.dayInfoButton.BackColor = System.Drawing.Color.AliceBlue;
            this.dayInfoButton.Depth = 0;
            this.dayInfoButton.Location = new System.Drawing.Point(665, 27);
            this.dayInfoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dayInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dayInfoButton.Name = "dayInfoButton";
            this.dayInfoButton.Primary = false;
            this.dayInfoButton.Size = new System.Drawing.Size(72, 32);
            this.dayInfoButton.TabIndex = 2;
            this.dayInfoButton.Text = "Day Info";
            this.dayInfoButton.UseVisualStyleBackColor = false;
            this.dayInfoButton.Click += new System.EventHandler(this.dayInfoButton_Click);
            // 
            // removeCarButton
            // 
            this.removeCarButton.AutoSize = true;
            this.removeCarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeCarButton.Depth = 0;
            this.removeCarButton.Location = new System.Drawing.Point(640, 24);
            this.removeCarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeCarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeCarButton.Name = "removeCarButton";
            this.removeCarButton.Primary = false;
            this.removeCarButton.Size = new System.Drawing.Size(66, 36);
            this.removeCarButton.TabIndex = 6;
            this.removeCarButton.Text = "Remove";
            this.removeCarButton.UseVisualStyleBackColor = true;
            this.removeCarButton.Click += new System.EventHandler(this.removeCarButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(753, 534);
            this.Controls.Add(this.dayInfoButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Text = "Taxi Management System";
            this.materialTabControl1.ResumeLayout(false);
            this.callsTabPage.ResumeLayout(false);
            this.callsTabPage.PerformLayout();
            this.carsTabPage.ResumeLayout(false);
            this.carsTabPage.PerformLayout();
            this.EmployeesTabPage.ResumeLayout(false);
            this.EmployeesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage callsTabPage;
        private System.Windows.Forms.TabPage carsTabPage;
        private System.Windows.Forms.TabPage EmployeesTabPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton addEmployeeButton;
        private MaterialSkin.Controls.MaterialFlatButton removeEmployeeButton;
        private System.Windows.Forms.ListView callsListView;
        private MaterialSkin.Controls.MaterialFlatButton removeCallButton;
        private MaterialSkin.Controls.MaterialFlatButton addCallButton;
        private MaterialSkin.Controls.MaterialFlatButton addCarButton;
        private MaterialSkin.Controls.MaterialFlatButton changeCarButton;
        internal System.Windows.Forms.ListView employeesListView;
        internal System.Windows.Forms.ListView carsListView;
        private MaterialSkin.Controls.MaterialFlatButton changeCarStateButton;
        private MaterialSkin.Controls.MaterialFlatButton getCallsByCarIdButton1;
        private MaterialSkin.Controls.MaterialFlatButton getEmployeesByCarIdButton;
        private MaterialSkin.Controls.MaterialFlatButton dayInfoButton;
        private MaterialSkin.Controls.MaterialFlatButton removeCarButton;
    }
}

