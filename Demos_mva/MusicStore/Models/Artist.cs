using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        [Required()]
        [StringLength(111),MinLength(1)]
        public string Name { get; set; }

    }
}