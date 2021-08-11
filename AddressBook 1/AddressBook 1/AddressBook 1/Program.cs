using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<ContactPerson> AddressBookList = new List<ContactPerson>();
                Console.WriteLine("Enter Any 1 Option\n1. To Add " + "\n2. To Delete " + "\n3. To Edit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("First Name: ");
                        string FirstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string LastName = Console.ReadLine();
                        Console.Write("Address: ");
                        string Address = Console.ReadLine();
                        Console.Write("City: ");
                        string City = Console.ReadLine();
                        Console.Write("State: ");
                        string State = Console.ReadLine();
                        Console.Write("Postal Code: ");
                        int Zip = int.Parse(Console.ReadLine());
                        Console.Write("Phone Number: ");
                        double Phone_No = double.Parse(Console.ReadLine());
                        Console.Write("Email ID: ");
                        string email_id = Console.ReadLine();
                        ContactPerson contactperson = new ContactPerson(FirstName, LastName, Address, City, State, Zip, Phone_No, email_id);
                        AddressBookList.Add(contactperson);
                        foreach (var i in AddressBookList)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter The Index Of An Element Which You Want To Remove   : ");
                        int wrongIndex = int.Parse(Console.ReadLine());
                        AddressBookList.RemoveAt(wrongIndex);
                        foreach (var i in AddressBookList)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter The Index Of The Element Which You Want To Edit:   ");
                        int editIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Number As \n(1).To Edit First Name  \n(2).To Edit Last Name  \n(3).To Edit Address  \n(4).To Edit City  \n(5).To Edit State  \n(6).To Edit Postal Code  \n(7).To Edit Phone Number  \n(8).To Edit Email ID  :   ");
                        int number = int.Parse(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                AddressBookList[editIndex].FirstName = Console.ReadLine();
                                break;
                            case 2:
                                AddressBookList[editIndex].LastName = Console.ReadLine();
                                break;
                            case 3:
                                AddressBookList[editIndex].Address = Console.ReadLine();
                                break;
                            case 4:
                                AddressBookList[editIndex].City = Console.ReadLine();
                                break;
                            case 5:
                                AddressBookList[editIndex].State = Console.ReadLine();
                                break;
                            case 6:
                                AddressBookList[editIndex].Zip = int.Parse(Console.ReadLine());
                                break;
                            case 7:
                                AddressBookList[editIndex].Phone_No = double.Parse(Console.ReadLine());
                                break;
                            case 8:
                                AddressBookList[editIndex].email_id = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Enter The Correct Num  ");
                                break;
                        }
                        foreach (var i in AddressBookList)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    default:
                        Console.WriteLine("Give The Correct Input Number");
                        break;
                }
                if (option > 3)
                {
                    Console.WriteLine("You Entered Wrong Option");
                }
            }
        }
    }
}
