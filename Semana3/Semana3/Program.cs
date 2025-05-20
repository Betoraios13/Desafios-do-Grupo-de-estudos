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

            string input = Console.ReadLine() ?? "";
            var firstNumber = IsValidNumber(input);
            //double firstNumber;

            if (firstNumber == null)
                break;

            Console.Write("\nDigite o segundo número: ");

            input = Console.ReadLine() ?? "";
            var secondNumber = IsValidNumber(input);
            //double secondNumber;

            if (secondNumber == null)
                break;

            // ← AQUI VOCÊ INSERE o switch-case e completa a lógica
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"\nResultado: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "-":
                    Console.WriteLine($"\nResultado: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "*":
                    Console.WriteLine($"\nResultado: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    //result++
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("\nErro: divisão por zero não é permitida.Encerrando.");
                        return;
                    }

                    Console.WriteLine($"\nResultado: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
            }
            //Corrigir a saída
            //Console.WriteLine($"\nResultado: {firstNumber} {operation} {secondNumber} = {result}");


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

    private static double? IsValidNumber(string input)
    {
        if (!double.TryParse(input, out double convertedNumber))
        {
            Console.WriteLine("Número inválido. Encerrando.");
            return null;
        }

        return convertedNumber;
    }
}
