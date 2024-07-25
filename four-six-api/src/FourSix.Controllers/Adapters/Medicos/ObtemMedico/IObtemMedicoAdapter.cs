namespace FourSix.Controllers.Adapters.Medicos.ObtemMedico
{
    public interface IObtemMedicoAdapter
    {
        Task<ObtemMedicoResponse> Obter(string crm);
    }
}
