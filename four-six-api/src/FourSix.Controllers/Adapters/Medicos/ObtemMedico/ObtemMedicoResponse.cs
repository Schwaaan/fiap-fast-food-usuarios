using FourSix.Controllers.ViewModels;

namespace FourSix.Controllers.Adapters.Medicos.ObtemMedico
{
    public class ObtemMedicoResponse
    {
        public ObtemMedicoResponse(MedicoModel clienteModel) => this.Cliente = clienteModel;
        public MedicoModel Cliente { get; }
    }
}
