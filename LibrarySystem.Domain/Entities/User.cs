using   system;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }

    public List<Loan> Loans { get; set; } = new List<Loan>();
    public List<Reservation> Reservations { get; set; } = new List<Reservation>();

    public User()
    {
    }
}