using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities.Concrete;
using MaterialSkin.Controls;

namespace Taxi_management_system.Add_forms
{
    public partial class AddCallForm : MaterialForm
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        public AddCallForm()
        {
            InitializeComponent();

            this.carIdTextBox.Validating += new CancelEventHandler(this.carIdTextBox_Validating);
            this.distanceTextBox.Validating += new CancelEventHandler(this.distanceTextBox_Validating);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var call = new Call
                {
                    CarId = Convert.ToInt32(carIdTextBox.Text),
                    DeparturePlace = departurePlaceTextBox.Text,
                    ArrivalPlace = arrivalPlaceTextBox.Text,
                    Distance = Convert.ToInt32(distanceTextBox.Text),
                };

                MainForm.UnitOfWork.CallRepository.Insert(call);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Check the correction of input data", "Register call error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            MainForm.Instance.UpdateListOfCalls();
            MainForm.Instance.UpdateListOfCars();
            this.Close();
        }

        #region Validating methods

        public void carIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (carIdTextBox.TextLength != 4)
                    throw new Exception();

                int carId = Int32.Parse(carIdTextBox.Text);
                bool flag = false;
                foreach (var car in MainForm.Instance.ListOfCars)
                {
                    if (car.Id == carId)
                        flag = true;
                }

                if (!flag)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(carIdTextBox, "");
            }
            catch (ArgumentOutOfRangeException)
            {
                _errorProvider.SetError(carIdTextBox, "Car with current id doesn't exist");
            }
            catch (Exception)
            {
                _errorProvider.SetError(carIdTextBox, "Incorrect value (carId consists of 4 numbers)");
            }
        }

        public void distanceTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int distance = Int32.Parse(distanceTextBox.Text);

                if (distance <= 0 || distance > 1000)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(distanceTextBox, "");
            }
            catch (Exception)
            {
                _errorProvider.SetError(distanceTextBox, "Incorrect value for distance");
            }
        }

        #endregion
    }
}
