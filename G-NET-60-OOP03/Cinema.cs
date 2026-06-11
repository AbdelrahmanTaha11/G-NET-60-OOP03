
namespace G_NET_60_OOP03
{
    internal class Cinema
    {
        public string CinemaName { get; set; }

        private Projector projector;

        private Ticket[] tickets = new Ticket[20];

        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    break;
                }
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine();
            Console.WriteLine("----------- All Tickets -----------");

            foreach (Ticket ticket in tickets)
            {
                if (ticket != null)
                    Console.WriteLine(ticket);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("----------- Cinema Opened -----------");
            projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine();
            Console.WriteLine("----------- Cinema Closed -----------");
            projector.Stop();
        }
    }


}

