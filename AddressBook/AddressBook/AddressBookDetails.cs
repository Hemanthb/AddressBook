﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookDetails
    {
        ContactPerson cp = new ContactPerson();
        List<ContactPerson> personDetails = new List<ContactPerson>();
        Dictionary<string, List<ContactPerson>> multipleAddressBook = new Dictionary<string, List<ContactPerson>>();
        public void CreateContacts(ContactPerson contact)
        {
            
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

            //Checks Whether the contact exist already by searching for the first name
            ContactPerson cp = personDetails.FirstOrDefault(x => x.Equals(contact));
            //(personDetails.ForEach(x => x.Equals(contact)))
            /* 
            { Console.WriteLine("Contact Exist Already in Address Book!"); };
            
            foreach(ContactPerson person in personDetails)
            {
                if (person.Equals(contact))
                {
                    Console.WriteLine("Contact Exist Already in Address Book!");
                }
                else
                {
                    personDetails.Add(contact);
                }
            }*/
            //if(foreach(ContactPerson conPerson in personDetails.FirstOrDefault(x=>x.Equals(contact))))
            if(cp == null)
            {
                personDetails.Add(contact);
            }
            else
            {
                Console.WriteLine("Contact Exist Already in Address Book!");
            }

        }

       
        public void EditContacts()
        {
            Console.WriteLine("Enter First Name of a person to edit details: ");
            string firstName = Console.ReadLine();
            ContactPerson editContact =  personDetails.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            
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

            ContactPerson deleteContact = personDetails.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (deleteContact!=null)
            {
                Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)" + deleteContact.FirstName);

                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    personDetails.Remove(deleteContact);
                }
            }
            else
            {
                Console.WriteLine("No Data Exist!!");
            }
            
        }

        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter the number of contacts you want to add:");
            int addContacts = Convert.ToInt32(Console.ReadLine());
            
            while (addContacts > 0)
            {
                ContactPerson contactPerson = new ContactPerson();
                CreateContacts(contactPerson);
                addContacts--;
            }

        }

        public void AddMultipleAddressBooks()
        {
            
            Console.WriteLine("Enter the number of address book you want to add: ");
            int noOfBooks = Convert.ToInt32(Console.ReadLine());
            while (noOfBooks > 0)
            {
                Console.WriteLine("Enter group name:");
                string groupName = Console.ReadLine();
                personDetails = new List<ContactPerson>();
                AddMultipleContacts();
                if (multipleAddressBook.ContainsKey(groupName))
                {
                    foreach(var contact in personDetails)
                        multipleAddressBook[groupName].Add(contact);

                }
                else
                {
                    multipleAddressBook.Add(groupName, personDetails);
                }
                noOfBooks--;
            }
            DisplayAddressBookDetails();
            
        }
        public void DisplayDetails()
        {
            foreach (ContactPerson person in personDetails)
            {
                Console.WriteLine("Contact Details of -" + person.FirstName);
                Console.WriteLine("Last Name          -" + person.LastName);
                Console.WriteLine("Address            -" + person.Address);
                Console.WriteLine("City               -" + person.City);
                Console.WriteLine("State              -" + person.State);
                Console.WriteLine("Zipcode            -" + person.PostalCode);
                Console.WriteLine("Phone No           -" + person.PhoneNo);
                Console.WriteLine("Email Id           -" + person.Email);
                Console.WriteLine();
            }
        }

        public void DisplayAddressBookDetails()
        {
            //Displays Details of Address Book
            foreach (var key in multipleAddressBook.Keys)
            {
                Console.WriteLine("Details under category -- " + key);
                Console.WriteLine();
                foreach (var item in multipleAddressBook[key])
                {
                    Console.WriteLine("Contact Details of -" + item.FirstName);
                    Console.WriteLine("Last Name          -" + item.LastName);
                    Console.WriteLine("Address            -" + item.Address);
                    Console.WriteLine("City               -" + item.City);
                    Console.WriteLine("State              -" + item.State);
                    Console.WriteLine("Zipcode            -" + item.PostalCode);
                    Console.WriteLine("Phone No           -" + item.PhoneNo);
                    Console.WriteLine("Email Id           -" + item.Email);
                    Console.WriteLine();
                }
            }
        }

    }
}
