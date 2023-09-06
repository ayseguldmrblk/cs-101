using System.Threading.Tasks.Dataflow;

namespace Project_1;

public class Contact
{
    private string name;
    private string phone;
    private string surname; // Changed from "email" to "surname"
    public Contact(string name, string surname, string phone) // Changed parameter name here
    {
        this.name = name;
        this.phone = phone;
        this.surname = surname; // Changed assignment here
    }
    public string Name { get => name; set => name = value; }
    public string Phone { get => phone; set => phone = value; }
    public string Surname { get => surname; set => surname = value; } // Changed property name here
}

class Program
{
    static void printMenu()
    {
        Console.WriteLine("Please choose the operation you want to do.");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("*       *      *         0. For exit.                  *      *         *");
        Console.WriteLine("*      *  *   *  *       1. Add a new contact         *  *   *  *       *");
        Console.WriteLine("*     *     *     *      2. Delete a contact         *     *     *      *");
        Console.WriteLine("*       *       *        3. Edit a contact             *       *        *");             
        Console.WriteLine("*         *   *          4. List all contacts            *   *          *");
        Console.WriteLine("*           *            5. Search for a contact           *            *");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
    }
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();

        Contact contact1 = new Contact("John", "Doe", "123-456-7890");
        Contact contact2 = new Contact("Alice", "Smith", "555-555-5555");
        Contact contact3 = new Contact("Bob", "Johnson", "987-654-3210");
        Contact contact4 = new Contact("Eve", "Adams", "777-777-7777");
        Contact contact5 = new Contact("Charlie", "Brown", "444-444-4444");

        contacts.Add(contact1);
        contacts.Add(contact2);
        contacts.Add(contact3);
        contacts.Add(contact4);
        contacts.Add(contact5);

        int choice = -1;
        while(choice != 0)
        {
            try
            {
                printMenu();
                Console.WriteLine("Enter your choice as a number: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the contact: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the surnmae of the contact: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter the phone number of the contact: ");
                        string phone = Console.ReadLine();
                        Contact contact = new Contact(name, surname, phone);
                        contacts.Add(contact);
                        break;
                    case 2: 
                        Console.WriteLine("Enter the name or surname of the contact you want to delete: ");
                        string nameOrSurname = Console.ReadLine();
                        bool found = false;
                        foreach (Contact c in contacts)
                        {
                            if (c.Name == nameOrSurname || c.Surname == nameOrSurname)
                            {
                                contacts.Remove(c);
                                break;
                            }
                        }
                        if(!found)
                        {
                            Console.WriteLine("Contact not found");
                            Console.WriteLine("Choose another operation:");
                            Console.WriteLine("1. End the delete operation");
                            Console.WriteLine("2. Try again.");
                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the name or surname of the contact you want to delete: ");
                                    string nameOrSurname2 = Console.ReadLine();
                                    foreach (Contact c in contacts)
                                    {
                                        if (c.Name == nameOrSurname2 || c.Surname == nameOrSurname2)
                                        {
                                            Console.WriteLine("{0} {1} will be deleted, are you sure? (y/n)", c.Name, c.Surname);
                                            string answer = Console.ReadLine();
                                            if (answer == "y")
                                            {
                                                contacts.Remove(c);
                                                break;
                                            }
                                            else 
                                            {
                                                Console.WriteLine("Choose another operation:");
                                                break;
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        break;      
                    case 3:
                        Console.WriteLine("Enter the name or surname of the contact you want to update: ");
                        string nameOrSurname3 = Console.ReadLine();
                        bool found2 = false;
                        foreach (Contact c in contacts)
                        {
                            if (c.Name == nameOrSurname3 || c.Surname == nameOrSurname3)
                            {
                                Console.WriteLine("Enter the new name of the contact: ");
                                string newName = Console.ReadLine();
                                Console.WriteLine("Enter the new surname of the contact: ");
                                string newSurname = Console.ReadLine();
                                Console.WriteLine("Enter the new phone number of the contact: ");
                                string newPhone = Console.ReadLine();
                                c.Name = newName;
                                c.Surname = newSurname;
                                c.Phone = newPhone;
                                found2 = true;
                                break;
                            }
                        }
                        if(!found2)
                        {
                            Console.WriteLine("Contact not found");
                            Console.WriteLine("Choose another operation:");
                            Console.WriteLine("1. End the update operation");
                            Console.WriteLine("2. Try again.");
                            int choice3 = Convert.ToInt32(Console.ReadLine());
                            switch (choice3)
                            {
                                case 1:
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the name or surname of the contact you want to update: ");
                                    string nameOrSurname4 = Console.ReadLine();
                                    foreach (Contact c in contacts)
                                    {
                                        if (c.Name == nameOrSurname4 || c.Surname == nameOrSurname4)
                                        {
                                            Console.WriteLine("Enter the new name of the contact: ");
                                            string newName = Console.ReadLine();
                                            Console.WriteLine("Enter the new surname of the contact: ");
                                            string newSurname = Console.ReadLine();
                                            Console.WriteLine("Enter the new phone number of the contact: ");
                                            string newPhone = Console.ReadLine();
                                            c.Name = newName;
                                            c.Surname = newSurname;
                                            c.Phone = newPhone;
                                            break;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("All contacts:");
                        foreach (Contact c in contacts)
                        {
                            Console.WriteLine("{0} {1} {2}", c.Name, c.Surname, c.Phone);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the name or surname of the contact you want to search: ");
                        string nameOrSurname5 = Console.ReadLine();
                        bool found3 = false;
                        foreach (Contact c in contacts)
                        {
                            if (c.Name == nameOrSurname5 || c.Surname == nameOrSurname5)
                            {
                                Console.WriteLine("{0} {1} {2}", c.Name, c.Surname, c.Phone);
                                break;
                            }
                        }
                        if(!found3)
                        {
                            Console.WriteLine("Contact not found");
                        }
                        break;
                }
            }
            catch (System.Exception)
            {
                throw new Exception("Please enter a valid number");
            }
        }
        
    }
}
