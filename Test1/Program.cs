
using DataContext;

using (var context = new ApplicationDbContext())
{
    var tickets = context.Tickets;
    Console.WriteLine($"{tickets.Count()} tickets.");
}