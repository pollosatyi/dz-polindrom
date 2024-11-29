namespace dz_polindrom
{
    internal class Program
    {
        public static bool IsPolindrom(int number)
        {
            int duble = number;
            int reverseNumber = 0;
            while (duble > 0)
            {
                reverseNumber = reverseNumber * 10 + duble % 10;
                duble = duble / 10;

            }
            return reverseNumber == number;
        }

        public static void PrintMessage(bool isPolindrom)
        {
            Console.WriteLine(isPolindrom ? "Число палиндром" : "Число не палиндром");
        }

        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                PrintMessage(IsPolindrom(number));
            }
            else
            {
                Console.WriteLine("Неверный ввод числа");
            }
        }
    }
}
