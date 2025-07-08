namespace Quantum_Bookstore.Classes
{
    public abstract class Book
    {
        public const int VALIDYEARS = 5;
        public string ISBN { get; set; }
        public string title { get; set; }
        public int publicationYear { get; set; }
        public double price { get; set; }
        public abstract string Buy(string isbn, int quantity, string email);

        protected Book(string ISBN, string title, int publicationYear, double price)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.publicationYear = publicationYear;
            this.price = price;
        }

        public override string ToString()
        {
            return $"the book with id: {ISBN} with title {title} published in {publicationYear} costs {price}";
        }
    }
}
