using System;
using System.Collections.Generic;   


public class Copy
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public bool IsAvailable { get; set; }

    public Copy()
    {
    }
}