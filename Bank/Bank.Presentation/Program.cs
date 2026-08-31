using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        System.Console.WriteLine("Welcome to the Bank Application!");
        System.Console.WriteLine("Please log in to continue.");

        string userName = "", password = "";

        // Read username 
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();
        if (userName != "")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();

        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customer");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter your choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        //CustomerMenu customerMenu = new CustomerMenu();
                        //customerMenu.ShowCustomerMenu();
                        CustomerMenu();
                        break;
                    case 2:
                        AccountMenu();
                        //AccountMenu accountMenu = new AccountMenu();
                        //accountMenu.ShowAccountMenu();
                        break;
                    case 3:
                        //FundsTransfer fundsTransfer = new FundsTransfer();
                        //fundsTransfer.ShowFundsTransferMenu();
                        break;
                    case 4:
                        //FundsTransferStatement fundsTransferStatement = new FundsTransferStatement();
                        //fundsTransferStatement.ShowFundsTransferStatementMenu();
                        break;
                    case 5:
                        //AccountStatement accountStatement = new AccountStatement();
                        //accountStatement.ShowAccountStatementMenu();
                        break;
                    case 0:
                        System.Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        System.Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid username or password.");
        }

        System.Console.WriteLine("Thank you! Visit again");
        System.Console.ReadKey();
    }

    private static void AccountMenu()
    {
        int accountMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Account Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Account");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter your choice: ");

            //accountMenuChoice = int.Parse(System.Console.ReadLine());

            accountMenuChoice = Convert.ToInt32(System.Console.ReadLine());

            switch (accountMenuChoice)
            {
                case 1:
                    //Account account = new Account();
                    //account.AddAccount();
                    break;
                case 2:
                    Account accountToDelete = new Account();
                    accountToDelete.DeleteAccount();
                    break;
                case 3:
                    Account accountToUpdate = new Account();
                    accountToUpdate.UpdateAccount();
                    break;
                case 4:
                    Account accountToView = new Account();
                    accountToView.ViewAccount();
                    break;
                case 0:
                    System.Console.WriteLine("Returning to Main Menu...");
                    break;
                default:
                    System.Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (accountMenuChoice != 0);
    }

    private static void CustomerMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Customer Menu:::");

            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customer");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter your choice: ");

            //customerMenuChoice = int.Parse(System.Console.ReadLine());

            customerMenuChoice = Convert.ToInt32(System.Console.ReadLine());

            switch (customerMenuChoice)
            {
                case 1:
                    //Customer customer = new Customer();
                    //customer.AddCustomer();
                    break;
                case 2:
                    Customer customerToDelete = new Customer();
                    customerToDelete.DeleteCustomer();
                    break;
                case 3:
                    Customer customerToUpdate = new Customer();
                    customerToUpdate.UpdateCustomer();
                    break;
                case 4:
                    Customer customerToView = new Customer();
                    customerToView.ViewCustomer();
                    break;
                case 0:
                    System.Console.WriteLine("Returning to Main Menu...");
                    break;
                default:
                    System.Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (customerMenuChoice != 0);
    }
}