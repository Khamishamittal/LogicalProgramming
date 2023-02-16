namespace LogicProgrammingProblems
{
    public class PerfectNumber
    {
        public static void FindPerfectNumber()
        {
            Console.WriteLine("Enter min range: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter max range: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int n, i, sum;

            Console.WriteLine("The perfect numbers within the given range are: ");
            for (n = min; n < max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                    i++;
                }
                if (sum == n)
                {
                    Console.Write(n + " ");
                }

            }
        }
    }
}

    

