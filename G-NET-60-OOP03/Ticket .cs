
namespace G_NET_60_OOP03;

internal class Ticket
{

    private static int counter = 0;

    public string MovieName { get; set; }

    private decimal price;
    public decimal Price
    {
        get => price;
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public int TicketId { get; }

    public decimal PriceAfterTax => Price * 1.14m;

    public Ticket(string movieName, decimal price)
    {
        MovieName = movieName;
        Price = price;
        TicketId = ++counter;
    }

    public static int GetTotalTickets()
    {
        return counter;
    }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }



}
