using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Taxi_management_system.Select_forms
{
    public partial class GetEmployeesByCarIdForm : MaterialForm
    {
        public GetEmployeesByCarIdForm()
        {
            InitializeComponent();
            CreateListView();
        }

        private void CreateListView()
        {
            employeesByCarIdListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            employeesByCarIdListView.Columns.Add("CarId", -2, HorizontalAlignment.Left);
            employeesByCarIdListView.Columns.Add("First name", -2, HorizontalAlignment.Left);
            employeesByCarIdListView.Columns.Add("Last name", -2, HorizontalAlignment.Left);
            employeesByCarIdListView.Columns.Add("Age", -2, HorizontalAlignment.Left);
            employeesByCarIdListView.Columns.Add("Gender", -2, HorizontalAlignment.Left);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var employees = MainForm.UnitOfWork.EmployeeRepository.GetEmployeesByCarId(Convert.ToInt32(carIdTextBox.Text));
            employeesByCarIdListView.Items.Clear();

            var items = new ListViewItem[employees.Count()];
            int i = 0;
            foreach (var employee in employees)
            {
                var item = new ListViewItem(employee.Id.ToString());

                item.SubItems.Add(employee.CarId.ToString());
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.Age.ToString());
                item.SubItems.Add(employee.Gender.ToString());

                items[i] = item;
                i++;
            }

            employeesByCarIdListView.Items.AddRange(items);
        }
    }
}
