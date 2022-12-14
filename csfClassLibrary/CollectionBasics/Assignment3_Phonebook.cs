using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.CollectionBasics
{
    public class Assignment3_Phonebook
    {
        private readonly string helloMsg = "What would you like to do?";
        private readonly string helpMsg = "1: Add new contact. \n2: Get contact by number. \n3: Get all contacts. \n4: Get numbers to contact name. \n0: Exit.";
        private readonly string whatToDoMsg = "Please enter number.";
        private readonly string invalidMsg = "Please provide correct number.";
        private readonly string newCntMsg = "Please provide number and contact.";
        private readonly string cntToNumbMsg = "Please provide number.";
        private readonly string allContactsMsg = "All your contacts are:";
        private readonly string numbersToContactMsg = "Please provide contact name.";

        Dictionary<int, string> phoneBook = new Dictionary<int, string>() { };
        public Assignment3_Phonebook()
        {
            
        }

        public void RunPhoneBook()
        {
            int number;

            Console.WriteLine($"{helloMsg}\n{helpMsg}\n\n{whatToDoMsg}");

            int userControl;

            Int32.TryParse(Console.ReadLine(), out userControl);

            switch (userControl)
            {
                case 1:
                    Console.WriteLine(newCntMsg);
                    Console.WriteLine("Number:");
                    Int32.TryParse(Console.ReadLine(), out number);
                    Console.WriteLine("Contact name:");

                    AddContact(number, Console.ReadLine());
                    ReturnToStart();

                    break;
                case 2:
                    Console.WriteLine(cntToNumbMsg);
                    Console.WriteLine("Number:");
                    Int32.TryParse(Console.ReadLine(), out number);

                    GetContactToNumber(number);
                    ReturnToStart();

                    break;
                case 3:
                    Console.WriteLine(allContactsMsg);

                    GetAllContacts();
                    ReturnToStart();

                    break;
                case 4:
                    Console.WriteLine(numbersToContactMsg);

                    GetNumbersToContactName(Console.ReadLine());
                    ReturnToStart();

                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine(invalidMsg);
                    break;
            }


        }

        private void ReturnToStart()
        {
            RunPhoneBook();
        }

        /// <summary>
        /// Adds new contact.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="contact"></param>
        private void AddContact(int number, string contact)
        {
            if (phoneBook.ContainsKey(number))
            {
                Console.WriteLine($"Please provide unique number.");
                ReturnToStart();

            }

            try
            {
                phoneBook.Add(number, contact);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Problem occured: {ex.Message}");
            }
            

        }

        /// <summary>
        /// Returns contact for given number.
        /// </summary>
        /// <param name="number"></param>
        private void GetContactToNumber(int number)
        {
            string contact = phoneBook.Where(x => x.Key == number).FirstOrDefault().Value;

            Console.WriteLine($"Contact: {contact}");

        }

        /// <summary>
        /// Returns all contacts.
        /// </summary>
        private void GetAllContacts()
        {
            List<string> contactList = phoneBook.Values.ToList();

            contactList.ForEach(x => Console.WriteLine(x));

        }

        /// <summary>
        /// Returns all numbers keys to given name.
        /// </summary>
        /// <param name="name"></param>
        private void GetNumbersToContactName(string name)
        {
            List<int> numbersList = new List<int>() { };

            phoneBook.Where(x => x.Value.Equals(name)).ToList().ForEach(x => numbersList.Add(x.Key));

            numbersList.ForEach(x => Console.WriteLine(x));

        }


    }
}
