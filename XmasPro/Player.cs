﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XmasPro
{
    public class Player
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string  Name { get; set; }
    }
}
