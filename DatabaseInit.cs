using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DbInit
    {
        public static void DbInitFromJson()
        {
            List<Person> people;
            string file = @"d:\Tmp\C_sharp_training\net2025\data2024.json";

            if (!File.Exists(file))
            {
                //Console.WriteLine($"File {file} does not exist.");
                throw new FileNotFoundException($"File {file} does not exist.");
            }

            people = JsonDataset.LoadData(file);

            Console.WriteLine($"loaded: {people.Count} people");


            PeopleDbContext dbContext = new PeopleDbContext();

            var personCount = dbContext.Persons.Count();

            if (personCount == 0)
            {
                Console.WriteLine("No data in the database, adding data...");

                dbContext.Persons.AddRange(people);   // Add the loaded people to the database
                var changed = dbContext.SaveChanges();   // Save changes to the database

                Console.WriteLine($"saved people count: {changed}");
            }
            else
            {
                Console.WriteLine($"Database already contains {personCount} people.");
            }
        }

    }
}
