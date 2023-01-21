using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.Model
{
    internal class Station
    {
        private Train small_train=new Train(TrainSize.Small);
        private Train big_train=new Train(TrainSize.Big);
        private int ticketEarnings = 0;

      
        public void LoadVehichleToTrain(Vehichle vehichle,Employee employee)
        {
            if (VehichleIsSmall(vehichle))
            {
                employee.CheckStatusOfVehichle(vehichle, small_train);
            }
            else
            {
                employee.CheckStatusOfVehichle(vehichle, big_train);
            }
            ticketEarnings += vehichle.Type.GetValue();

        }

      

        private static bool VehichleIsSmall(Vehichle vehichle)
        {
            return vehichle.Type == VehichleType.Car || vehichle.Type == VehichleType.Van;
        }
        public void GetTotalMoneyMade() => Console.WriteLine("Total money Made from this Station:"+ticketEarnings);
    }

}
