using FourSix.Controllers.Adapters.Pacientes.ObtemPaciente;
using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Pacientes.ObtemPaciente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Pacientes.ObtemPaciente
{
    public class ObtemPacienteAdapter : IObtemPacienteAdapter
    {
        private readonly IObtemPacienteUseCase _useCase;

        public ObtemPacienteAdapter(IObtemPacienteUseCase useCase)
        {
            this._useCase = useCase;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ObtemPacienteResponse))]
        public async Task<ObtemPacienteResponse> Obter(string cpf)
        {
            var model = new PacienteModel(await _useCase.Execute(cpf));

            return new ObtemPacienteResponse(model);
        }
    }
}
