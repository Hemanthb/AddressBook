using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBook
{
    public class JsonSerializeDeserialize
    {
        
        public void SerializeData(AddressBookDetails bookDetails)
        {
            string jsonFile = @"D:\blabz_fellowship\AddressBook\AddressBook\AddressBook\JsonAddressBook.json";
            var options = new JsonSerializerOptions();
            foreach (string key in bookDetails.multipleAddressBook.Keys)
            {
                
                string jsonString = JsonSerializer.Serialize(bookDetails.multipleAddressBook[key], options);
                //string[] strings = jsonString.Split(',');
                File.AppendAllText(jsonFile,jsonString);
            }

        }

        public void DeserializeJsonData()
        {
            string jsonFile = @"D:\blabz_fellowship\AddressBook\AddressBook\AddressBook\JsonAddressBook.json";
            string jsonData = File.ReadAllText(jsonFile);
            List<ContactPerson> contact_person = JsonSerializer.Deserialize<List<ContactPerson>>(jsonData);
            foreach (var person in contact_person)
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
    }
}
