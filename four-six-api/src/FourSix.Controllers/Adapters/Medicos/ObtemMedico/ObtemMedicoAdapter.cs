using FourSix.Controllers.ViewModels;
using FourSix.UseCases.UseCases.Medicos.ObtemMedico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourSix.Controllers.Adapters.Medicos.ObtemMedico
{
    public class ObtemMedicoAdapter : IObtemMedicoAdapter
    {
        private readonly IObtemMedicoUseCase _useCase;

        public ObtemMedicoAdapter(IObtemMedicoUseCase useCase)
        {
            this._useCase = useCase;
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ObtemMedicoResponse))]
        public async Task<ObtemMedicoResponse> Obter(string cpf)
        {
            var model = new MedicoModel(await _useCase.Execute(cpf));

            return new ObtemMedicoResponse(model);
        }
    }
}
