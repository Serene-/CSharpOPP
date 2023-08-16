using System.Data;

namespace FootballTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Team> teams = new List<Team>();
            while(input!="END")
            {
                string[] line = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = line[0];
                if(command=="Team")
                {
                    Team team = new Team(line[1]);
                    teams.Add(team);
                }
                if (command == "Add")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == line[1]);
                    int[] stats = { int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]) };
                    if (team != null) team.AddPlayer(line[2], stats[0], stats[1], stats[2], stats[3], stats[4]);
                    else throw new ArgumentException($"Team {line[1]} does not exist.");

                }
                if (command == "Remove")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == line[1]);
                    if (team != null) team.RemovePlayer(line[2]);
                }
                if (command == "Rating")
                {
                    Team team = teams.FirstOrDefault(x => x.Name == line[1]);
                    if (team != null) Console.WriteLine($"{line[1]} - {team.Rating()}");
                    else throw new ArgumentException($"Team {line[1]} does not exist.");

                }

                input = Console.ReadLine();
            }
        }
    }
}