

namespace G_NET_60_OOP03
{
    internal class VIPTicket:Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price + ServiceFee} EGP | After Tax: {(Price + ServiceFee) * 1.14m:F2} EGP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
        }

    }
}
