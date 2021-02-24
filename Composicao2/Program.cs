﻿using System;
using Composicao2.Entities;

namespace Composicao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit rhis wonderful contry!", 12);
            p1.AddComments(c1);
            p1.AddComments(c2);

            Console.WriteLine(p1);
        }
    }
}
