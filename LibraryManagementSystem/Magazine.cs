namespace Library_Management_System;

public  class Magazine : LibraryItem
{
    public Magazine(string title, int publicationYear) : base(title, publicationYear)
    {
       
    }
    public override void DisplayInfo()
    {
        throw new NotImplementedException();
    }
}
