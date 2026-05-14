using System;
using System.Collections.Generic;
using System.Net;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public required string ISBN { get; set; }

    Ppublic list<Author> Authors { get; set; } = new List<Author>();
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public list<Copy> Copies { get; set; } = new List<Copy>();

    public Book()
    {
    } 

}
