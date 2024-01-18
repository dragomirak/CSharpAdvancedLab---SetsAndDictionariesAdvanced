namespace P02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> gradesMap = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentsData = Console.ReadLine().Split(" ");
                string studentName = studentsData[0];
                decimal studentGrade = decimal.Parse(studentsData[1]);

                if (!gradesMap.ContainsKey(studentName))
                {
                    gradesMap[studentName] = new List<decimal>();
                }

                gradesMap[studentName].Add(studentGrade);

            }

            foreach (var grade in gradesMap)
            {
                Console.Write($"{grade.Key} -> {string.Join(" ", grade.Value.Select(g => g.ToString("f2")))} (avg: {grade.Value.Average():f2})");
                Console.WriteLine();
            }

        }
    }
}