namespace Race.Migrations
{
    using Race.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<Race.DAL.RaceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Race.DAL.RaceContext context)
        {
            var teams = new List<Team>
            {
                new Team{Name = "Ferrari", YearOfEstablishment=new DateTime(1960,05,12), EntryFee=true, NumberOfWonChampionShip=8},
                new Team{Name = "Force India", YearOfEstablishment=new DateTime(1970,05,10), EntryFee=false, NumberOfWonChampionShip=0},
                new Team{Name = "McLaren", YearOfEstablishment=new DateTime(1950,04,12), EntryFee=true, NumberOfWonChampionShip=5},
                new Team{Name = "Honda", YearOfEstablishment=new DateTime(1980,09,12), EntryFee=true, NumberOfWonChampionShip=3},
                new Team{Name = "Renault", YearOfEstablishment=new DateTime(1950,01,24), EntryFee=true, NumberOfWonChampionShip=4}
            };

            teams.ForEach(t => context.Teams.Add(t));
            context.SaveChanges();
        }
    }
}
