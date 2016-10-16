using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities.Concrete;
using MaterialSkin.Controls;

namespace Taxi_management_system.Add_forms
{
    public partial class AddEmployeeForm : MaterialForm
    {
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        public AddEmployeeForm()
        {
            InitializeComponent();

            carIdTextBox.Validating += new CancelEventHandler(this.carIdTextBox_Validating);
            ageTextBox.Validating += new CancelEventHandler(this.ageTextBox_Validating);
            firstNameTextBox.Validating += new CancelEventHandler(this.firstNameTextBox_Validating);
            lastNameTextBox.Validating += new CancelEventHandler(this.lastNameTextBox_Validating);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee
                {
                    CarId = Convert.ToInt32(carIdTextBox.Text),
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Age = Convert.ToInt32(ageTextBox.Text),
                    Gender = Convert.ToChar(genderTextBox.Text.ToUpper())
                };

                MainForm.UnitOfWork.EmployeeRepository.Insert(employee);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Check the correction of input data (set gender 'M' or 'F')", "Register employee error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm.Instance.UpdateListOfEmployees();
            this.Close();
        }

        #region Validating methods

        public void ageTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int age = Int32.Parse(ageTextBox.Text);

                if (age < 18 || age > 75)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(ageTextBox, "");
            }
            catch (Exception)
            {
                _errorProvider.SetError(ageTextBox, "Incorrect value for age");
            }
        }

        public void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string firstName = firstNameTextBox.Text;

                if (firstName == String.Empty)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(firstNameTextBox, "");
            }
            catch (Exception)
            {
                _errorProvider.SetError(firstNameTextBox, "First name can't be empty");
            }
        }

        public void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string lastName = lastNameTextBox.Text;

                if (lastName == String.Empty)
                    throw new ArgumentOutOfRangeException();

                _errorProvider.SetError(lastNameTextBox, "");
            }
            catch (Exception)
            {
                _errorProvider.SetError(lastNameTextBox, "Last name can't be empty");
            }
        }

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

        #endregion
    }
}
