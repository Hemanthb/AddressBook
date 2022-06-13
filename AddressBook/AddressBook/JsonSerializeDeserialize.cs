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
    }
}
