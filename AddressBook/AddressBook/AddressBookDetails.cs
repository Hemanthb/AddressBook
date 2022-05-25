using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookDetails
    {
        Program program = new Program();

        public void CreateContacts()
        {
            ContactPerson contact = new ContactPerson();
            Console.WriteLine("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            contact.PostalCode = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.PhoneNo = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            contact.Email = Console.ReadLine();

            program.personDetails.Add(contact);

        }

        public void EditContacts()
        {
            Console.WriteLine("Enter First Name of a person to edit details: ");
            string firstName = Console.ReadLine();
            ContactPerson editContact = program.personDetails.FirstOrDefault(x => x.FirstName.ToLower() == firstName);
            
            if(editContact != null)
            {
                string opt = "y";
                while(opt == "y")
                {

                    Console.WriteLine("Enter the field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone No.\n8.Email");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name to update:");
                            editContact.FirstName = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name to update:");
                            editContact.LastName = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter Address to update:");
                            editContact.Address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter City to update:");
                            editContact.City = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter State to update:");
                            editContact.State = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip code to update:");
                            editContact.PostalCode = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone to update:");
                            editContact.PhoneNo = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter Email to update:");
                            editContact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid option:");
                            break;
                    }
                    Console.WriteLine("Enter 'y' to edit any other details or 'n' to exit");
                    opt = Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("No Data Exist!!");
            }

        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name of person to delete details: ");
            string firstName = Console.ReadLine();
            ContactPerson deleteContact = program.personDetails.FirstOrDefault(x => x.FirstName.ToLower() == firstName);
            if (deleteContact!=null)
            {
                Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)" + deleteContact.FirstName);

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    program.personDetails.Remove(deleteContact);
                }
            }
            else
            {
                Console.WriteLine("No Data Exist!!");
            }
            
        }

    }
}
