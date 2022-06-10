// See https://aka.ms/new-console-template for more information
namespace AddressBook {
    public class Program
    {
        //public List<ContactPerson> personDetails = new List<ContactPerson>();

        public static void Main(String[] args)
        {
            AddressBook.ContactPerson person = new AddressBook.ContactPerson();
            AddressBook.AddressBookDetails details = new AddressBook.AddressBookDetails();
            
            string yesOrNo = "y";
            while (yesOrNo == "y")
            {
                Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n" +
                    "4.Display Contacts\n5.Add Multiple Contacts\n6.Add Multiple Books\n");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        details.CreateContacts(person);
                        break;
                    case 2:
                        details.EditContacts();
                        break;
                    case 3:
                        details.DeleteContact();
                        break;
                    case 4:
                        details.DisplayDetails();
                        break;
                    case 5:
                        details.AddMultipleContacts();
                        break;
                    case 6:
                        details.AddMultipleAddressBooks();
                        break;
                    default:
                        Console.Write("Enter a valid option.\n");
                        break;

                }
                Console.WriteLine("Enter 'y' to select again or 'n' to exit");
                yesOrNo = Console.ReadLine();
             

            }

        }
    }
}
