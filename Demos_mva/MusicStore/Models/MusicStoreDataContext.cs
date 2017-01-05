﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDataContext : DbContext  
    {
        public DbSet<Artist> Artists { get; set; }
    }
}