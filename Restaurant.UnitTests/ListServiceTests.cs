using Restaurant.Services;
using Restaurant.Models;
using Moq;
using Restaurant.Interfaces;

namespace Restaurant.UnitTests
{
    [TestClass]
    public class ListServiceTests
    {
        
        [TestMethod]
        public void SumOfMenuItems_SumIs10_10()
        {
            //Arrange
            var listService = new ListService();
            var itemList = new List<MenuItem> { 
                new MenuItem(1, "duck", 2.00),
                new MenuItem(2, "goose", 3.00),
                new MenuItem(3, "wine", 4.00),
                new MenuItem(4, "beer", 1.00),
            };
            //Act
            var result = listService.SumOfMenuItems(itemList);
            //Assert
            Assert.AreEqual(result, 10.00);
        }

        [TestMethod]

        public void FindingMenuItemsViaID_ShouldReturnDuck_WhenListIsPopulated()
        {
            //Arrange
            var listService = new ListService();
            var idList = new List<int> { 1 };
            var menuList = new List<MenuItem>
            {
                new MenuItem(1, "duck", 2.00),
            };
            var expectation = "duck";
            //Act
            var clientItemList = listService.FindingMenuItemsViaID(idList, menuList);
            var result = clientItemList.ToString();
            clientItemList.ForEach(item => result = item.Item);
            //Assert
            Assert.AreEqual(expectation, result);
        }

    }
}