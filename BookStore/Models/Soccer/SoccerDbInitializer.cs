using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NavigationProperty.Models
{
    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext db)
        {
            db.Teams.Add(new Team { Name = "Реал Мадрид", Coach = "Анчеллоти" });
            db.Teams.Add(new Team { Name = "Барселона", Coach = "Мартино" });
            db.Teams.Add(new Team { Name = "Бавария", Coach = "Гуардиола" });
            db.Teams.Add(new Team { Name = "Боруссия", Coach = "Клопп" });
            db.Players.Add(new Player { Name = "Месси", Age = 26, Position = "Нападающий", TeamId = 2 });
            db.Players.Add(new Player { Name = "Роналду", Age = 29, Position = "Нападающий", TeamId = 1 });
            db.Players.Add(new Player { Name = "Бейл", Age = 24, Position = "Поузащитник", TeamId = 1 });
            db.Players.Add(new Player { Name = "Неймар", Age = 22, Position = "Нападающий", TeamId = 2 });
            db.Players.Add(new Player { Name = "Иньеста", Age = 29, Position = "Полузащитник", TeamId = 2 });
            db.Players.Add(new Player { Name = "Рибери", Age = 30, Position = "Полузащитник", TeamId = 3 });
            //db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            //db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            //db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }

    }
}