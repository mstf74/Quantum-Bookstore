using Quantum_Bookstore.Interfaces;
using Quantum_Bookstore.Services;

namespace Quantum_Bookstore.Classes
{
    public class PaperBook : Book
    {
        public int stock { get; set; }

        // access instance using singelton patteren
        private IShipable shippingService = ShippingService.Instance;

        public PaperBook(string ISBN, string title, int publicationYear, double price, int stock)
            : base(ISBN, title, publicationYear, price)
        {
            this.stock = stock;
        }

        public override string Buy(string isbn, int quantity, string email)
        {
            if (isbn != ISBN)
                return $"the ISBN is wrong";
            if (stock < quantity)
                return $"the quantity of {quantity} isn't available";
            stock -= quantity;
            shippingService.ShipToAddress(email);
            return $"the operation succedded with total price {quantity * price} and it's on the way to your address";
        }
    }
}
