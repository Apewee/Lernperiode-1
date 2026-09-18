using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient client = new HttpClient();
        string baseUrl = "https://gameinfo-ams.albiononline.com/api/gameinfo";

        while (true)
        {
            Console.Write("Spielername eingeben (oder 'exit' zum Beenden): ");
            string playerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                continue;
            }

            if (playerName.ToLower() == "exit")
            {
                break;
            }

            string searchUrl = $"{baseUrl}/search?q={Uri.EscapeDataString(playerName)}";
            string searchResponse = await client.GetStringAsync(searchUrl);

            using JsonDocument searchDoc = JsonDocument.Parse(searchResponse);
            JsonElement players = searchDoc.RootElement.GetProperty("players");

            if (players.GetArrayLength() == 0)
            {
                Console.WriteLine("Kein Spieler gefunden.");
                Console.WriteLine();
                continue;
            }

            JsonElement firstPlayer = players[0];
            string playerNameResult = firstPlayer.GetProperty("Name").GetString();
            long killFame = firstPlayer.GetProperty("KillFame").GetInt64();

            Console.WriteLine($"Spieler: {playerNameResult}");
            Console.WriteLine($"Kill Fame: {killFame}");
            Console.WriteLine();
        }
    }
}
