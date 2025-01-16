// using System.Text.Json;

// int costofyourship;
// int costofenemyship;

// HttpClient client1 = new();
// HttpClient client2 = new();

// client1.BaseAddress = new("https://swapi.py4e.com/api/starships/");
// client2.BaseAddress = new("https://swapi.py4e.com/api/starships/");

// // HttpResponseMessage response1 = client1.GetAsync("9/").Result;
// // string playership = (response1.Content.ReadAsStringAsync().Result);
// // Ship_1 S1 = JsonSerializer.Deserialize<Ship_1>(playership);

// HttpResponseMessage response2 = client2.GetAsync("10/").Result;
// string Enemyship = (response2.Content.ReadAsStringAsync().Result);
// Ship_2 S2 = JsonSerializer.Deserialize<Ship_2>(Enemyship);

// Console.WriteLine(S2.cost_in_credits + "  Before parse");

// // costofyourship = ParseCost(S1.cost_in_credits);
// // costofenemyship = ParseCost(S2.cost_in_credits);

// // Console.WriteLine(costofenemyship + " : " + S1.name);
// Console.WriteLine(costofyourship + " : " + S2.name);
// if (costofenemyship > costofyourship)
// {
//     Console.WriteLine("Enemy wins");
// }
// else
// {
//     Console.WriteLine("You win");
// }

// // static int ParseCost(string cost)
// // {
// //     bool lyckad = false;
// //     int resultat = 0;

// //     while (!lyckad)
// //     {
// //         lyckad = int.TryParse(cost, out resultat);
// //     }

// //     return resultat;
// // }



