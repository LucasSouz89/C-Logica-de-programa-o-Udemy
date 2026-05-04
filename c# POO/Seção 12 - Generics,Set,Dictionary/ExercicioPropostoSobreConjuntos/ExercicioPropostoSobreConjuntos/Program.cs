namespace ExercicioPropostoSobreConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();
            Course("A",students);
            Course("B", students);
            Course("C", students);
            Console.WriteLine($"Total students: {students.Count}"); 
        }
        public static void Course(string letter,HashSet<int> set)
        {
            Console.Write($"How many students for course {letter}?");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
