﻿namespace Library_Management_System;

public class Librarian : Person
{
    public DateTime HireDate { get; set; }

    public Librarian(string name,DateTime hireDate):base(name)
    {
        HireDate = hireDate;
    }
}
