using Restaurant.Models;

namespace Restaurant.Interfaces
{
    public interface IListService
    {
        List<MenuItem> FindingMenuItemsViaID(List<int> idList, List<MenuItem> menuList);
        double SumOfMenuItems(List<MenuItem> clientItemList);
        string[] ConverOrderToString(Order order);
    }
}
