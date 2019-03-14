namespace F1WebApp_CodeFirstSeededDb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using F1WebApp_CodeFirstSeededDb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<F1WebApp_CodeFirstSeededDb.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(F1WebApp_CodeFirstSeededDb.DAL.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //Calling the lists of respective objects
            GetCars().ForEach(c => context.Cars.AddOrUpdate(c));
            GetConstructors().ForEach(c => context.Constructors.AddOrUpdate(c));
            GetDrivers().ForEach(d => context.Drivers.AddOrUpdate(d));
            context.SaveChanges();
        }
        //Defining Cars list
        public static List<Car> GetCars()
        {
            List<Car> Cars = new List<Car>
            {
                new Car
                {
                    CarID = 1,
                    Name = "F1 W05 Hybrid",
                    Year = 2014,
                    Wins = 16,
                    Podiums = 31,
                    Poles = 18,
                    FastestLaps = 12,
                    Constructor = merc,
                    Driver = LH44
                },
                 new Car
                {
                    CarID = 2,
                    Name = "F1 W06 Hybrid",
                    Year = 2015,
                    Wins = 16,
                    Podiums = 32,
                    Poles = 18,
                    FastestLaps = 13,
                    Constructor = merc,
                    Driver = LH44
                },
                new Car
                {
                    CarID = 3,
                    Name = "F1 W07 Hyrbid",
                    Year = 2016,
                    Wins = 19,
                    Podiums = 33,
                    Poles = 20,
                    FastestLaps = 9,
                    Constructor = merc,
                    Driver = LH44
                },
                new Car
                {
                    CarID = 4,
                    Name = "F1 W08 Hybrid",
                    Year = 2017,
                    Wins = 19,
                    Podiums = 33,
                    Poles = 20,
                    FastestLaps = 9,
                    Constructor = merc,
                    Driver = LH44
                },
                 new Car
                {
                    CarID = 5,
                    Name = "F1 W08 EQPower",
                    Year = 2018,
                    Wins = 12,
                    Podiums = 26,
                    Poles = 15,
                    FastestLaps = 9,
                    Constructor = merc,
                    Driver = LH44
                },
                new Car
                {
                    CarID=6,
                    Name="F138",
                    Year=2013,
                    Wins=2,
                    Podiums=10,
                    Poles=0,
                    FastestLaps=2,
                    Constructor = ferrari,
                    Driver = FA3
                },
                new Car
                {
                    CarID=7,
                    Name="F14 T",
                    Year=2014,
                    Wins=0,
                    Podiums=2,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = ferrari,
                    Driver = FA3
                },
                new Car
                {
                    CarID=8,
                    Name="MP4-30",
                    Year=2015,
                    Wins=0,
                    Podiums=0,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = mcLaren,
                    Driver = FA3
                },
                new Car
                {
                    CarID=9,
                    Name="MP4-31",
                    Year=2016,
                    Wins=0,
                    Podiums=0,
                    FastestLaps=1,
                    Poles=0,
                    Constructor = mcLaren,
                    Driver = FA3
                },
                new Car
                {
                    CarID=10,
                    Name="MCL32",
                    Year=2017,
                    Wins=0,
                    Poles=0,
                    Podiums=0,
                    FastestLaps=1,
                    Constructor = mcLaren,
                    Driver = FA3
                },
                new Car
                {
                    CarID=11,
                    Name="MCL33",
                    Year=2018,
                    Wins=0,
                    Podiums=0,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = mcLaren,
                    Driver = FA3
                },
                new Car
                {
                    CarID=12,
                    Name="RB8",
                    Year=2012,
                    Wins=7,
                    Podiums=14,
                    Poles=8,
                    FastestLaps=7,
                    Constructor = redBull,
                    Driver = SV05
                },
                new Car
                {
                    CarID=13,
                    Name="RB9",
                    Year=2013,
                    Wins=13,
                    Podiums=24,
                    Poles=11,
                    FastestLaps=12,
                    Constructor = redBull,
                    Driver = SV05
                },
                new Car
                {
                    CarID=14,
                    Name="RB10",
                    Year=2014,
                    Wins=13,
                    Podiums=24,
                    Poles=11,
                    FastestLaps=12,
                    Constructor = redBull,
                    Driver = SV05
                },
                new Car
                {
                    CarID=15,
                    Name="SF15-T",
                    Year=2015,
                    Wins=3,
                    Podiums=16,
                    Poles=1,
                    FastestLaps=3,
                    Constructor = ferrari,
                    Driver = SV05
                },
                new Car
                {
                    Name="SF16-H",
                    Year=2016,
                    Wins=0,
                    Podiums=11,
                    Poles=0,
                    FastestLaps=4,
                    Constructor = ferrari,
                    Driver = SV05
                },
                new Car
                {
                    Name="SF70H",
                    Year=2017,
                    Wins=5,
                    Podiums=20,
                    Poles=5,
                    FastestLaps=7,
                    Constructor = ferrari,
                    Driver = SV05
                },
                new Car
                {
                    Name="SF71H",
                    Year=2018,
                    Wins=6,
                    Poles=6,
                    Podiums=24,
                    FastestLaps=4,
                    Constructor = ferrari,
                    Driver = SV05
                },
                new Car
                {
                    Name="STR8",
                    Year=2013,
                    Wins=0,
                    Podiums=0,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = toroRosso,
                    Driver = DR3
                },
                new Car
                {
                    Name="RB11",
                    Year=2015,
                    Wins=0,
                    Podiums=3,
                    Poles=0,
                    FastestLaps=3,
                    Constructor = redBull,
                    Driver = DR3
                },
                new Car
                {
                    Name="RB12",
                    Year=2016,
                    Wins=2,
                    Podiums=16,
                    Poles=1,
                    FastestLaps=5,
                    Constructor = redBull,
                    Driver = DR3
                },
                new Car
                {
                    Name="RB13",
                    Year=2017,
                    Wins=3,
                    Podiums=13,
                    Poles=0,
                    FastestLaps=2,
                    Constructor = redBull,
                    Driver = DR3
                },
                new Car
                {
                    Name="RB14",
                    Year=2018,
                    Wins=4,
                    Podiums=13,
                    Poles=2,
                    FastestLaps=6,
                    Constructor = redBull,
                    Driver = DR3
                },
                new Car
                {
                    Name="R.S. 16",
                    Year=2016,
                    Wins=0,
                    Podiums=0,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = renault,
                    Driver = KMAG
                },
                new Car
                {
                    Name="VF-17",
                    Year=2017,
                    Wins=0,
                    Podiums=0,
                    Poles=0,
                    FastestLaps=0,
                    Constructor = haas,
                    Driver = KMAG
                },
                new Car
                {
                    Name="VF-18",
                    Year=2018,
                    Wins=0,
                    Poles=0,
                    Podiums=0,
                    FastestLaps=1,
                    Constructor = haas,
                    Driver = KMAG
                },
                new Car
                {
                    Name = "FW40",
                    Year = 2017,
                    Wins = 0,
                    Podiums = 1,
                    Poles = 0,
                    FastestLaps = 0,
                    Constructor = williams,
                    Driver = FM19
                },
                new Car
                {
                    Name = "VJM11",
                    Year = 2017,
                    Wins = 0,
                    Poles = 0,
                    Podiums = 1,
                    FastestLaps = 0,
                    Constructor = forceIndia,
                    Driver = EO31
                },
                new Car
                {
                    Name = "Sauber C36",
                    Year = 2018,
                    Wins = 0,
                    Poles = 0,
                    Podiums = 0,
                    FastestLaps = 0,
                    Constructor = alfaRomeo,
                    Driver = LH44
                }
            };
            return Cars;
        }

        //Defining constructors list
        public static List<Constructor> GetConstructors()
        {
            //Constructors
            List<Constructor> constructors = new List<Constructor>();

            //Adding Constructors to constructor list
            constructors.Add(merc);
            constructors.Add(ferrari);
            constructors.Add(redBull);
            constructors.Add(mcLaren);
            constructors.Add(haas);
            constructors.Add(forceIndia);
            constructors.Add(renault);
            constructors.Add(williams);
            constructors.Add(toroRosso);
            constructors.Add(alfaRomeo);

            return constructors;
        }

        //Defining drivers list
        public static List<Driver> GetDrivers()
        {
            //Defining Drivers
            List<Driver> drivers = new List<Driver>();

            //Adding drivers to driver list
            drivers.Add(LH44);
            drivers.Add(FA3);
            drivers.Add(SV05);
            drivers.Add(DR3);
            drivers.Add(KMAG);
            drivers.Add(FM19);
            drivers.Add(EO31);
            drivers.Add(ClC16);

            return drivers;
        }

        //Constructors
        public static Constructor merc = new Constructor
        {
            ConstructorID = 1,
            Name = "Mercedes",
            Country = "Germany",
            Age = 65,
        };
        public static Constructor ferrari = new Constructor
        {
            ConstructorID = 2,
            Name = "Ferrari",
            Country = "Italy",
            Age = 69,
        };
        public static Constructor redBull = new Constructor
        {
            ConstructorID = 3,
            Name = "RedBull Racing",
            Country = "England",
            Age = 14,
        };
        public static Constructor mcLaren = new Constructor
        {
            ConstructorID = 4,
            Name = "McLaren Formula 1",
            Country = "England",
            Age = 53,
        };
        public static Constructor haas = new Constructor
        {
            ConstructorID = 5,
            Name = "Haas",
            Country = "USA",
            Age = 3,
        };
        public static Constructor forceIndia = new Constructor
        {
            ConstructorID = 6,
            Name = "Racing Point Force India",
            Country = "England",
            Age = 10,
        };
        public static Constructor renault = new Constructor
        {
            ConstructorID = 7,
            Name = "Renault Sport",
            Country = "France",
            Age = 42,
        };
        public static Constructor williams = new Constructor
        {
            ConstructorID = 8,
            Name = "Williams",
            Country = "England",
            Age = 42,
        };
        public static Constructor toroRosso = new Constructor
        {
            ConstructorID = 9,
            Name = "Toro Rosso",
            Country = "Italy",
            Age = 13,
        };
        public static Constructor alfaRomeo = new Constructor
        {
            ConstructorID = 10,
            Name = "Alfa Romeo Racing",
            Country = "Italy",
            Age = 69,
        };

        //Drivers
        public static Driver LH44 = new Driver
        {
            DriverID = 1,
            FirstName = "Lewis",
            LastName = "Hamilton",
            Age = 34,
            Country = "England",
            DebutYear = new DateTime(2007, 03, 17)
        };
        public static Driver FA3 = new Driver
        {
            DriverID = 2,
            FirstName = "Fernando",
            LastName = "Alonso",
            Age = 37,
            Country = "Spain",
            DebutYear = new DateTime(2001, 03, 12),
            LastYear = new DateTime(2018, 09, 21)
        };
        public static Driver SV05 = new Driver
        {
            DriverID = 3,
            FirstName = "Sebastian",
            LastName = "Vettel",
            Age = 31,
            Country = "Germany",
            DebutYear = new DateTime(2007, 06, 15)
        };
        public static Driver DR3 = new Driver
        {
            DriverID = 4,
            FirstName = "Daniel",
            LastName = "Ricciardo",
            Age = 29,
            Country = "Australia",
            DebutYear = new DateTime(2011, 07, 21)
        };
        public static Driver KMAG = new Driver
        {
            DriverID = 5,
            FirstName = "Kevin",
            LastName = "Magnussen",
            Age = 26,
            Country = "Denmark",
            DebutYear = new DateTime(2014, 03, 16)
        };
        public static Driver FM19 = new Driver
        {
            DriverID = 6,
            FirstName = "Felipe",
            LastName = "Massa",
            Age = 37,
            Country = "Brazil",
            DebutYear = new DateTime(2002, 03, 18),
            LastYear = new DateTime(2017, 11, 26)
        };
        public static Driver EO31 = new Driver
        {
            FirstName = "Estaban",
            LastName = "Ocon",
            Age = 22,
            Country = "France",
            DebutYear = new DateTime(2016, 05, 21)
        };
        public static Driver ClC16 = new Driver
        {
            FirstName = "Charles",
            LastName = "LeClerc",
            Age = 21,
            Country = "Monaco",
            DebutYear = new DateTime(2018, 03, 19)
        };

    }
}
