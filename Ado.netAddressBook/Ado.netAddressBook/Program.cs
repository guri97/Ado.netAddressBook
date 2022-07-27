namespace DAY33_ADO.NETAddressBookPP
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Select option\n1.Create AddrssBookServiceDatabase\n2.CreateTable\n3.InsertTntoTable");
            int op = Convert.ToInt16(Console.ReadLine());
            AddressBookModel model = new AddressBookModel();
            AddressBookRepo addressBookRepo = new AddressBookRepo();

            switch (op)
            {
                case 1:
                    addressBookRepo.Create_Database();
                    break;
                case 2:
                    addressBookRepo.CreateTables();
                    break;
                case 3:

                    model.FirstName = "Gurpreet";
                    model.LastName = "Singh";
                    model.Address = "Port Blair";
                    model.City = "Andaman";
                    model.State = "Andaman";
                    model.Zip = "744101";
                    model.PhoneNumber = "9531812464";
                    model.Email = "gsgurpreet766@gmail.com";
                    addressBookRepo.AddContact(model);
                    break;

                case 4:
                    addressBookRepo.RetriveAllContact();
                    break;

                case 5:
                    addressBookRepo.updateEmployeeDetails();
                    Console.WriteLine("updated sucsessFully");
                    break;

                case 6:
                    addressBookRepo.DeletingTheContactUsingFirst();
                    Console.WriteLine("deleted the data sucessfully");
                    break;

                case 7:
                    int countCity = addressBookRepo.CountOfEmployeeDetailsByCity();
                    Console.WriteLine("Count of Records for given City :" + countCity);
                    int CountState = addressBookRepo.CountOfEmployeeDetailsByState();
                    Console.WriteLine("Count of Records for given State :" + CountState);
                    break;

                case 8:
                    Console.WriteLine("Get Contacts for given City alphabetically sorted by FirstName");
                    addressBookRepo.GetContactsInAlphabeticalOrderOfFirstName();
                    break;

                case 9:
                    Console.WriteLine("Ability to identify each Address Book with name and Type.");
                    addressBookRepo.GetContactsBYAddressBookType();
                    break;
            }

        }
    }
}
