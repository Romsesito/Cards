using Cards.Models;


namespace Cards.Services
{
    public interface Servicio
    {
        public Task<List<Carta>>GetCartas();
    }
}
