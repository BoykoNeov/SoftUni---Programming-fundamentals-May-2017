/// <summary>
/// Task "Teamwork Projects"
/// It's time for teamwork projects and you are responsible for making the teams. First you will receive an integer - the count of the teams you will have to register. You will be given a user and a team (separated with "-").  The user is the creator of that team. For every newly created team you should print a message: "Team {team Name} has been created by {user}!". Next you will receive user with team (separated with "->") which means that the user wants to join that team. Upon receiving command: "end of assignment" you should print every team ordered by members count (descending) and then by name (ascending). For each team you have to print it's members sorted by name (ascending). However there are several rules:
/// - If user tries to create a team more than once a message should be displayed: 
/// "Team {teamName} was already created!"
/// - Creator of a team cannot create another team - message should be thrown: 
/// "{user} cannot create another team!"
/// - If user tries to join currently non-existing team a message should be displayed: 
/// "Team {teamName} does not exist!"
/// - Member of a team cannot join another team - message should be thrown:
/// "Member {user} cannot join team {team Name}!"
/// - In the end(after teams' report) teams with zero members (with only a creator) should disband.  Every team to disband should be printed ordered by name (ascending) 
/// </summary>
namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TeamworkProjects
    {
        public static void Main()
        {
            List<Team> teamList = new List<Team>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '-' });
                Team temp = new Team();
                temp.Name = input[1];
                temp.Creator = input[0];
                temp.Members = new List<string>();

                if (teamList.Any(x => x.Name == temp.Name))
                {
                    Console.WriteLine($"Team {temp.Name} was already created!");
                }
                else if (teamList.Any(x => x.Creator == temp.Creator))
                {
                    Console.WriteLine($"{temp.Creator} cannot create another team!");
                }
                else
                {
                    teamList.Add(temp);
                    Console.WriteLine($"Team {temp.Name} has been created by {temp.Creator}!");
                }
            }

            string inputString = string.Empty;
            while ((inputString = Console.ReadLine()) != "end of assignment")
            {
                string[] inputs = inputString.Split(new string[] { "->" }, StringSplitOptions.None);
                bool teamExists = false;
                bool alreadyMember = false;
                int currentTeamNumber = int.MinValue;
                for (int i = 0; i < teamList.Count; i++)
                {
                    if (teamList[i].Name == inputs[1] && !teamExists)
                    {
                        teamExists = true;
                        currentTeamNumber = i;
                    }

                    if (inputs[0] == teamList[i].Creator || teamList[i].Members.Contains(inputs[0]))
                    {
                        alreadyMember = true;
                    }
                }

                if (!teamExists)
                {
                    Console.WriteLine($"Team {inputs[1]} does not exist!");
                    continue;
                }

                if (alreadyMember && teamExists)
                {
                    Console.WriteLine($"Member {inputs[0]} cannot join team {inputs[1]}!");
                    continue;
                }

                teamList[currentTeamNumber].Members.Add(inputs[0]);
            }

            foreach (Team team in teamList
                                     .Where(x => x.Members.Count > 0)
                                     .OrderByDescending(x => x.Members.Count())
                                     .ThenBy(x => x.Name))
            {
                StringBuilder teamOutput = new StringBuilder();
                teamOutput.AppendFormat($"{team.Name}{Environment.NewLine}");
                teamOutput.AppendFormat($"- {team.Creator}{Environment.NewLine}");

                foreach (string member in team.Members.OrderBy(x => x))
                {
                    teamOutput.AppendFormat($"-- {member}{Environment.NewLine}");
                }

                Console.Write(teamOutput.ToString());
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team disbandedTeam in teamList
                                        .Where(x => x.Members.Count() == 0)
                                        .OrderBy(x => x.Name))
            {
                Console.WriteLine(disbandedTeam.Name);
            }
        }
    }
}