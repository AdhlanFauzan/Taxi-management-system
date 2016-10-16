using System;
using MaterialSkin.Controls;

namespace Taxi_management_system.Update_forms
{
    public partial class ChangeCarStateForm : MaterialForm
    {
        public ChangeCarStateForm()
        {
            InitializeComponent();
            oldCarStateTextBox.Text = MainForm.Instance.carsListView.SelectedItems[0].SubItems[4].Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int carId = Convert.ToInt32(MainForm.Instance.carsListView.SelectedItems[0].SubItems[0].Text);
            string newState = newCarStateTextBox.Text;

            MainForm.UnitOfWork.CarRepository.UpdateCarState(carId, newState);
            this.Close();
        }
    }
}
