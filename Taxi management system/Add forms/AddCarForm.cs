using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities.Concrete;
using MaterialSkin.Controls;

namespace Taxi_management_system.Add_forms
{
    public partial class AddCarForm : MaterialForm
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        public AddCarForm()
        {
            InitializeComponent();
            this.mileageTextBox.Validating += new CancelEventHandler(this.mileageTextBox_Validating);
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var car = new Car
                {
                    LicensePlate = licensePlateTextBox.Text,
                    Model = modelTextBox.Text,
                    Mileage = Convert.ToInt32(mileageTextBox.Text),
                    State = stateTextBox.Text
                };

                MainForm.UnitOfWork.CarRepository.Insert(car);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Check the correction of input data (the lisence plate has format like '[A-C][A-Z] [0-9][0-9][0-9][0-9] [A-Z][A-Z])",
                               "Register car error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MainForm.Instance.UpdateListOfCars();
            this.Close();
        }

        public void mileageTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int mileage = Int32.Parse(mileageTextBox.Text);

                if (mileage <= 0 || mileage > 1000000)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(mileageTextBox, "");
            }
            catch (Exception)
            {
                _errorProvider.SetError(mileageTextBox, "Incorrect value for mileage");
            }
        }
    }
}
