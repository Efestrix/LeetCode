namespace CSES_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Repetitions

            string characters = Console.ReadLine();

            int A = 0, C = 0, G = 0, T = 0;

            foreach (char character in characters)
            {
                switch (character)
                {
                    case 'A':
                        A++;
                        break;
                    case 'C':
                        C++;
                        break;
                    case 'G':
                        G++;
                        break;
                    case 'T':
                        T++;
                        break;
                }
            }
            Console.WriteLine(Math.Max(Math.Max(A, C), Math.Max(G, T)));
        }
    }
}
