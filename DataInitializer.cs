using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public class DataInitializer : CreateDatabaseIfNotExists<CitiesContext>
    {
        protected override void Seed(CitiesContext context)
        {
            context.Cities.AddRange(new List<City>
            {
                new City
                {
                    Name = "Nur-Sultan",
                    CityCode = 7172,
                },
                new City
                {
                    Name = "Semipalatinsk",
                    CityCode = 7222,
                },
                new City
                {
                    Name = "Ust-Kamenogorsk",
                    CityCode = 7232,
                }
            });
            context.SaveChanges();
        }

    }
}
