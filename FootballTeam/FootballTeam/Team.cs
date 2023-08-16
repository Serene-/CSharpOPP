using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("A name should not be empty.");
                name = value;
            }
        }
        public void AddPlayer(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Player player = new Player(name, endurance, sprint, dribble, passing, shooting);

            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            Player p = players.FirstOrDefault(p => p.Name == name);
            if (p != null) players.Remove(p);
            else throw new ArgumentException($"Player {name} is not in {this.Name} team.");
        }
        public int Rating()
        {
            double sum =0.0;
            foreach(var player in players)
            {
                sum = sum + player.SkillLevel();

            }
            if (players.Count > 0)
                return (int)Math.Round(sum / players.Count);
            else return 0;
        }
    }
}
