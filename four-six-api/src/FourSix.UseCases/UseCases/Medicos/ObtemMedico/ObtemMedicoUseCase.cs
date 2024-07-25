using FourSix.Domain.Entities.MedicoAggregate;
using FourSix.UseCases.Interfaces;

namespace FourSix.UseCases.UseCases.Medicos.ObtemMedico
{
    public class ObtemMedicoUseCase : IObtemMedicoUseCase
    {
        private readonly IMedicoRepository _clienteRepository;

        public ObtemMedicoUseCase(IMedicoRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<Medico> Execute(string crm) => ObterCliente(crm);

        private async Task<Medico> ObterCliente(string crm)
        {
            var cliente = _clienteRepository
                .Listar(q => q.Crm == crm).FirstOrDefault();

            if (cliente == null)
            {
                throw new Exception("Medico não encontrado");
            }

            return cliente;
        }
    }
}