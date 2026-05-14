using System;
using System.Collections.Generic;

public class Reservation
{
    public int Id { get; set; }
    public int CopyId { get; set; }
    public Copy? Copy { get; set; }
    public DateTime ReservationDate { get; set; }

    public Reservation(int copyId, DateTime reservationDate)
    {
        CopyId = copyId;
        ReservationDate = reservationDate;
    
    }
}