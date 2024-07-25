namespace FourSix.Controllers.Adapters.Agendas.NovaAgenda
{ 
    public interface INovaAgendaAdapter
    {
        Task<NovaAgendaResponse> Inserir(NovaAgendaRequest pedido);
    }
}
