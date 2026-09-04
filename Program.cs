using CarsMarket.Models;

namespace CarsMarket
{

    class Program
    {
        public static List<Car> CarList = new List<Car>();
        static void Main(string[] args)
        {

        string? opt;

            Console.WriteLine("Welcome,This is CarMarket\n");
            while (true) { 
            Console.WriteLine("Select option");
            Console.WriteLine("1. Car List");
            Console.WriteLine("2. Add Car");
            Console.WriteLine("3. Delete Car");
            Console.WriteLine("4. Edit Car");
            Console.WriteLine("5. Close Program");

            opt = Console.ReadLine();

                switch (opt)
                {
                    case "1": //showing car list

                        foreach (var car in CarList)
                        {
                            Console.WriteLine("-------------------");
                            Console.WriteLine($"Name: {car.Name}");
                            Console.WriteLine($"Year: {car.Year}");
                            Console.WriteLine($"Price: {car.Price}");
                            Console.WriteLine($"Id: {car.Id}");
                            Console.WriteLine("-------------------");
                        }


                        break;

                    case "2":  //adding car

                        Console.Write("Write Car Name:");
                        string? CarName = Console.ReadLine();

                        Console.Write("Write Car Year:");
                        string? CarYear = Console.ReadLine();

                        Console.Write("Write Car Price:");
                        string? CarPrice = Console.ReadLine();

                        Car NewCar = new Car();

                        NewCar.Name = CarName;
                        NewCar.Year = Convert.ToInt32(CarYear);
                        NewCar.Price = Convert.ToDecimal(CarPrice);
                        NewCar.Id = CarList.Count;

                        CarList.Add(NewCar);

                        Console.WriteLine("Car Added\n");

                        break;

                    case "3": // delete car
                        Console.Write("Write car id to delete:");
                        int CarId = Convert.ToInt32(Console.ReadLine());


                        for (int i = 0; i < CarList.Count; i++)
                        {
                            if (CarList[i].Id == CarId)
                            {
                                CarList.RemoveAt(i);
                                break;
                            }
                        }

                        Console.WriteLine("Car Deleted\n");

                        break;

                    case "4": // edit car

                        Console.Write("Write car id to edit: ");

                        int CarEditId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Write new car name:");

                        string? CarNewName = Console.ReadLine();

                        Console.Write("Write new car year: ");

                        int CarNewYear = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Write new car price: ");

                        decimal CarNewPrice = Convert.ToDecimal(Console.ReadLine());

                        for (int i = 0; i < CarList.Count; i++)
                        {
                            if (CarList[i].Id == CarEditId)
                            {
                                CarList[i].Name = CarNewName;
                                CarList[i].Year = CarNewYear;
                                CarList[i].Price = CarNewPrice;

                                Console.WriteLine("Edited Car");
                                break;
                            }
                        }

                        Console.WriteLine("Couldn't edit Car");

                        break;

                    case "5": // exit program
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}