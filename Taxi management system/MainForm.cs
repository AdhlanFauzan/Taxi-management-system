using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL.Concrete.UnitOfWork;
using Entities.Concrete;
using MaterialSkin.Controls;
using Taxi_management_system.Add_forms;
using Taxi_management_system.Select_forms;
using Taxi_management_system.Update_forms;

namespace Taxi_management_system
{
    public partial class MainForm : MaterialForm
    {
        private MainForm()
        {
            InitializeComponent();
            CreateEmployeesListView();
            CreateCallsListView();
            CreateCarsListView();
        }

        #region CreateListViews

        private void CreateEmployeesListView()
        {
            employeesListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            employeesListView.Columns.Add("CarId", -2, HorizontalAlignment.Left);
            employeesListView.Columns.Add("First name", -2, HorizontalAlignment.Left);
            employeesListView.Columns.Add("Last name", -2, HorizontalAlignment.Left);
            employeesListView.Columns.Add("Age", -2, HorizontalAlignment.Left);
            employeesListView.Columns.Add("Gender", -2, HorizontalAlignment.Left);

            UpdateListOfEmployees();
        }

        private void CreateCallsListView()
        {
            callsListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("CarId", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("Departure place", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("Arrival place", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("Distance", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("Price", -2, HorizontalAlignment.Left);
            callsListView.Columns.Add("Date", -2, HorizontalAlignment.Left);

            UpdateListOfCalls();
        }

        private void CreateCarsListView()
        {
            carsListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            carsListView.Columns.Add("LicensePlate", -2, HorizontalAlignment.Left);
            carsListView.Columns.Add("Model", -2, HorizontalAlignment.Left);
            carsListView.Columns.Add("Mileage", -2, HorizontalAlignment.Left);
            carsListView.Columns.Add("State", -2, HorizontalAlignment.Left);

            UpdateListOfCars();
        }

        #endregion

        #region UpdateEntityLists

        public void UpdateListOfCars()
        {
            carsListView.Items.Clear();
            ListOfCars = UnitOfWork.CarRepository.GetAll();

            var items = new ListViewItem[ListOfCars.Count()];
            int i = 0;
            foreach (var car in ListOfCars)
            {
                var item = new ListViewItem(car.Id.ToString());

                item.SubItems.Add(car.LicensePlate);
                item.SubItems.Add(car.Model);
                item.SubItems.Add(car.Mileage.ToString());
                item.SubItems.Add(car.State);

                items[i] = item;
                i++;
            }

            carsListView.Items.AddRange(items);
        }

        public void UpdateListOfCalls()
        {
            callsListView.Items.Clear();
            ListOfCalls = UnitOfWork.CallRepository.GetAll();

            var items = new ListViewItem[ListOfCalls.Count()];
            int i = 0;
            foreach (var call in ListOfCalls)
            {
                var item = new ListViewItem(call.Id.ToString());

                item.SubItems.Add(call.CarId.ToString());
                item.SubItems.Add(call.DeparturePlace);
                item.SubItems.Add(call.ArrivalPlace);
                item.SubItems.Add(call.Distance.ToString());
                item.SubItems.Add(call.Price.ToString(CultureInfo.InvariantCulture));
                item.SubItems.Add(call.Date);

                items[i] = item;
                i++;
            }

            callsListView.Items.AddRange(items);
        }

        public void UpdateListOfEmployees()
        {
            employeesListView.Items.Clear();
            ListOfEmployees = UnitOfWork.EmployeeRepository.GetAll();

            var items = new ListViewItem[ListOfEmployees.Count()];
            int i = 0;
            foreach (var employee in ListOfEmployees)
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

            employeesListView.Items.AddRange(items);
        }

        #endregion

        #region AddEntities

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void addCallButton_Click(object sender, EventArgs e)
        {
            var addCallForm = new AddCallForm();
            addCallForm.ShowDialog();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }

        #endregion

        #region RemoveEntities

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesListView.SelectedItems.Count == 0)
                return;

            int id = Convert.ToInt32(employeesListView.SelectedItems[0].SubItems[0].Text);
            UnitOfWork.EmployeeRepository.Delete(id);

            UpdateListOfEmployees();
        }

        private void removeCallButton_Click(object sender, EventArgs e)
        {
            if (callsListView.SelectedItems.Count == 0)
                return;

            int id = Convert.ToInt32(callsListView.SelectedItems[0].SubItems[0].Text);
            UnitOfWork.CallRepository.Delete(id);

            UpdateListOfCalls();
        }

        private void removeCarButton_Click(object sender, EventArgs e)
        {
            {
                if (carsListView.SelectedItems.Count == 0)
                    return;

                int id = Convert.ToInt32(carsListView.SelectedItems[0].SubItems[0].Text);

                foreach (var employee in ListOfEmployees)
                {
                    if (employee.CarId == id)
                    {
                        MessageBox.Show(this, "This car has driver(-s) therefore it can't be removed", "Remove car Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                UnitOfWork.CarRepository.Delete(id);
                UpdateListOfCars();
            }
        }

        #endregion

        #region UpdateEntities

        private void changeCarButton_Click(object sender, EventArgs e)
        {
            if (employeesListView.SelectedItems.Count == 0)
                return;

            var changeCarForEmployeeForm = new ChangeCarForEmployeeForm();
            changeCarForEmployeeForm.ShowDialog();

            UpdateListOfEmployees();
        }

        private void changeCarStateButton_Click(object sender, EventArgs e)
        {
            if (carsListView.SelectedItems.Count == 0)
                return;

            var changeCarStateForm = new ChangeCarStateForm();
            changeCarStateForm.ShowDialog();

            UpdateListOfCars();
        }

        #endregion

        #region Selectors

        private void getCallsByCarIdButton_Click(object sender, EventArgs e)
        {
            var getCallsByCarIdForm = new GetCallsByCarIdForm();
            getCallsByCarIdForm.ShowDialog();
        }

        private void getEmployeesByCarIdButton_Click(object sender, EventArgs e)
        {
            var getEmployeesByCarIdForm = new GetEmployeesByCarIdForm();
            getEmployeesByCarIdForm.ShowDialog();
        }

        private void dayInfoButton_Click(object sender, EventArgs e)
        {
            var monetaryDayInfoForm = new MonetaryDayInfoForm();
            monetaryDayInfoForm.ShowDialog();
        }

        #endregion

        #region Fields and properties

        public static readonly UnitOfWork UnitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);

        public IEnumerable<Employee> ListOfEmployees { get; private set; }

        public IEnumerable<Car> ListOfCars { get; private set; }

        public IEnumerable<Call> ListOfCalls { get; private set; }

        public static MainForm Instance => _instance ?? (_instance = new MainForm());

        private static MainForm _instance;


        #endregion
    }
}
