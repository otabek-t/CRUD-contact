namespace contacts
{
    internal class Program
    {
        public static List<int> TelephoneContact = new List<int>();

        public static void DataContacts()
        {
            TelephoneContact.Add(901234567);
            TelephoneContact.Add(904568524);
            TelephoneContact.Add(904515452);
            TelephoneContact.Add(906585255);
            TelephoneContact.Add(902855568);
            TelephoneContact.Add(904856556);
        }

        static void Main(string[] args)
        {
            DataContacts();
            InputPart();
        }

        public static void InputPart()
        {
            while (true)
            {
                Console.WriteLine("1. Add the contact");
                Console.WriteLine("2. Delete the contact");
                Console.WriteLine("3. Edit the contact");
                Console.WriteLine("4. Show the contact");
                Console.WriteLine("Choose the option:");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter Telephone number: ");
                        var contactNumber = int.Parse(Console.ReadLine());
                        var addContact = AddContact(contactNumber);
                        if (addContact == -1)
                        {
                            Console.WriteLine("Contact error!");
                        }
                        else
                        {
                            Console.WriteLine($"Added the contact successfully at index: {addContact}");
                        }
                        break;

                    case 2:
                        Console.Write("Enter Deleted Contact: ");
                        var deleteContact = int.Parse(Console.ReadLine());
                        var checkDelete = DeleteContact(deleteContact);
                        if (checkDelete)
                        {
                            Console.WriteLine("Deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Not deleted, error occurred!");
                        }
                        break;

                    case 3:
                        Console.Write("Enter old contact: ");
                        var oldContact = int.Parse(Console.ReadLine());
                        Console.Write("Enter new contact: ");
                        var newContact = int.Parse(Console.ReadLine());
                        var updateStatus = UpdateContact(oldContact, newContact);
                        if (updateStatus)
                        {
                            Console.WriteLine("Contact updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Update failed, check input format or contact existence.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("List of contacts:");
                        foreach (var contact in TelephoneContact)
                        {
                            Console.WriteLine(contact);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid number.");
                        break;
                }
            }
        }

        public static int AddContact(int contact)
        {
            var containsInTelCon = TelephoneContact.Contains(contact);
            var inValidFormat = TrueOrFalseContact(contact.ToString());

            if (containsInTelCon || !inValidFormat)
            {
                return -1;
            }
            TelephoneContact.Add(contact);
            return TelephoneContact.Count - 1;
        }

        public static bool TrueOrFalseContact(string contact)
        {
            if (contact.Length != 9)
            {
                return false;
            }

            foreach (var ch in contact)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool DeleteContact(int copydelete)
        {
            var checkCopy = TelephoneContact.Contains(copydelete);
            if (checkCopy)
            {
                TelephoneContact.Remove(copydelete);
            }
            return checkCopy;
        }

        public static bool UpdateContact(int oldContact, int newContact)
        {
            var indexSecond = TelephoneContact.IndexOf(oldContact);
            var isValidNewContact = TrueOrFalseContact(newContact.ToString());

            if (indexSecond < 0 || !isValidNewContact)
            {
                return false;
            }

            TelephoneContact[indexSecond] = newContact;
            return true;
        }
    }
}
 