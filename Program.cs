using System.Text.Json;

using var client = new HttpClient();
client.BaseAddress = new Uri ("https://gameinfo.albiononline.com/api/gameinfo")

    Console.Write("spielername");
string name = Console.ReadLine ();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("ungueltiger Name.");
    return;
}
var search = await client.GetAsync($"/search?q={name}");
if (!search.IsSuccessStatusCode)
{
    Console.WriteLine("Fehler bei der Suche");
    return;
}