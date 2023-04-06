namespace Task2
{
    internal class Program
    {
        static int NumberDigit(int number)
        {
            int countt = 0;
            while (number>0)
            {
                number = number / 10;
                countt++;
            }
            return countt;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the your number:");
            int.TryParse(Console.ReadLine(), out int number);
            int number1=NumberDigit(number);
            Console.WriteLine($"The entered number is {number1} digits");

        }
    }
}