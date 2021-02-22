using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hotel_Management
{
    class Login:Exception
    {
        
        public void GetUserDetailes()
        {
            Console.WriteLine("Hai...!!! Welcome to \"Feel At Home\" Hotel");
            Console.WriteLine("To Register Please enter Your Name and Mobile Number");
            StreamWriter text = new StreamWriter(@"C:\Users\SMahendra167001\Desktop\Dotnet Coding\Hotel_Management\Login.txt");
            
            String Name;
            String MobileNo;
            int i = 0;
            while (i<3)
            {
                 Name = Console.ReadLine();
                 
                MobileNo = Console.ReadLine();
                try
                {

                    // can also use tryParse
                    if (MobileNo.Length != 10)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        text.WriteLine("Customer Name and Contact Detailes");
                        text.WriteLine("Name:{0}", Name);
                        text.WriteLine("Mobile NO:{0}",MobileNo);
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Please enter name and valid  mobile number again");
                    continue;
                    i++;

                };
                
            }
            
            //using (StreamWriter text = new StreamWriter(@"C:\Users\SMahendra167001\Desktop\Dotnet Coding\Hotel_Management\Login.txt"))
            //{
            //    text.WriteLine("Customer Name and Contact Detailes");
            //    text.WriteLine("Name:{0}", Name);
            //    text.WriteLine("Mobile NO:{0}",MobileNo);

            //}
            Console.WriteLine("Thank You For Registering With Us");
            Console.WriteLine("Please Select a Service which suits You");
            Console.WriteLine("Please select    1 to Book a Room\n\t\t 2 for Spa Services \n\t\t 3 for Party Hall Booking \n\t\t 4 for Table reservation");
            int service = int.Parse(Console.ReadLine());
           // Console.WriteLine("selected service is: {0}", service);
            switch (service) {
                case 1:
                    Services services = new Services();
                    services.RoomBooking();
                    break;
                case 2:
                    SpaServices spa = new SpaServices();
                    spa.Spa_service();
                    break;
                case 3:
                    PartyHall party = new PartyHall();
                    party.Party_Hall_Booking();
                    break;
                case 4:
                    Table_Reservation reserv = new Table_Reservation();
                    reserv.Reserv_table();
                    break;
}

               
            










        }

        
        public static void ValidateMobileNO(String MobileNum)

        {
            

        }





    }
}
