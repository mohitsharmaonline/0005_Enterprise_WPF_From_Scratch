
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name="Washington", Title = "President 1"});
            employees.Add(new Employee() { Name = "Adams", Title = "President 2" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "President 3" });
            employees.Add(new Employee() { Name = "Madison", Title = "President 4" });
            employees.Add(new Employee() { Name = "Monroe", Title = "President 5" });

            return employees;
        }

        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(caller));
        }
    }
}
