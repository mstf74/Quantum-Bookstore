using Quantum_Bookstore.Interfaces;

namespace Quantum_Bookstore.Services
{
    // singelton pattern for better performance
    public class ShippingService : IShipable
    {
        public static readonly ShippingService Instance = new ShippingService();

        private ShippingService() { }

        public void ShipToAddress(string email)
        {
            Console.WriteLine(" shipped to the address of the email account");
        }
    }
}
