using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Monopoly.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }

        public string PlayerName { get; set; }

        public int PlayerBalance { get; set; }

        public int PlayerPosition { get; set; }

    }
}