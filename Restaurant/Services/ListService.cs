using Restaurant.Interfaces;
using Restaurant.Models;

namespace Restaurant.Services
{
    public class ListService : IListService
    {
        public List<MenuItem> FindingMenuItemsViaID(List<int> idList, List<MenuItem> menuList)
        {
            List<MenuItem> clientItemList = new List<MenuItem>();
            foreach(var id in idList)
            {
                foreach(var menuItem in menuList)
                {
                    if(id == menuItem.Id)
                    {
                        clientItemList.Add(menuItem);
                    }
                }
            }
            return clientItemList;
        }

        public double SumOfMenuItems(List<MenuItem> clientItemList)
        {
            double sum = 0;
            foreach (var clientItem in clientItemList) 
            {
                sum += clientItem.Price; 
            }
            return sum;
        }

        public string[] ConverOrderToString(Order order)
        {
            List<string> stringMenuItemList = new List<string>();
            foreach (var item in order.Menu)
            {
                stringMenuItemList.Add($"Id: {item.Id} | Name: {item.Item} {item.Price}eu\r\n");
            }
            string menuItems = String.Join("|", stringMenuItemList.ToArray());

            string[] Check =
            {
                $"CHECK\r\n",
                $"Check id: {order.Id}\r\n",
                $"Table : {order.Table}\r\n",
                menuItems,
                $"Total price: {order.Sum}eu\r\n",
                $"Date: {order.Date} \r\n",
             };

            return Check;
        }
    }
}
