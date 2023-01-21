using NUnit.Framework;
using PI_Zadaca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Zadaca.Test
{
    internal class UnitTest
    {
    [Test]
       public void TestTrain()
        {
            Train small=new Train(TrainSize.Small);
            

            Train big_train=new Train(TrainSize.Big);
            
            

            Assert.AreEqual(small.Size, TrainSize.Small);
            Console.WriteLine("test 1 successful");

            Assert.AreEqual(small.Size.GetValue(), 6);
            Console.WriteLine("test 2 successful");

            Assert.AreEqual(big_train.Size,TrainSize.Big);
            Console.WriteLine("test 3 successful");


            Assert.AreEqual(big_train.Size.GetValue(), 8);
            Console.WriteLine("test 4 successful");

            



        }
    }
}
