using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Taxi_management_system.Select_forms
{
    public partial class MonetaryDayInfoForm : MaterialForm
    {
        public MonetaryDayInfoForm()
        {
            InitializeComponent();
            CreateListView();
            dateTimePicker.Value = DateTime.Today;
        }

        private void CreateListView()
        {
            carMonetaryListView.Columns.Add("CatId", -2, HorizontalAlignment.Left);
            carMonetaryListView.Columns.Add("Model", -2, HorizontalAlignment.Left);
            carMonetaryListView.Columns.Add("sum of prices", -2, HorizontalAlignment.Left);

            RefreshListView();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            carMonetaryListView.Items.Clear();

            string date = dateTimePicker.Value.Date.ToString(dateTimePicker.CustomFormat);
            var cars = MainForm.UnitOfWork.CarRepository.GetAll();

            int i = 0;
            var items = new ListViewItem[cars.Count()];
            foreach (var car in cars)
            {
                var item = new ListViewItem(car.Id.ToString());

                item.SubItems.Add(car.Model);
                item.SubItems.Add(MainForm.UnitOfWork.CarRepository.GetCarIncomeOfDay(car.Id, date));

                items[i] = item;
                i++;
            }

            carMonetaryListView.Items.AddRange(items);

            SetTotalInformationLabels(MainForm.UnitOfWork.CallRepository.DayInfo(date));
        }

        private void SetTotalInformationLabels(string dayInfoString)
        {
            string[] valuesOfMonetaryInformation = dayInfoString.Split(' ');

            totalMoneyLabel.Text = valuesOfMonetaryInformation[0];
            oilCostsLabel.Text = valuesOfMonetaryInformation[1];
            employeesSalariesLabel.Text = valuesOfMonetaryInformation[2];
            profitLabel.Text = valuesOfMonetaryInformation[3];
        }
    }
}
