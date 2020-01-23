using System;

namespace CashRegister
{
    internal class GUI
    {
        //scan product and record the product number and price.
        public static void EnterTransactionLine(IAction action, ref int productNumber)
        {
            do
            {
                Console.WriteLine();
                scanProduct(out double price, out int number);
                Console.WriteLine();
                Console.Write("Enter Transaction Type, 'A' for add 'D' for delete, 'C' for cancel: ");
                action = actionFactory(Console.ReadKey());
                action.ApplyAction(price, number, ref productNumber);
                Console.WriteLine();
                Console.Write("Whether to end scanning, 'Y' or 'N' ? ");
            } while (Console.ReadKey().Key == ConsoleKey.N);
        }

        public static void ShowMenu(string menu)
        {
            Console.Write(menu);
        }

        //show the transaction info.
        public static void ShowTransactionLine(int productNumber, double transactionTotal)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Product Number: {productNumber}");
            Console.WriteLine($"Transaction Total: {transactionTotal}");
            Console.WriteLine("----------------------------");
        }

        // do scanning product.
        private static void scanProduct(out double price, out int number)
        {
            Console.Write("Enter Product Price: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Enter Product Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write($"Product Amount: {price * number}");
            Console.WriteLine();
        }

        // transaction factory.
        private static IAction actionFactory(ConsoleKeyInfo consoleKeyInfo)
        {
            IAction action = null;
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.A:
                    action = new AddTransactionLine();
                    break;

                case ConsoleKey.D:
                    action = new DeleteTransactionLine();
                    break;

                case ConsoleKey.C:
                    action = new CancelTransactionLine();
                    break;
            }
            return action;
        }
    }
}