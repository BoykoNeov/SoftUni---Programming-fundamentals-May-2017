// Class for holding information about teams

namespace TeamworkProjects
{
    using System.Collections.Generic;

   public class Team
    {
       public string Creator { get; set; }

       public List<string> Members { get; set; }

       public string Name { get; set; }
    }
}
