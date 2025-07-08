using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Classes
{
    public class DemoBook : Book
    {
        public DemoBook(string ISBN, string title, int publicationYear, double price)
            : base(ISBN, title, publicationYear, price) { }

        public override string Buy(string isbn, int quantity, string email)
        {
            return "can't buy this book, it's just a Show case book";
        }
    }
}
