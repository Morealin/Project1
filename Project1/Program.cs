using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Player
    {
        public string Name { get; set; }
        public string Institution { get; set; }
        public int Cost { get; set; }
        public int Rank { get; set; }
        public Boolean IsDraft { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> QuarterBack = new List<Player>();
            QuarterBack.Add(new Player { Name = "Mason Rudolph", Institution = "Oklahoma State", Cost = 26400100, Rank = 1, IsDraft = false});
            QuarterBack.Add(new Player { Name = "Lamar Jackson", Institution = "Louisville", Cost = 20300100, Rank = 2, IsDraft = false });
            QuarterBack.Add(new Player { Name = "Josh Rosen", Institution = "UCLA", Cost = 17420300, Rank = 3, IsDraft = false });
            QuarterBack.Add(new Player { Name = "Sam Dornald", Institution = "Southern California", Cost = 13100145, Rank = 4, IsDraft = false });
            QuarterBack.Add(new Player { Name = "Baker Mayfield", Institution = "Oklahoma", Cost = 10300000, Rank = 5, IsDraft = false });
            List<Player> RunningBack = new List<Player>();
            RunningBack.Add(new Player { Name = "Saquon Barkley", Institution = "Penn State", Cost = 24500100, Rank = 1, IsDraft = false });
            RunningBack.Add(new Player { Name = "Derrius Guice", Institution = "LSU", Cost = 19890200, Rank = 2, IsDraft = false });
            RunningBack.Add(new Player { Name = "Bryce Love", Institution = "Stanford", Cost = 18700800, Rank = 3, IsDraft = false });
            RunningBack.Add(new Player { Name = "Ronald Jones II", Institution = "Southern California", Cost = 15000000, Rank = 4, IsDraft = false });
            RunningBack.Add(new Player { Name = "Damien Harris", Institution = "Alabama", Cost = 11600400, Rank = 5, IsDraft = false });
            List<Player> WideReceiver = new List<Player>();
            WideReceiver.Add(new Player { Name = "Courtland Sutton", Institution = "Southern Methodist", Cost = 23400000, Rank = 1, IsDraft = false });
            WideReceiver.Add(new Player { Name = "James Washington", Institution = "Oklahoma State", Cost = 21900300, Rank = 2, IsDraft = false });
            WideReceiver.Add(new Player { Name = "Marcell Ateman", Institution = "Oklahoma State", Cost = 19300230, Rank = 3, IsDraft = false });
            WideReceiver.Add(new Player { Name = "Anthony Miller", Institution = "Memphis", Cost = 13400230, Rank = 4, IsDraft = false });
            WideReceiver.Add(new Player { Name = "Calvin Ridley", Institution = "Alabama", Cost = 10000000, Rank = 5, IsDraft = false });
            List<Player> DefensiveLineman = new List<Player>();
            DefensiveLineman.Add(new Player { Name = "Maurice Hurst", Institution = "Michigan", Cost = 26200300, Rank = 1, IsDraft = false });
            DefensiveLineman.Add(new Player { Name = "Vita Vea", Institution = "Washington", Cost = 22000000, Rank = 2, IsDraft = false });
            DefensiveLineman.Add(new Player { Name = "Taven Bryan", Institution = "Florida", Cost = 16000000, Rank = 3, IsDraft = false });
            DefensiveLineman.Add(new Player { Name = "Da'ron Payne", Institution = "Alabama", Cost = 18000000, Rank = 4, IsDraft = false });
            DefensiveLineman.Add(new Player { Name = "Harrison Phillips", Institution = "Stanford", Cost = 10300000, Rank = 5, IsDraft = false });
            List<Player> DefensiveBack = new List<Player>();
            DefensiveBack.Add(new Player { Name = "Joshua Jackson", Institution = "Iowa", Cost = 24000000, Rank = 1, IsDraft = false });
            DefensiveBack.Add(new Player { Name = "Derwin James", Institution = "Florid State", Cost = 22500249, Rank = 2, IsDraft = false });
            DefensiveBack.Add(new Player { Name = "Denzel Ward", Institution = "Ohio State", Cost = 20000100, Rank = 3, IsDraft = false });
            DefensiveBack.Add(new Player { Name = "Minkah Fitzpatrick", Institution = "Alabama", Cost = 16000200, Rank = 4, IsDraft = false });
            DefensiveBack.Add(new Player { Name = "Isaiah Oliver", Institution = "Colorado", Cost = 11899999, Rank = 5, IsDraft = false });
            List<Player> TightEnd = new List<Player>();
            TightEnd.Add(new Player { Name = "Mark Andrews", Institution = "Oklahoma", Cost = 27800900, Rank = 1, IsDraft = false });
            TightEnd.Add(new Player { Name = "Dallas Goedert", Institution = "So. Dakota State", Cost = 210008000, Rank = 2, IsDraft = false });
            TightEnd.Add(new Player { Name = "Jaylen Samuels", Institution = "NC State", Cost = 17499233, Rank = 3, IsDraft = false });
            TightEnd.Add(new Player { Name = "Mike Gesicki", Institution = "Penn State", Cost = 27900200, Rank = 4, IsDraft = false });
            TightEnd.Add(new Player { Name = "Troy Fumagalli", Institution = "Wisconsin", Cost = 14900333, Rank = 5, IsDraft = false });
            List<Player> LineBacker = new List<Player>();
            LineBacker.Add(new Player { Name = "Roquan Smith", Institution = "Georgia", Cost = 22900300, Rank = 1, IsDraft = false });
            LineBacker.Add(new Player { Name = "Termaine Edmunds", Institution = "Virginia Tech", Cost = 19000590, Rank = 2, IsDraft = false });
            LineBacker.Add(new Player { Name = "Kendall Joseph", Institution = "Clemson", Cost = 18000222, Rank = 3, IsDraft = false });
            LineBacker.Add(new Player { Name = "Dorian O'Daniel", Institution = "Clemson", Cost = 12999999, Rank = 4, IsDraft = false });
            LineBacker.Add(new Player { Name = "Malik Jefferson", Institution = "Texas", Cost = 10000100, Rank = 5, IsDraft = false });
            List<Player> OffensiveTackle = new List<Player>();
            OffensiveTackle.Add(new Player { Name = "Orlando Brown", Institution = "Oklahoma", Cost = 23000000, Rank = 1, IsDraft = false });
            OffensiveTackle.Add(new Player { Name = "Kolton Miller", Institution = "UCLA", Cost = 20000000, Rank = 2, IsDraft = false });
            OffensiveTackle.Add(new Player { Name = "Chukwuma Okorafor", Institution = "Western Michigan", Cost = 19400000, Rank = 3, IsDraft = false });
            OffensiveTackle.Add(new Player { Name = "Connor Williams", Institution = "Texas", Cost = 16200700, Rank = 4, IsDraft = false });
            OffensiveTackle.Add(new Player { Name = "Mike McGlinchey", Institution = "Notre Dame", Cost = 15900000, Rank = 5, IsDraft = false });

            string EXIT = "";
            List<List<Player>> position = new List<List<Player>>{ QuarterBack, RunningBack, WideReceiver,DefensiveLineman,DefensiveBack,TightEnd,LineBacker,OffensiveTackle};
            string[] positionList = { "Quarterbacks","Running Backs","Wide Receivers","Defensive Lineman","Defensive Backs","Tight Ends","Line Backers","Offensive Tackles"};

            Console.WriteLine("This is  drafting program what draft pro NFL players. " +
                "\nYou may draft up to five players or Until you exceed you budget of $95,000,000.");

            while (EXIT != "exit")
            {
                int budget = 95000000;
                int totalSpent = 0;
                int playersDrafted = 0;
                int selectedPlayer = 0;
                string selection = "";

                while (playersDrafted < 5 && budget >= 10000000)
                {
                    for (int i=0; i<position.Count; i++)
                    {
                        if (playersDrafted < 5 && budget >= 10000000)
                        {
                            Console.WriteLine("Total Spent to far: " + totalSpent.ToString("C"));
                            Console.WriteLine("Current Budget: " + budget.ToString("c"));
                            Console.WriteLine("Currently showing " + positionList[i]);

                            if (!position[i][0].IsDraft)
                            {
                                Console.WriteLine("Name: " + position[i][0].Name + ", Institution: " +
                                    position[i][0].Institution + ", Cost: " + position[i][0].Cost.ToString("c") + ", Rank: " + position[i][0].Rank);
                            }
                            if (!position[i][1].IsDraft)
                            {
                                Console.WriteLine("Name: " + position[i][1].Name + ", Institution: " +
                                    position[i][1].Institution + ", Cost: " + position[i][1].Cost.ToString("c") + ", Rank: " + position[i][1].Rank);
                            }
                            if (!position[i][2].IsDraft)
                            {
                                Console.WriteLine("Name: " + position[i][2].Name + ", Institution: " +
                                    position[i][2].Institution + ", Cost: " + position[i][2].Cost.ToString("c") + ", Rank: " + position[i][2].Rank);
                            }
                            if (!position[i][3].IsDraft)
                            {
                                Console.WriteLine("Name: " + position[i][3].Name + ", Institution: " +
                                    position[i][3].Institution + ", Cost: " + position[i][3].Cost.ToString("c") + ", Rank: " + position[i][3].Rank);
                            }
                            if (!position[i][4].IsDraft)
                            {
                                Console.WriteLine("Name: " + position[i][4].Name + ", Institution: " +
                                    position[i][4].Institution + ", Cost: " + position[i][4].Cost.ToString("c") + ", Rank: " + position[i][4].Rank);
                            }
                            Console.WriteLine("Please select a player by entering the rank of the player or enter 0 to not select a player from this position");
                            Boolean temp = true;
                            while (temp)
                            {
                                try { selectedPlayer = Convert.ToInt32(Console.ReadLine()); temp = false; }
                                catch (System.FormatException)
                                {
                                    Console.WriteLine("Invalid Selection. Please select a player by entering the rank of the player or " +
                                        "enter 0 to not select a player " +
                                        "from this position");
                                }
                            }
                            if (selectedPlayer != 0)
                            {
                                budget -= position[i][selectedPlayer - 1].Cost;
                                totalSpent += position[i][selectedPlayer - 1].Cost;
                                playersDrafted++;
                                position[i][selectedPlayer - 1].IsDraft = true;
                                selection += position[i][selectedPlayer - 1].Name + ", ";
                            }
                        }
                    }   
                }
                Console.WriteLine("You have run out of money or hit the 5 player limit." +
                    "\nYou have selected " + selection);
                Console.WriteLine("Thank you for Drafting players. To start a new draft hit enter." +
                    "\nTo exit the program type exit.");
                EXIT = Console.ReadLine();
            }
        }
    }
}
