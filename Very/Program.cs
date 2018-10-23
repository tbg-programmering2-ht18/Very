using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banken
{
    class Program
    {
        static List<customer> customerList = new List<customer>();

        static void Main(string[] args)
        {

            Console.WriteLine("Vällkommen till banken!");
            Console.WriteLine("");
            Console.WriteLine("Ange vilket av följande alternativ önskar du göra.");
            Console.WriteLine("");
            Console.WriteLine("1. Lägg till användare");
            Console.WriteLine("2. Ta bort användare");
            Console.WriteLine("3. Visa alla befintiliga användare");
            Console.WriteLine("4. Visa saldo för en användare");
            Console.WriteLine("5. Gör en insättning för en användare");
            Console.WriteLine("6. Gör ett uttag för en användare");
            Console.WriteLine("7. Avsluta programmet");
            Console.WriteLine("");
            Console.WriteLine("Skriv ditt val: ");

            try
            {
                int val = int.Parse(Console.ReadLine());
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message)
            }

            while (val != 7)
            {

                switch (val)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        RemoveCustomer();
                        break;
                    case 3:
                        foreach (customer info in customerList)
                        {
                            Console.WriteLine(info.CustomerInfo());
                        }

                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;
                    case 5:
                        Console.WriteLine("Case 5");
                        break;
                    case 6:
                        Console.WriteLine("Case 6");
                        break;
                    case 7:
                        Console.WriteLine("Case 7");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                Console.WriteLine("Skriv ditt val: ");
                val = int.Parse(Console.ReadLine());

            }

        }

        public static void AddCustomer() //Lägger till en Customer i listan
        {
            Console.WriteLine("write the name of the customer: ");
            string newCustomer = Console.ReadLine();
            customer customer = new customer();
            customer.Namn = newCustomer;
            customerList.Add(customer);

        }

        public static void RemoveCustomer() //Tar bort en Customer från listan
        {
            Console.WriteLine("write the name of the customer: ");
            string customertodelete = Console.ReadLine();
            customer objecttodelete = null;
            foreach (customer info in customerList)
            {
                if (info.Namn == customertodelete)
                    objecttodelete = info;
                Console.WriteLine(info.CustomerInfo());

            }
            customerList.Remove(objecttodelete);
        }
        public static void ShowCustomerBalance() //Visar hur mycket pengar personen har.
        {
            Console.WriteLine("write the name of the customer: ");
            string customertodelete = Console.ReadLine();
            customer objecttodelete = null;
            foreach (customer info in customerList)
            {
                if (info.Namn == customertodelete)
                    objecttodelete = info;
                Console.WriteLine(info.CustomerInfo());

            }
            customerList.Remove(objecttodelete);
        }



    }
}









