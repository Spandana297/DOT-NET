
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Essentials;


namespace Hotel_Management
{
    class Services : Display
    {
        public void RoomBooking()
        {

            List<Class1> items = new List<Class1>();
            items.Add(new Class1 { Name = "Normal_Room_for2", Cost = 50 });
            items.Add(new Class1 { Name = "Normal_Room_for3", Cost = 60 });
            items.Add(new Class1 { Name = "AC_Room_for2", Cost = 100 });
            items.Add(new Class1 { Name = "AC_Room_for3", Cost = 150 });

            Console.WriteLine("The available Rooms are as follows,Please select the one which suits you");
            foreach (var ele in items)
            {
                Console.WriteLine("{0} - $ {1}", ele.Name, ele.Cost);
            }
            String SelectedService = Console.ReadLine();
            Console.WriteLine("Enter the Number of rooms You wish to book:");
            int Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine(Quantity);


            int? ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == SelectedService.ToLower())?.Cost;
            Costdetailes(ref ItemCost, Quantity, SelectedService);


        }




    }

    class SpaServices : Display
    {
        public void Spa_service()
        {

            List<Class1> items = new List<Class1>();
            items.Add(new Class1 { Name = "Hair_Styling", Cost = 180 });
            items.Add(new Class1 { Name = "Bridal_MakeUp", Cost = 2000 });
            items.Add(new Class1 { Name = "Massage_Services", Cost = 1000 });
            items.Add(new Class1 { Name = "Pedicure_Manicure", Cost = 500 });


            Console.WriteLine("The available spa services are as follows,Please select the one which suits you");
            foreach (var ele in items)
            {
                Console.WriteLine("{0} - $ {1}", ele.Name, ele.Cost);
            }
            String SelectedService = Console.ReadLine();
            Console.WriteLine("Enter the count of people who wish to take the service:");
            int Quantity = int.Parse(Console.ReadLine());
            int? ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == SelectedService.ToLower())?.Cost;
            Costdetailes(ref ItemCost, Quantity, SelectedService);


        }




    }
    class PartyHall : Display
    {
        public void Party_Hall_Booking()
        {

            List<Class1> items = new List<Class1>();
            items.Add(new Class1 { Name = "Birthday_Party", Cost = 7000 });
            items.Add(new Class1 { Name = "Marriage", Cost = 200000 });
            items.Add(new Class1 { Name = "Engagement", Cost = 10000 });
            items.Add(new Class1 { Name = "Naming_Ceremony", Cost = 50000 });


            Console.WriteLine("The Party Hall is available for the following functions,select the one which suits you");
            Console.WriteLine("Decorations will be done accordingly");

            foreach (var ele in items)
            {
                Console.WriteLine("{0} - $ {1}", ele.Name, ele.Cost);
            }
            String SelectedService = Console.ReadLine();
            Console.WriteLine("Enter the estimated count of attendies :");
            int Quantity = int.Parse(Console.ReadLine());
            int? ItemCost = items.FirstOrDefault(c => c.Name.ToLower() == SelectedService.ToLower())?.Cost;
            Costdetailes(ref ItemCost, Quantity, SelectedService);


        }

        

        }

    public delegate void sampleDelegate();
    /// <summary>
    /// Action Delegate
    /// </summary>
    class Table_Reservation :Menu
    {
        public  void Reserv_table()
        {
            sampleDelegate sample = DisplayMenu;
            List<Class1> items = new List<Class1>();
            items.Add(new Class1 { Name = "Table_for_2"});
            items.Add(new Class1 { Name = "Table_for_4"});
            items.Add(new Class1 { Name = "Table_for_6"});
            items.Add(new Class1 { Name = "Table for_10"});

            foreach (var ele in items)
            {
                Console.WriteLine("{0} - $ {1}", ele.Name, ele.Cost);
            }
            String SelectedService = Console.ReadLine();
            Console.WriteLine("select the one which suits you");
            InvokeDelegate(sample);

           // DisplayMenu();
        }

        public static void InvokeDelegate(sampleDelegate sample)
        {
            sample();
        }
}




   

    }


