using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager
{
    class Program
    {
        static List<Contact> contacts = new List<Contact>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Contact Manager");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        ViewContacts();
                        break;
                    case "3":
                        UpdateContact();
                        break;
                    case "4":
                        DeleteContact();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine();
            Console.Write("Enter contact phone number: ");
            string phoneNumber = Console.ReadLine();
            contacts.Add(new Contact(name, phoneNumber));
            Console.WriteLine("Contact added. Press any key to continue...");
            Console.ReadKey();
        }

        static void ViewContacts()
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void UpdateContact()
        {
            Console.Write("Enter the name of the contact to update: ");
            string name = Console.ReadLine();
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                Console.Write("Enter new phone number: ");
                string newPhoneNumber = Console.ReadLine();
                contact.PhoneNumber = newPhoneNumber;
                Console.WriteLine("Contact updated. Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Contact not found. Press any key to continue...");
            }
            Console.ReadKey();
        }

        static void DeleteContact()
        {
            Console.Write("Enter the name of the contact to delete: ");
            string name = Console.ReadLine();
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted. Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Contact not found. Press any key to continue...");
            }
            Console.ReadKey();
        }
    }
}
