namespace P01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            Dictionary<double, int> numbersMap = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersMap.ContainsKey(number))
                {
                    numbersMap[number] = 0;
                }

                numbersMap[number]++;
            }

            foreach (var number in numbersMap)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}