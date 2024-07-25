using FourSix.Domain.Entities.PacienteAggregate;
using FourSix.UseCases.Interfaces;
using FourSix.UseCases.UseCases.Pacientes.ObtemPaciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSix.UseCases.UseCases.Pacientes.ObtemPaciente
{
    public class ObtemPacienteUseCase : IObtemPacienteUseCase
    {
        private readonly IPacienteRepository _clienteRepository;

        public ObtemPacienteUseCase(IPacienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<Paciente> Execute(string cpf) => ObterPaciente(cpf);

        private async Task<Paciente> ObterPaciente(string cpf)
        {
            var cliente = _clienteRepository
                .Listar(q => q.Cpf == cpf).FirstOrDefault();

            if (cliente == null)
            {
                throw new Exception("Paciente não encontrado");
            }

            return cliente;
        }
    }
}