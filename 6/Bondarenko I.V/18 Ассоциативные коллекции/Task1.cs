using System.Collections;


namespace TestConsole
{
    class TelBook
    {
        protected Hashtable Book = new Hashtable();

        public virtual void AddContact(int phone, string secodName)
        {
            Book.Add(phone, secodName);
        }

        public virtual ArrayList SearchPhone(string secondName)
        {
            ArrayList phone = new ArrayList();

            if (Book.ContainsValue(secondName))
            {
                foreach (var contact in Book.Keys)
                {
                    if ((string)Book[contact] == secondName)
                    {
                        phone.Add(contact);
                    }
                } 
            }
            

            return phone;
        }

        public virtual string SearchSurname(int phone)
        {
            if (Book.ContainsKey(phone))
            {
                return (string)Book[phone]; 
            }
            return "";
        }
    }
}
