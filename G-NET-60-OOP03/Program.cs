
namespace G_NET_60_OOP03;

internal class Program
{
    static void Main(string[] args)
    {
        #region Part01
        #region Question01
        //Q1: Identify the type of relationship in each scenario below

        //a) A University has Departments. If the university is closed,
        //    the departments no longer exist. ===> Composition

        //b) A Driver uses a Car. The driver does not own the car ===> Association

        //c) A Dog is an Animal. ==> Inheritance

        //d) A Team has Players. If the team is deleted, the players still exist. ==> Aggregation

        //e) A method receives a Logger as a parameter and calls it inside the method only. ==> Dependency



        #endregion

        #region Question02
        //Q2 : Answer the following questions about access modifiers and sealed:

        //a) A parent class has a protected field. Can a child class in a
        //different assembly access it? What about through an object
        //instance from outside?


        // Yes
        // No, code outside the class hierarchy cannot access it through an object instance.


        //b) What is the difference between protected internal and private protected?

        //protected internal
        //Derived classes OR any class in the same assembly

        //private protected
        //Derived classes ONLY within the same assembly


        //c) What does the sealed keyword do when applied to a class?
        //What about when applied to a method?

        //When applied to a class, sealed prevents any other class from inheriting from it.
        // When applied to a method, sealed prevents further overriding of that method in derived classes.


        //d) Can you create an object from a sealed class using new? Why or why not?
        //Yes, you can create an object from a sealed class using new.
        //This is because sealed only prevents inheritance and does not prevent object instantiation.

        #endregion

        #endregion

        #region Part02
        Cinema cinema = new Cinema("Cinema");

        cinema.OpenCinema();

        cinema.AddTicket(new StandardTicket("Inception", 120, "A-5"));
        cinema.AddTicket(new VIPTicket("Avengers", 200, true));
        cinema.AddTicket(new IMAXTicket("Dune", 180, false));

        cinema.PrintAllTickets();

        Console.WriteLine();
        Console.WriteLine("----------- Statistics -----------");
        Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

        cinema.CloseCinema();

        #endregion


    }
}
