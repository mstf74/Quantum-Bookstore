using Quantum_Bookstore.Classes;

namespace Quantum_Bookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> booksInverntory = new List<Book>();
            string result;
            // regular cases, everything works well
            PaperBook paperBook = new PaperBook(
                ISBN: "CS12",
                title: "Computer Design",
                publicationYear: 2022,
                price: 12,
                stock: 20
            );
            booksInverntory.Add(paperBook);
            Ebook ebook = new Ebook(
                ISBN: "CS10",
                title: "Clean Code",
                publicationYear: 2022,
                price: 10
            );
            booksInverntory.Add(ebook);
            DemoBook demobook = new DemoBook(
                ISBN: "CS11",
                title: "Clean arch",
                publicationYear: 2025,
                price: 9
            );
            booksInverntory.Add(demobook);
            Console.WriteLine("normal cases:");
            result = paperBook.Buy(isbn: "CS12", quantity: 3, email: "test@test.com");
            Console.WriteLine(result);
            result = ebook.Buy(isbn: "CS10", quantity: 1, email: "test@test.com");
            Console.WriteLine(result);
            result = demobook.Buy(isbn: "CS11", quantity: 1, email: "test@test.com");
            Console.WriteLine(result);
            //------------------------------------------------------------------------------//
            // edge cases, not available in the inventory, wrong ISBN
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("edge cases:");
            PaperBook codeDesign = new PaperBook(
                ISBN: "CD21",
                title: "Computer Design",
                publicationYear: 2024,
                price: 12,
                stock: 3
            );
            result = codeDesign.Buy(isbn: "CD21", quantity: 4, email: "test@test.com");
            Console.WriteLine(result);
            result = codeDesign.Buy(isbn: "CS", quantity: 2, email: "test@test.com");
            //--------------------------------------------------------------------------------//
            // invaid year case:
            PaperBook book1 = new PaperBook(
                ISBN: "Ca12",
                title: "Computer systems",
                publicationYear: 2019,
                price: 12,
                stock: 20
            );
            PaperBook book2 = new PaperBook(
                ISBN: "Ce12",
                title: "Computer information",
                publicationYear: 2017,
                price: 12,
                stock: 20
            );
            Ebook book3 = new Ebook(
                ISBN: "Ca12",
                title: "Computer systems",
                publicationYear: 2018,
                price: 12
            );
            booksInverntory.Add(book1);
            booksInverntory.Add(book2);
            booksInverntory.Add(book3);
            List<Book> expiredBooks = booksInverntory
                .Where(b => DateTime.Now.Year - b.publicationYear > Book.VALIDYEARS)
                .ToList();
            Console.WriteLine("expired books: ");
            foreach (var book in expiredBooks)
            {
                booksInverntory.Remove(book);
                Console.WriteLine(book);
            }
            ;
        }
    }
}
