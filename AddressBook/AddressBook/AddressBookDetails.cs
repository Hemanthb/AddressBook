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
        public void createContacts()
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

        public void editContacts()
        {
            Console.WriteLine("Enter First Name of a person to edit details: ");
            string firstName = Console.ReadLine();

            foreach (ContactPerson contact in program.personDetails)
            {
                if (contact.FirstName.ToLower().Equals(firstName.ToLower()))
                {
                    string opt = "y";
                    while(opt == "y"){
                        Console.WriteLine("Enter the field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone No.\n8.Email");
                        Console.WriteLine("Enter your choice:");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name to update:");
                                contact.FirstName = Convert.ToString(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter Last Name to update:");
                                contact.LastName = Convert.ToString(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter Address to update:");
                                contact.Address = Convert.ToString(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter City to update:");
                                contact.City = Convert.ToString(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter State to update:");
                                contact.State = Convert.ToString(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Zip code to update:");
                                contact.PostalCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter Phone to update:");
                                contact.PhoneNo = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Enter Email to update:");
                                contact.Email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid option:");
                                break;
                        }
                        Console.WriteLine("Enter 'y' to edit any other details or 'n' to exit");
                        opt = Console.ReadLine();
                    }
                }
            }

        }

    }
}
