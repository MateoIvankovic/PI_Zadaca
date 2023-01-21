using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PI_Zadaca.Model
{
    internal class Employee
    {
        public readonly int LOW = 10;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }


        public double Quocient { get; set; }

        public void CheckStatusOfVehichle(Vehichle vehichle, Train train)
        {


            if (train.getCapacity() > 0)
            {
                AddToSalary(vehichle.Type.GetValue());
                train.LowerCapacity();
                if (vehichle.TankSize < LOW)
                {
                    Console.WriteLine(GetFullName() + "-" + vehichle.Type.ToString() + "- gas size: " + vehichle.TankSize + "% full");
                    Console.WriteLine("Gas Refill");
                    vehichle.FillUpGas();
                    Console.WriteLine(GetFullName() + "'s " + vehichle.GetType() + " gas size is " + vehichle.TankSize + "% full");

                }
                if (vehichle.BatterySize < LOW)
                {
                    Console.WriteLine(GetFullName() + "'s " + vehichle.Type.ToString() + " battery size is " + vehichle.BatterySize + "% full");
                    Console.WriteLine("Battery is refilling...");
                    vehichle.FillUpBattery();
                    Console.WriteLine(GetFullName() + "'s " + vehichle.BatterySize.ToString() + " battery size is " + vehichle.BatterySize + "% full");

                }
            }
        }

        public Employee(string firstName, string lastName, double quocient)
        {
            FirstName = firstName;
            LastName = lastName;
            Quocient = quocient;
        }

        private void AddToSalary(double fare)
        {
            Salary += fare * Quocient;


        }
        private string GetFullName() => $"{FirstName} {LastName}";

        public void GetEmployeeMoneyMade() => Console.WriteLine(GetFullName() + " made:" + Salary);
    }
}
