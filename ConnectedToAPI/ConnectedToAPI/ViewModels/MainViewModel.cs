using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConnectedToAPI.Models;
using ConnectedToAPI.Services;
using Xamarin.Forms;

namespace ConnectedToAPI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Employee> _employeeList;
        private Employee _selectEmployee = new Employee();

        public List<Employee> EmployeesList
        {
            get
            {
                return _employeeList;
            }

            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }

        public Employee SelectEmployee
        {
            get { return _selectEmployee; }
            set
            {
                _selectEmployee = value;
                OnPropertyChanged();
            }
        }

        public Command PostCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var employysServices = new EmployeeServices();
                    await employysServices.PostEmployeeAsync(_selectEmployee);

                });
            }
        }

        public MainViewModel()
        {
            InitializDataAsync();
            //var employysServices = new EmployeeServices();
            //EmployeesList =  employysServices.GetEmployeesAsync();
        }

        private async Task InitializDataAsync()
        {
            var employysServices = new EmployeeServices();
            EmployeesList = await employysServices.GetEmployeesAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
