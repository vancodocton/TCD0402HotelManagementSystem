using System;

namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hotel hotel = new Hotel("Abc");
            hotel.Name = "Melia";

            Room room = new Room();
            Guest guest = new Guest(room);

        }
    }
}
