namespace FourSix.Controllers.Adapters.Agendas.AlteraAgenda
{ 
    public interface IAlteraAgendaAdapter
    {
        Task<AlteraAgendaResponse> Alterar(Guid id, AlteraAgendaRequest agenda);
    }
}
