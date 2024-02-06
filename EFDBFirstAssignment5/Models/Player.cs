using System;
using System.Collections.Generic;

namespace EFDBFirstAssignment5.Models
{
    public partial class Player
    {
        public int PlayersId { get; set; }
        public string FisrtName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? JerseyNumber { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
    }
}
