using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Taxi_management_system.Select_forms
{
    public partial class GetCallsByCarIdForm : MaterialForm
    {
        public GetCallsByCarIdForm()
        {
            InitializeComponent();
            CreateListView();
        }

        private void CreateListView()
        {
            callsByCarIdListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("CarId", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("Departure place", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("Arrival place", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("Distance", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("Price", -2, HorizontalAlignment.Left);
            callsByCarIdListView.Columns.Add("Date", -2, HorizontalAlignment.Left);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var calls = MainForm.UnitOfWork.CallRepository.GetCallsByCarId(Convert.ToInt32(carIdTextBox.Text));
            callsByCarIdListView.Items.Clear();

            var items = new ListViewItem[calls.Count()];
            int i = 0;
            foreach (var call in calls)
            {
                var item = new ListViewItem(call.Id.ToString());

                item.SubItems.Add(call.CarId.ToString());
                item.SubItems.Add(call.DeparturePlace);
                item.SubItems.Add(call.ArrivalPlace);
                item.SubItems.Add(call.Distance.ToString());
                item.SubItems.Add(call.Price.ToString());
                item.SubItems.Add(call.Date);

                items[i] = item;
                i++;
            }

            callsByCarIdListView.Items.AddRange(items);
        }
    }
}
