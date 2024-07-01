using Cards.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Cards.Services
{
    public class ServicioS : Servicio
    {
        private string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";   
        public async Task<List<Carta>> GetCartas()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            JsonNode cards = nodos["cards"];


            var cartas = JsonSerializer.Deserialize<List<Carta>>(cards.ToString());
            return cartas;
        }
    }
}
