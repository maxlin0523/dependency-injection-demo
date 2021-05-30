﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Models
{
    /// <summary>
    /// Nba聯賽
    /// </summary>
    public class NbaController
    {
        private ISave _save;

        public NbaController(ISave save)
        {
            _save = save;
        }

        public void SaveRecord()
        {
            Console.WriteLine($"NBA is {_save.DoSave()}");
        }
    }
}
