using System;
using System.Text;
using Ex_25_1_Udemy_Projeto.Entities;

Post post1 = new Post(
    DateTime.ParseExact("21/06/1997 13:05:44", "dd/MM/yyyy HH:mm:ss", null),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country",
    12
);

Comment comment1 = new Comment("Have a nice trip!");
Comment comment2 = new Comment("Wow, that's awesome!");

post1.AddComment(comment1);
post1.AddComment(comment2);

Console.WriteLine(post1);
