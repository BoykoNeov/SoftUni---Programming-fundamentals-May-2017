namespace TeamworkProjects
{
    using System.Collections.Generic;

    /// <summary>
    /// Class for holding information about teams
    /// </summary>
    public class Team
    {
       public string Creator { get; set; }

       public List<string> Members { get; set; }

       public string Name { get; set; }
    }
}
