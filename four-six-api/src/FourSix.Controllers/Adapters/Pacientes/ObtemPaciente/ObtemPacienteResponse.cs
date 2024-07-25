using FourSix.Controllers.ViewModels;

namespace FourSix.Controllers.Adapters.Pacientes.ObtemPaciente
{
    public class ObtemPacienteResponse
    {
        public ObtemPacienteResponse(PacienteModel pacienteModel) => this.Paciente = pacienteModel;
        public PacienteModel Paciente { get; }
    }
}
