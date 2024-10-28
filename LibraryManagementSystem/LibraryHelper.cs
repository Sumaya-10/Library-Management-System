namespace Library_Management_System;

public static class LibraryHelper
{
    public static int CalculateAge(this LibraryItem item)
    {
        return DateTime.Now.Year - item.PublicationYear;
    }
    public static int ToTitleCase(this LibraryItem item)
    {
        return DateTime.Now.Year - item.PublicationYear;
    }
    
}
