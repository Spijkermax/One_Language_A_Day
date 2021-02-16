using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersApp
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private string position;
        private string dob;
        private string team;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Position { get => position; set => position = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Team { get => team; set => team = value; }

        public Player(string first, string last, string pos, string birth, string teamm)
        {
            FirstName = first;
            LastName = last;
            Position = pos;
            Dob = birth;
            Team = teamm;

        }
        public override string ToString()
        {
            return "First name: " + firstName + ", Last name: " + lastName + ", Position: " + position + ", Date of Birth: " + dob + ", Team: " + team;
        }

        public static void EditPlayer(List<Player> players)
        {
            Console.WriteLine("First Name of Player to be Edited");
            string fname = Console.ReadLine();
            Console.WriteLine("Last Name of Player to be Edited");
            string lname = Console.ReadLine();

            foreach (Player p in players) 
            {
                if (p.firstName.Equals(fname))
                {
                    Console.WriteLine("do you want do edit first name(1), last name(2), position(3), Date of birth(4) or team(5)?");
                    string editChoice = Console.ReadLine();
                    if (editChoice.Equals("1"))
                    {
                        Console.WriteLine("What do you want to edit it to?");
                        string newName = Console.ReadLine();
                        p.firstName = newName;
                        Console.WriteLine("First name changed to: " + p.firstName);
                    }
                    if (editChoice.Equals("2"))
                    {
                        Console.WriteLine("What do you want to edit it to?");
                        string newLastName = Console.ReadLine();
                        p.lastName = newLastName;
                        Console.WriteLine("Last name changed to: " + p.lastName);
                    }
                    if (editChoice.Equals("3"))
                    {
                        Console.WriteLine("What do you want to edit it to?");
                        string newPosition = Console.ReadLine();
                        p.position = newPosition;
                        Console.WriteLine("Position changed to: " + p.position);
                    }
                    if (editChoice.Equals("4"))
                    {
                        Console.WriteLine("What do you want to edit it to?");
                        string newDob = Console.ReadLine();
                        p.dob = newDob;
                        Console.WriteLine("Date of Birth changed to: " + p.dob);
                    }
                    if (editChoice.Equals("5"))
                    {
                        Console.WriteLine("What do you want to edit it to?");
                        string newTeam = Console.ReadLine();
                        p.team = newTeam;
                        Console.WriteLine("Team changed to: " + p.team);
                    }
                }

            }
        }
        public static void CreatePlayer(List<Player> players)
        {
            Console.WriteLine("First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Position");
            string posi = Console.ReadLine();
            Console.WriteLine("Date of Birth");
            string dateob = Console.ReadLine();
            Console.WriteLine("Team");
            string nteam = Console.ReadLine();

            Player newPlayer = new Player(fname, lname, posi, dateob, nteam);
            players.Add(newPlayer);
            Console.WriteLine("Player created: " + newPlayer.ToString());

        }
        public static void RemovePlayer(List<Player> players)
        {
            Console.WriteLine("first name of player");
            string firstNameEdit = Console.ReadLine();
            Console.WriteLine("Last name of player");
            string lastNameEdit = Console.ReadLine();
            foreach (Player p in players)
            {
                if (p.firstName.Contains(firstNameEdit) && (p.lastName.Contains(lastNameEdit)))
                {
                    players.Remove(p);
                    Console.WriteLine("Player removed: " + p.ToString());
                }
            }
        }
        public static void ViewPlayers(List<Player> players)
        {
            Console.WriteLine("do you want to filter by first name(1), last name(2), position(3), Date of birth(4) or team(5)?");
            string filterOutput = Console.ReadLine();
            foreach (Player p in players)
            {
                if (filterOutput.Equals("1"))
                {
                    Console.WriteLine("What First Name do you want to filter by?");
                    string fNameFilter = Console.ReadLine();
                    if (fNameFilter.Equals(p.firstName))
                    Console.WriteLine(p.ToString());
                }
                if (filterOutput.Equals("2"))
                {
                    Console.WriteLine("What Last Name do you want to filter by?");
                    string lNameFilter = Console.ReadLine();
                    if (lNameFilter.Equals(p.lastName))
                        Console.WriteLine(p.ToString());
                }
                if (filterOutput.Equals("3"))
                {
                    Console.WriteLine("What Position do you want to filter by?");
                    string positionFilter = Console.ReadLine();
                    if (positionFilter.Equals(p.position)) 
                        Console.WriteLine(p.ToString());
                }
                if (filterOutput.Equals("4"))
                {
                    Console.WriteLine("What Date of Birth do you want to filter by?");
                    string dobFilter = Console.ReadLine();
                    if (dobFilter.Equals(p.dob))
                        Console.WriteLine(p.ToString());
                }
                if (filterOutput.Equals("5"))
                {
                    Console.WriteLine("What Team do you want to filter by?");
                    string teamFilter = Console.ReadLine();
                    if (teamFilter.Equals(p.team))
                        Console.WriteLine(p.ToString());
                }
            }

        }
    }
}
