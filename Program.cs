using System.Net.Http.Json;
using Model;


string line = "";
int id = 0;

do
{
    try
    {
        Console.Write($"Enter personal ID (Q for end): ");
        line = Console.ReadLine();

        if (line != "Q" && line != "q")
        {
            id = int.Parse(line);

            HttpClient client = new();
            client.BaseAddress = new Uri("https://localhost:7047");

            Person person = await client.GetFromJsonAsync<Person>($"/person/{id}");
            if (person != null)
            {
                Console.WriteLine($"Person ID: {person.Id}, Name: {person.FirstName} {person.LastName}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }
        else return;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid ID format. Please enter a valid integer.");
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
        return;
    }

}
while (line != "Q");


//var homeText = await client.GetStringAsync("/");
//Console.WriteLine($"result: {homeText}");

//var person = await client.GetFromJsonAsync<Person>("/person/10");
//Console.WriteLine($"person id 10: {person.LastName}");

//Console.ReadKey();