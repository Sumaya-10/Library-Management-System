namespace Library_Management_System;

public class LibraryCatalog : Exception
{
    public Book[] books;
    public Book this[int index]
    {
        get
        {
            if (!books.Contains(books[index]))
            {
                throw new CustomBookError();
            }
            return books[index];
        }
        set {
            
            books[index] = value; 
        }
     }    
}
