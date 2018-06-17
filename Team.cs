using System;

namespace WorldCup.Api.Dto
{
    public class Team
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Group { get; set; }

        public Player[] Players { get; set; }
    }
}
