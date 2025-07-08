using Quantum_Bookstore.Interfaces;
using Quantum_Bookstore.Services;

namespace Quantum_Bookstore.Classes
{
    public class Ebook : Book
    {
        ISendableByMail mailService = MailService.Instance;

        public Ebook(string ISBN, string title, int publicationYear, double price)
            : base(ISBN, title, publicationYear, price) { }

        public override string Buy(string isbn, int quantity, string email)
        {
            if (isbn != ISBN)
                return $"the ISBN is wrong";
            mailService.SendToMail(email);
            return "the mail is sent to your mail";
        }
    }
}
