using System;
using System.Collections.Generic;
using System.Net;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public required string ISBN { get; set; }

    public List<Author> Authors { get; set; } = new List<Author>();
    public Category? Category { get; set; }
    public  int CategoryId { get; set; }
    public List<Copy> Copies { get; set; } = new List<Copy>();

    public Book( string title, string isbn, DateTime publicationDate, int categoryId )
    
    {
        Title = title;
        ISBN = isbn;
        PublicationDate = publicationDate;
        CategoryId = categoryId;
       
    } 

}
