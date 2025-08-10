
using System.Text.Json;
using Libraly;

Products? products = JsonSerializer.Deserialize<Products>(File.ReadAllText("Assets/Products.json"));

Accounts? accounts = JsonSerializer.Deserialize<Accounts>(File.ReadAllText("Assets/Accounts.json"));

Discounts? discounts = JsonSerializer.Deserialize<Discounts>(File.ReadAllText("Assets/Discounts.json"));