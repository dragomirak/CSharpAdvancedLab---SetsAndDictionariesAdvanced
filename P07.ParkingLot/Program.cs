namespace P07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ");
                string command = tokens[0];
                string carNumber = tokens[1];

                if (command == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    if (cars.Contains(carNumber))
                    {
                        cars.Remove(carNumber);
                    }
                }

            }

            if (cars.Count > 0)
            {
                foreach(var carNumber in cars)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}