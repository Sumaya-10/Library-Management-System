namespace Library_Management_System;

 public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    protected Person(string name)
    {
        if (Name == null) throw new ArgumentNullException("name");
        Name = name;
    }
}
