namespace Restaurant.Interfaces
{
    public interface IOrderService
    {
        void MainMenu();
        void SeatClients();
        void ChangingTableOcupancy();
        void RegisterClientOrder();
        Task PrintOrderToFile(int orderId);
        void SendCheckViaEmail();

    }
}
