using System.Text.Json;

int costofyourship;
int costofenemyship;

HttpClient client1 = new();

client1.BaseAddress = new("https://swapi.py4e.com/api/starships/");

HttpResponseMessage response1 = client1.GetAsync("9/").Result;
string playership = (response1.Content.ReadAsStringAsync().Result);
Ship_1 S1 = JsonSerializer.Deserialize<Ship_1>(playership);


costofyourship = ParseCost(S1.cost_in_credits);

Console.WriteLine(costofyourship + " : " + S1.name);
Console.ReadLine();

static int ParseCost(string cost)
{
    bool lyckad = false;
    int resultat = 0;

    while (!lyckad)
    {
        lyckad = int.TryParse(cost, out resultat);
    }

    return resultat;
}


  
public class Ship_1
{
    public string name { get; set; }
    public string cost_in_credits { get; set; }
}
