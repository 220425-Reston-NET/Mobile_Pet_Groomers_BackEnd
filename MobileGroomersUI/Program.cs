Customer COBJ = new Customer();

Customer COBJ = new(12345, "Crawford", "Troy", "None@none.com", "123 main st", "9549999999");


// create menu//

            Boolean on = true;
            while (on)
            {
                Console.WriteLine("---Make A Selection---");
                Console.WriteLine("Main Menu :: ");
                Console.WriteLine("Press <1> for Create An Account");
                Console.WriteLine("Press <2> for Search An Account");
                Console.WriteLine("Press <0> for Exit");
                Console.WriteLine("================================ ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    // exit program//
                    on = false;
                }
                else if (choice == "1")
                {
                     // add an account
                    Console.WriteLine("Please Enter Your Phone Number");
                    COBJ.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Address");
                    COBJ.Address = Console.ReadLine();
                    Console.WriteLine("Please Enter First Name");
                    COBJ.FirstName = Console.ReadLine();
                    Console.WriteLine("Please Enter Last Name");
                    COBJ.LastName = Console.ReadLine();
                    Console.WriteLine("Please Enter  Email");
                    COBJ.Email = Console.ReadLine();
                    Console.WriteLine("Main Menu :: ");
                    Console.WriteLine("Press <1> Create Account");
                    Console.WriteLine("Press <0> for Exit");
                    Console.WriteLine("================================ ");
                    String userInput = Console.ReadLine();
                    if (userInput == "1")
                    {

                        // store logic//

                        CustomerRepository repository = new CustomerRepository();

                        repository.AddCustomer(COBJ);

                    }


                    else if (userInput == "0")
                    {

                        // exit
                        on = false;
                    }



                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter Customer Name");

                    string CusNameInput = "";
                    CusNameInput = Console.ReadLine();


                    // search a customer


                    //string filepath = @"/Users/rolosworld/Documents/Revature2022/StoreApp/TroyStore2022/Customer.txt";

                    string filepath = "Customer.txt";

                    //string readText = File.ReadAllText(filepath);
                    // Console.WriteLine(readText);

                    using (StreamReader sr = File.OpenText(filepath))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            bool b = s.Contains("LastName\":\"" + CusNameInput) || s.Contains("FirstName\":\"" + CusNameInput);
                            if (b)
                                Console.WriteLine(s);



                        }
                    }


                }
                else
                {
                    Console.WriteLine("Please input a valid response");
                }

            }