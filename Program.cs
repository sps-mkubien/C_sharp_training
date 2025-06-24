var cars = new[]
{
    new { Brand = "Škoda", Model = "Octavia", Year = 2020, PricePerDay = 800, Available = true },
    new { Brand = "Škoda", Model = "Fabia", Year = 2021, PricePerDay = 600, Available = true },
    new { Brand = "VW", Model = "Golf", Year = 2019, PricePerDay = 900, Available = false },
    new { Brand = "VW", Model = "Passat", Year = 2020, PricePerDay = 1200, Available = true },
    new { Brand = "BMW", Model = "3 Series", Year = 2021, PricePerDay = 1500, Available = true },
    new { Brand = "BMW", Model = "X3", Year = 2020, PricePerDay = 2000, Available = false }
};

// 1. Počet aut podle značky

// 2. Dostupná auta seřazená podle ceny

// 3. Průměrná cena podle značky


var carsByBrand = cars.GroupBy(x => x.Brand);

foreach (var carGroup in carsByBrand)
{
    var groupName = carGroup.Key;
    var groupCount = carGroup.Count();
    var averagePrice = carGroup.Average(x => x.PricePerDay);
    var availableCars = carGroup.Where(x => x.Available).OrderBy(x => x.PricePerDay);

    Console.WriteLine($"brand {groupName}, count: {groupCount}, aver: {averagePrice}");

    foreach (var car in availableCars)
    {
        Console.WriteLine($"available car: {car.Model}, price: {car.PricePerDay}");
    }
    Console.WriteLine();
}