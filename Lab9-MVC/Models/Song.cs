﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab9_MVC.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public int GenreId{ get; set; }

    }
}