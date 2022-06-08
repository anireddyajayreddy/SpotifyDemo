using System;
using System.Collections.Generic;

namespace SpotifyDemo.Models
{
    public partial class Artist
    {
        public string Name { get; set; } = null!;
        public DateTime? Dob { get; set; }
        public string? Bio { get; set; }
    }
}
