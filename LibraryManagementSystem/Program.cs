namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // LibraryCatalog catalog = new LibraryCatalog();
            Book book = new Book("AliandNino", 1963, BookJenre.Fiction,new LibraryLocation(3,4));
            Magazine magazine = new Magazine("Code Academy", 2004);
            DVD dvd = new DVD("Sumaya Mammadova", 2006);
            dvd.DisplayInfo();
            magazine.DisplayInfo();
            book.DisplayInfo();
            Console.WriteLine(magazine.CalculateAge);
            
        }
    }
}
