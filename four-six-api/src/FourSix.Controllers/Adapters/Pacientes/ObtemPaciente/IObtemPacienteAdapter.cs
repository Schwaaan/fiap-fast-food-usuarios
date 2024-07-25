
namespace FourSix.Controllers.Adapters.Pacientes.ObtemPaciente
{
    public interface IObtemPacienteAdapter
    {
        Task<ObtemPacienteResponse> Obter(string cpf);
    }
}
