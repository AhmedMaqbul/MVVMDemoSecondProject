using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemoSecondProject.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; } = "Hyd";

        public bool IsFirst { get; set; }

        public DateTime DateOfJoining { get; set; }=DateTime.Now;

        public void Save()
        {
            string employeeRecord = $"\r\n{FirstName}, {LastName}, {City}, {IsFirst}, {DateOfJoining}";
            File.AppendAllText("EmoployeeData.txt", employeeRecord);
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(FirstName))
                return false;
            if (string.IsNullOrEmpty(LastName))
                return false;
            if (IsFirst == false)
                return false;

            return true;
        }
    }
}
