using PI_Zadaca.Model;
using PI_Zadaca.Test;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        Station terminalSmallTrain = new Station();
        Station terminalLargeTrain = new Station();

        Employee employeeSmallTrain = new Employee("Mateo","IVankovic", 0.1);
        Employee employeeLargeTrain = new Employee("Zdravko","Mamic", 0.11);


        Vehichle bus = new Vehichle(VehichleType.Bus, 80, 30);
        Vehichle van = new Vehichle(VehichleType.Car, 20, 50);
        Vehichle truck = new Vehichle(VehichleType.Truck, 5, 30);
        Vehichle car = new Vehichle(VehichleType.Car, 12, 5);

        terminalLargeTrain.LoadVehichleToTrain(bus, employeeLargeTrain);
        terminalLargeTrain.LoadVehichleToTrain(truck, employeeLargeTrain);




        terminalSmallTrain.LoadVehichleToTrain(car, employeeSmallTrain);
        terminalSmallTrain.LoadVehichleToTrain(van, employeeSmallTrain);

        terminalSmallTrain.GetTotalMoneyMade();
        terminalLargeTrain.GetTotalMoneyMade();

        Console.WriteLine();

        employeeSmallTrain.GetEmployeeMoneyMade();
        employeeLargeTrain.GetEmployeeMoneyMade();

        Console.WriteLine();

        UnitTest test = new UnitTest();
        test.TestTrain();
    }
}
