namespace LogicProgrammingProblems
{
    public class PrimeNo
    {
        public static void CheckPrimeNumber()
        {
            int factors = 1;
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for( int i = 2; i<=num; i++ )
            {
                if (num % i == 0)
                {
                    factors ++; 
                }
        
            }
            if ( factors == 2 ) {

                Console.WriteLine($"{num} is a prime no");

            }
            else
            {
                Console.WriteLine("Not a prime No.");
            }
        }

    }
}
