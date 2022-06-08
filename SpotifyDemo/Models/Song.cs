using System;
using System.Collections.Generic;

namespace SpotifyDemo.Models
{
    public partial class Song
    {
        public string Name { get; set; } = null!;
        public DateTime? DateOfRelease { get; set; }
        public string? Cover { get; set; }
    }
}
