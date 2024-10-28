namespace Library_Management_System;

public sealed class LibraryMember : Person
{
    public DateTime MembershipDate { get; set; }
    public LibraryMember(string name, DateTime membershipDate):base(name)
    {
        MembershipDate=membershipDate;
    }
}
