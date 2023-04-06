namespace Method
{
    internal class Program
    {     

        static bool CheckNumber(int number )
        {
            if (number>0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the your number: ");
            int.TryParse(Console.ReadLine(), out int number);
            bool check = CheckNumber(number);
            if (check==true)
            {
                Console.WriteLine("Your number is positive!");
            }
            else
            {
                Console.WriteLine("Your number is negative!");
            }
        }
    }
}