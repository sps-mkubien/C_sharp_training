//var people = new[]
//{
//     new { Name = "Jan", City = "Praha", Age = 25 },
//     new { Name = "Marie", City = "Brno", Age = 30 },
//     new { Name = "Petr", City = "Praha", Age = 35 },
//     new { Name = "Eva", City = "Brno", Age = 28 },
//     new { Name = "Tomáš", City = "Ostrava", Age = 32 },
//     new { Name = "Lucie", City = "Praha", Age = 27 }
//};

//var byAgeCategory = people.GroupBy(x => x.Age < 30 ? "<30" : "30+");

//// seskupit podle veku na <30 a 30+
//// a vypisovat jmena lidi podle skupin

//foreach (var ageGroup in byAgeCategory)
//{
//    var group_name = ageGroup.Key;
//    var group_count = ageGroup.Count();

//    Console.WriteLine($"group {group_name}, count: {group_count}");

//    foreach (var person in ageGroup)
//    {
//        Console.WriteLine($"person.Name) - {person.Age}");
//    }

//    Console.WriteLine();
//}
