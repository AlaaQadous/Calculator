class Calculator
{
    static void Main()
    {

        Double x, y, result = 0;

        char operation;

        Console.WriteLine("Enter the first number");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, *, /):");
        operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = x + y;
                Console.WriteLine("The result is  " + result);
                break;

            case '-':
                result = x - y;
                Console.WriteLine("The result is " + result);
                break;

            case '*':
                result = x * y;
                Console.WriteLine("The result is " + result);
                break;

            case '/':
                if (y == 0)
                {
                    Console.WriteLine("Cannot be divided by zero");
                    break;
                }
                else
                {
                    result = x / y;
                    Console.WriteLine("The result is " + result);
                    break;
                }
            default:
                Console.WriteLine("Somthing Error");
                break;


        }
    }
}