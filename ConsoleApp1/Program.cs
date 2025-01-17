namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Press a number");

            string userInput = Console.ReadLine();
            int userNumber;

            try
            {
                int isItNumeric = int.Parse(userInput);
                userNumber = isItNumeric;

            }
            catch (Exception ex) 
            { 
                userNumber = 0;
            }

            Console.WriteLine($"The input number is: {userNumber}");

        }
    }
}
