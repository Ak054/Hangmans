﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangmans.DataLayer
{
    public class GameWord
    {
        [PrimaryKey, AutoIncrement]
        public int WordID { get; set; }

        [Unique]
        public string Word { get; set; }
    }
}