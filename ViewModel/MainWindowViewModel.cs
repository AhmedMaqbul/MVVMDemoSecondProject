using MVVMDemoSecondProject.Commands;
using MVVMDemoSecondProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMDemoSecondProject.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            cities.Add("Hyd");
            cities.Add("Kol");
            cities.Add("Del");
            cities.Add("Mum");

            saveCommand = new SaveCommand(new Services.MessageService());
        }

        private Employee employee = new Employee();
        public Employee Employee { get => employee; set => employee = value; }

        private ObservableCollection<string> cities = new ObservableCollection<string>();

        public ObservableCollection<string> Cities
        {
            get => cities;
            set => cities = value;
        }

        private ICommand saveCommand;

        public ICommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }


    }
}
