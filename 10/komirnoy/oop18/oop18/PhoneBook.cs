using System;
using System.Collections;
using System.Text;

namespace oop18 {
    class PhoneBook {
        IDictionary phoneBook;

        public PhoneBook() {
            phoneBook = new MyDictionary();
        }

        public void AddPhone(string phone, string name) {
            if(phoneBook.Contains(phone))
                return;
            
            phoneBook.Add(phone, name);
        }

        public void EditName(string phone, string newName) {
            if(phoneBook.Contains(phone))
                phoneBook[phone] = newName;
        }

        public string FindName(string phone) {
            if(phoneBook.Contains(phone))
                return phoneBook[phone] as string;
            
            return string.Empty;
        }

        public string FindPhone(string name) {
            if((phoneBook.Values as ArrayList).Contains(name))
                return (phoneBook.Keys as ArrayList)[(phoneBook.Values as ArrayList).IndexOf(name)] as string;

            return string.Empty;
        }
    }
}
