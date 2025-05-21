using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            string[] allowedOperation = { "+", "-", "*", "/" };

            Console.WriteLine("== CALCULADORA BÁSICA ==");
            Console.WriteLine("Digite uma operação!");
            Console.WriteLine("adição          +");
            Console.WriteLine("subtração       -");
            Console.WriteLine("multiplicação   *");
            Console.WriteLine("divisão         /");
            Console.Write(">>> ");

            var operation = Console.ReadLine() ?? "";

            if (!IsValidOperation(allowedOperation, operation))
                break;

            Console.Write("\nDigite o primeiro número: ");

            string input = Console.ReadLine() ?? "".Replace('.', ',');
            double firstNumber = IsValidNumber(input);

            Console.Write("\nDigite o segundo número: ");

            input = Console.ReadLine() ?? "".Replace('.', ',');
            double secondNumber = IsValidNumber(input);

            var result = Calculate(firstNumber, secondNumber, operation);

            Console.WriteLine($"\nResultado: {firstNumber} {operation} {secondNumber} = {result}");

            Console.Write("\nDeseja realizar mais alguma conta? Se sim digite 's' ");
            input = Console.ReadLine() ?? "";
            

            if (input.ToLower()!= "s")
                break;
        }
    }

    private static bool IsValidOperation(string[] listOfOperations , string operation)
    {
        if (Array.IndexOf(listOfOperations, operation) < 0)
        {
            Console.WriteLine("Operação inválida, reinicie o programa");
            return false;
        }

        return true;
    }

    private static double IsValidNumber(string input)
    {
        if (!double.TryParse(input, out double convertedNumber))
        {
            Console.WriteLine("Número inválido. Encerrando.");
            Environment.Exit(0);
        }

        return convertedNumber;
    }

    private static double Calculate(double a,  double b,  string operation)
    {
        var operationTypes = new Dictionary<string, Func<double, double, double>>()
        {
            {"+", (x, y) => x + y },
            {"-", (x, y) => x - y },
            {"*", (x, y) => x * y },
            {"/", (x, y) => x / y }
        };

        
        if(operationTypes.TryGetValue(operation, out var func))
        {
            var result = func(a, b);
            return result;
        }

        return 0;
    }
}
