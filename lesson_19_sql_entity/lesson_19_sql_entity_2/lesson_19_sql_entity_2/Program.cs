using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace lesson_19_sql_entity_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // добавление данных
            /*using (MyDbContext db = new MyDbContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };
 
                // добавляем их в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            // получение данных
            using (MyDbContext db = new MyDbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }*/
            
            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };

                var group2 = new Group()
                {
                    Name = "Linkin Park"
                };
                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>
                {
                    new Song() {Name = "In the end", GroupId = group2.Id},
                    new Song() {Name = "Numb", GroupId = group2.Id},
                    new Song() {Name = "Mutter", GroupId = group.Id}
                };
                
                context.Songs.AddRange(songs);
                context.SaveChanges();


                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Group Name: {song.Group.Name}");
                }
                Console.ReadLine();
            }
        }
    }
}