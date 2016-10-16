using System;
using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Taxi_management_system.Update_forms
{
    public partial class ChangeCarForEmployeeForm : MaterialForm
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        public ChangeCarForEmployeeForm()
        {
            InitializeComponent();
            oldCarIdTextBox.Text = MainForm.Instance.employeesListView.SelectedItems[0].SubItems[1].Text;
            newCarIdTextBox.Validating += new CancelEventHandler(this.carIdTextBox_Validating);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Convert.ToInt32(MainForm.Instance.employeesListView.SelectedItems[0].SubItems[0].Text);
                int newCarId = Convert.ToInt32(newCarIdTextBox.Text);

                MainForm.UnitOfWork.EmployeeRepository.ChangeCar(employeeId, newCarId);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Check the correction of input data", "Change car for employee error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        #region Validation methods

        public void carIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (newCarIdTextBox.TextLength != 4)
                    throw new Exception();

                int carId = Int32.Parse(newCarIdTextBox.Text);
                bool flag = false;
                foreach (var car in MainForm.Instance.ListOfCars)
                {
                    if (car.Id == carId)
                        flag = true;
                }

                if (!flag)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(newCarIdTextBox, "");
            }
            catch (ArgumentOutOfRangeException)
            {
                _errorProvider.SetError(newCarIdTextBox, "Car with current id doesn't exist");
            }
            catch (Exception)
            {
                _errorProvider.SetError(newCarIdTextBox, "Incorrect value (carId consists of 4 numbers)");
            }
        }

        #endregion
    }
}
