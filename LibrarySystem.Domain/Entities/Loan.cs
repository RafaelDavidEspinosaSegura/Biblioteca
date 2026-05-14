using System;
using System.Collections.Generic;

public class Loan
{
    public int Id { get; set; }
    public int CopyId { get; set; }
    public Copy? Copy { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Loan(int copyId, DateTime loanDate)
    {
        CopyId = copyId;
        LoanDate = loanDate;
    
    }
}