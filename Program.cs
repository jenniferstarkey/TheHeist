using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Who is your team member?");
            string name = Console.ReadLine();
            Console.WriteLine("What is their skill level?");
            int skill = int.Parse(Console.ReadLine());
            Console.WriteLine("What about their courage? (0.0-2.0)");
            decimal courage = int.Parse(Console.ReadLine());

            Console.WriteLine($"New Team Memeber {name}:");
            Console.WriteLine($"Skill Level: {skill}");
            Console.WriteLine($"Courage Level: {courage}");



        }
        public class teamMember
        {
            public string name { get; set; }
            public int skill { get; set; }
            public decimal courage { get; set; }
        }

    }
}
