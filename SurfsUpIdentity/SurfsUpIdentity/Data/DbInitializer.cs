using SurfsUpIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfsUpIdentity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var citys = new City[]
            {
                new City {CityName = "Odense NV", PostalCode = 5200},
                new City {CityName = "Odense S", PostalCode = 5100},
                new City {CityName = "Odense C", PostalCode = 9999},
                new City {CityName = "Kastrup", PostalCode = 2770},
                new City {CityName = "Horsens", PostalCode = 8700},
                new City {CityName = "Middelfart", PostalCode = 5500}
            };

            foreach (City item in citys)
            {
                context.Add(item);
            }
            context.SaveChanges();

            var users = new User[]
            {
                new User {UserName = "Mortlas", FirstName = "Morten", LastName = "Birkholm",
                    Email = "Mortlas@mail.dk", PhoneNumber = "12345678", IsAdmin = true, IsPremium = true,
                    PasswordHash = "1234", CityId = citys.Single( i => i.PostalCode == 8700).CityId },

                new User {UserName = "Beve", FirstName = "Brian", LastName = "Vith",
                    Email = "Brian@mail.dk", PhoneNumber = "87654321", IsAdmin = true, IsPremium = true,
                    PasswordHash= "1234", CityId = citys.Single( i => i.PostalCode == 2770).CityId },

                new User {UserName = "Miavmis", FirstName = "Maiken", LastName = "Scheffmann",
                    Email = "mismis@mail.dk", PhoneNumber = "11223344", IsAdmin = true, IsPremium = true,
                    PasswordHash = "1234", CityId = citys.Single( i => i.PostalCode == 5500).CityId }
            };


            foreach (User item in users)
            {
                context.Add(item);
            }
            context.SaveChanges();


            var equipments = new Equipment[]
            {
                new Equipment { BoardType = Enums.Type.Surfboard, Condition = Enums.Conditions.God,
                    Price = 250, Deposit = 1200, Description = "lækkert board!",
                    UserId =  users.Single(x => x.UserName == "Mortlas").Id },

                new Equipment { BoardType = Enums.Type.Kitesurf, Condition = Enums.Conditions.God,
                    Price = 200, Deposit = 1000, Description = "fint board!",
                    UserId = (users.Single(x => x.UserName == "Beve").Id).ToString()}
                 };

            foreach (Equipment item in equipments)
            {
                context.Add(item);
            }
            context.SaveChanges();

            var pictures = new Picture[]
            {
                new Picture { PicturePath = "testPath",
                    EquipmentId = equipments.Single(x => x.BoardType == Enums.Type.Surfboard).EquipmentId },

                new Picture { PicturePath = "testPath2",
                    EquipmentId = equipments.Single(x => x.BoardType == Enums.Type.Kitesurf).EquipmentId }
            };

            foreach (Picture item in pictures)
            {
                context.Add(item);
            }
            context.SaveChanges();

            var rentings = new Renting[]
            {
                new Renting {Date = DateTime.Now,
                    EquipmentId = equipments.Single(x => x.BoardType == Enums.Type.Kitesurf).EquipmentId,
                    UserId = users.Single(x => x.UserName == "Miavmis").Id },
            };

            foreach (Renting item in rentings)
            {
                context.Add(item);
            }
            context.SaveChanges();
            // ****** SurfSpots *******

            if (context.SurfSpots.Any())
            {
             return;   
            }
            var spots = new SurfSpot[]
            {
                new SurfSpot {SpotName = "Klitmøller", Latitude = "57.0401", Longitude = "8.4933",
                    PostCode = 7700, City = "Thisted", ImagePath = "Klitmoeller.jpeg"},
                new SurfSpot {SpotName = "Agger", Latitude = "56.7806", Longitude = "8.2534",
                    PostCode = 7770, City = "Vestervig", ImagePath = "Agger.jpeg"}
            };

            foreach (SurfSpot item in spots)
            {
                context.Add(item);
            }
            context.SaveChanges();

        }
    }
}
