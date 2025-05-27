using System;

namespace BugetingApp
{
    class Program
    {
        static int income = 0; // Initialize income variable to store total income
        static int expenses = 0; // Initialize expenses variable to store total expenses
        static List<string> transactions = new List<string>(); // Initialize a list to store transactions
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nWhat would you like to do today?");
                Console.WriteLine("1. Add Income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. View Transactions");
                Console.WriteLine("5. Exit");

                int options = int.Parse(Console.ReadLine());


                switch (options)
                {
                    case 1:
                        AddIncome();
                        break;
                    case 2:
                        AddExpense();
                        break;
                    case 3:
                        ViewBalance();
                        break;
                    case 4:
                        ViewTransactions();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
        public static void AddIncome()
        {
            bool addmore = true;

            while (addmore)
            {

                Console.WriteLine("How much would you like to add?");
                int add = int.Parse(Console.ReadLine());
                transactions.Add($"Added income: {add}"); // Store the transaction in the list

                income += add;

                Console.WriteLine("You now have " + income);
                Console.WriteLine("Do you want to add any more funds! (y/n)");
                string yn = " ";

                while (yn != "y" && yn != "n")
                {

                    yn = Console.ReadLine().ToLower();

                    if (yn != "y" && yn != "n")
                    {
                        Console.WriteLine("Please enter Only 'y' for yes or 'n' for no.");
                    }

                }

                if (yn == "n")
                {
                    addmore = false;
                }
            }
            Console.WriteLine("Final income: " + income); // Print the final total after exiting the loop 
        }

        public static void AddExpense()
        {

            bool addExpense = true;
            while (addExpense)
            {
                Console.WriteLine("Please enter the amount you would like to add as an expense:");
                int subtractExpense = int.Parse(Console.ReadLine());
                transactions.Add($"Added expense: -{subtractExpense}"); // Store the transaction in the list
                expenses += subtractExpense;

                Console.WriteLine($"You have added {expenses} as an expense. Your total expenses are now {expenses}.");

                Console.WriteLine("Do you want to add another expense? (y/n)");
                string yn = " ";
                while (yn != "y" && yn != "n")
                {
                    yn = Console.ReadLine().ToLower();

                    if (yn != "y" && yn != "n")
                    {
                        Console.WriteLine("Please enter Only 'y' for yes or 'n' for no.");
                    }
                }
                if (yn == "n")
                {
                    addExpense = false;
                }

                Console.WriteLine("Final expenses: " + expenses); // Print the final total after exiting the loop
            }
        }
        public static void ViewBalance()
        {

            Console.WriteLine($"your current balance is {income}"); // Placeholder for balance, as no income or expenses are tracked yet
            Console.WriteLine($"your current Expenses is {expenses}"); // Placeholder for balance, as no income or expenses are tracked yet
            int balance = income - expenses; // Calculate the balance
            Console.WriteLine($"Your current balance is {balance}"); // Print the balance
            if (balance < 0)
            {
                Console.WriteLine("You are in debt!");
            }
            else if (balance == 0)
            {
                Console.WriteLine("You have no balance left.");
            }
            else
            {
                Console.WriteLine("You are in profit!");
            }

        }
        public static void ViewTransactions()
        {

            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions recorded yet.");
            }
            else
            {
                Console.WriteLine("Transactions:");

                foreach (var transaction in transactions)
                {
                    Console.WriteLine(transaction);
                }
            }
        }
    }
}
