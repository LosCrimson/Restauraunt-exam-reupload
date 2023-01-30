using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.UnitTests
{
    [TestClass]
    public class UiServiceTests
    {
        [TestMethod]

        public void PrintingTableList_AsksForTableList_PrintTheTablesList()
        {
            //Arrange 
            var tablePrinter = new UiService();
            var tableList = new List<Table> { new Table(1, 1, false)};
            var t = new Table(1, 1, false);
            var expectation = $"Table number: {t.Id} | seating capacity: {t.SeatingCapacity} | occupied: {t.Occupied}\r\n";

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            //Act
            tablePrinter.PrintingTableList(tableList);
            //Assert
            var output = stringWriter.ToString();
            Assert.AreEqual(output, expectation);
        }
    }
}
