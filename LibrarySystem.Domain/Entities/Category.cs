using System;
using System.Collections.Generic;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public List<Book> Books { get; set; } = new List<Book>();

    public Category(string name)
    {
        Name = name;
    
    }
}