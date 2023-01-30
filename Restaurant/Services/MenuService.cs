using Restaurant.Interfaces;
using Restaurant.Models;

namespace Restaurant.Services
{
    public class MenuService : IMenuService
    {
        public void ReadCsvFile(string filePath, List<MenuItem> menu)
        {
            string[] csvLines = File.ReadAllLines(filePath);

            for (int i = 1; i < csvLines.Length; i++) 
            {
                MenuItem item = new MenuItem(csvLines[i]);
                menu.Add(item);
            }
        }
        public void SortMenuId(List<MenuItem> menu) 
        {
            int i = 1;
            menu.ForEach(p => p.Id = i++);
        }
    }
}
