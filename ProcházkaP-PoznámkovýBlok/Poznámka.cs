﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcházkaP_PoznámkovýBlok
{
    internal class Poznámka
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public Poznámka(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public Poznámka(string radek)
        {
            string[] data = radek.Split(';');
            Title = data[0];
            Text = data[1];
        }

        public override string ToString()
        {
            return Title;
        }

        public void UpravitPoznámku(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public string UlozitCSV()
        {
            return $"{Title};{Text}";
        }
    }
}
