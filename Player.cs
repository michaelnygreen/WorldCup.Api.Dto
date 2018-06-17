using System;

namespace WorldCup.Api.Dto
{
    public class Player
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Club { get; set; }

        public Position Position { get; set; }
        public int SquadNumber { get; set; }
    }
}
