using Restaurant.Models;

namespace Restaurant.Interfaces
{
    public interface IMenuService
    {
        void ReadCsvFile(string filePath, List<MenuItem> menu);
        void SortMenuId(List<MenuItem> menu);
    }
}
