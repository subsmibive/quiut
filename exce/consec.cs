using System;
using System.Collections.Generic;
using System.Linq;

public class Ticket
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample data
        List<Ticket> Tickets = new List<Ticket>
        {
            new Ticket { Id = 1, Description = "Fix bug #123", IsCompleted = true },
            new Ticket { Id = 2, Description = "Implement feature XYZ", IsCompleted = false },
            new Ticket { Id = 3, Description = "Update documentation", IsCompleted = true }
        };

        // LINQ query to filter completed tickets
        var completedTickets = Tickets.Where(ticket => ticket.IsCompleted == true);

        // Alternatively, you can simplify the condition as:
        // var completedTickets = Tickets.Where(ticket => ticket.IsCompleted);

        // Output the completed tickets
        foreach (var ticket in completedTickets)
        {
            Console.WriteLine($"Ticket ID: {ticket.Id}, Description: {ticket.Description}");
        }
    }
}
