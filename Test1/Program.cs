
using DataContext;

using (var context = new ApplicationDbContext())
{
    var tickets = context.BuyingTickets();
    Console.WriteLine($"{tickets.Count} tickets.");
}