﻿using Restaurant.Enum;
using Restaurant.Interfaces;
using Restaurant.Models;
using System.Net.Mail;

namespace Restaurant.Services
{
    public class UiService : IUiService
    {
        public ActionTypes GetActionType()
        {
            do
            {
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("[1] Seat clients.");
                Console.WriteLine("[2] Fill in client order.");
                Console.WriteLine("[3] Table availability.");
                Console.WriteLine("[4] Send check via email.");
                Console.WriteLine("[5] EXIT");

                string? menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                    case "SEAT":
                        return ActionTypes.SEAT;
                    case "2":
                    case "CHECK":
                        return ActionTypes.ORDER;
                    case "3":
                    case "LAST":
                        return ActionTypes.TABLES;
                    case "4":
                    case "TAEKOUT":
                        return ActionTypes.EMAIL;
                    case "5":
                    case "EXIT":
                        return ActionTypes.EXIT;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
            while (true);
        }
        public int? SelectingNumberOfClientsToSeat()
        {
            Console.WriteLine("How many people will be seated?");
            try
            {
                int numberOfCustomers = Convert.ToInt32(Console.ReadLine());
                return numberOfCustomers;
            } catch 
            {
                Console.WriteLine("Not a number!");
                return null; 
            }
        }

        public void PrintingTableList(List<Table> tables)
        {
            tables.ForEach(t => Console.WriteLine($"Table number: {t.Id} | seating capacity: {t.SeatingCapacity} | occupied: {t.Occupied}"));
        }

        public Table PickingTable(List<Table> tables)
        {
            Console.WriteLine("Please pick a table.");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            Table selectedTable = tables.Single(t => t.Id == tableNumber);
            return selectedTable;
        }

        public int OrderingMenuItems()
        {
            Console.WriteLine("Please write items id");
            int clientOrder = Convert.ToInt32(Console.ReadLine());
            return clientOrder;
        }
        public void PrintMenu(List<MenuItem> menu)
        {
            menu.ForEach(item => Console.WriteLine($"Id: {item.Id} | Name: {item.Item} {item.Price}eu"));
        }

        public bool AreClientsSeated()
        {
            Console.WriteLine("Are clients seated? [Y]YES [N]NO");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer.Equals("Y"))
                { return true; }
                else if (answer.Equals("N"))
                { return false; }
            }
        }
        public bool DoClientsWantCheckViaEmail()
        {
            Console.WriteLine("Do you want the check via email? [Y]YES [N]NO");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer.Equals("Y"))
                { return true; }
                else if (answer.Equals("N"))
                { return false; }
            }

        }

        public int TableSelectionForWaiter()
        {
            Console.WriteLine("At which table are the clients seated?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void PrintOrder(Order order)
        { 
            Console.WriteLine("CHECK");
            Console.WriteLine($"Check id: {order.Id}");
            Console.WriteLine($"Table : {order.Table}");
            foreach(var item in order.Menu)
            {
                Console.WriteLine($"Id: {item.Id} | Name: {item.Item} {item.Price}eu");
            }
            Console.WriteLine($"Total price: {order.Sum}eu");
            Console.WriteLine($"Date: {order.Date}");
        }

        public int SelectingCheckIdForEmail()
        {
            Console.WriteLine("Which Check would you like to send?");
            Console.WriteLine("Please write Id");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string SelectingCheckEmail() 
        {
            Console.WriteLine("PLease fill in email: ");

            try
            {
                var emailAdress = new MailAddress(Console.ReadLine());
                return emailAdress.ToString();
            }
            catch
            {
                Console.WriteLine("Email typed incorrectly!");
                return null;
            }
        }
    }
}
