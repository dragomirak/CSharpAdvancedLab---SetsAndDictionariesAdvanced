namespace P08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            string inputData;
            while ((inputData = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(inputData[0]))
                {
                    vipGuests.Remove(inputData);
                }
                else
                {
                    regularGuests.Remove(inputData);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach(var regGuest in regularGuests)
            {
                Console.WriteLine(regGuest);
            }
        }
    }
}