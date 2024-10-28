namespace Library_Management_System;

public  class Book : LibraryItem
{
    public BookJenre Genre { get; set; }
    public LibraryLocation Location { get; set; }
    public Book(string title, int publicationYear, BookJenre genre, LibraryLocation location): base(title, publicationYear)
    {
        Genre = genre;
        Location = location;
    }
    public override void DisplayInfo()
    {
        throw new NotImplementedException();
    }
}
