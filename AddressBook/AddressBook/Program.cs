// See https://aka.ms/new-console-template for more information
namespace AddressBook {
    public class Program
    {
        public List<AddressBook.ContactPerson> personDetails = new List<AddressBook.ContactPerson>();

        public static void Main(String[] args)
        {
            AddressBook.ContactPerson person = new AddressBook.ContactPerson();

            AddressBook.AddressBookDetails details = new AddressBook.AddressBookDetails();
            details.CreateContacts();
            details.EditContacts();
            details.DeleteContact();

        }
    }
}
