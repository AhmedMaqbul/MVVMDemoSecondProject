using MVVMDemoSecondProject.Model;
using MVVMDemoSecondProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemoSecondProject.Commands
{
    public class SaveCommand : BaseCommand
    {
        private readonly IMessageService _messageService;
        public SaveCommand(IMessageService messageService) 
        {
            _messageService= messageService;
        }

        public override bool CanExecute(object parameter)
        {
            if (parameter is Employee emp)
            {
                return emp.IsValid();
            }
          
            return true;
        }

        public override void Execute(object parameter)
        {
            if (parameter is Employee emp)
            {
                emp.Save();
                _messageService.DisplayMessageBox("Employee Saved Successfully");
            }
        }

    }
}
