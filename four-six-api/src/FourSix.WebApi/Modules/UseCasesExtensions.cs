using FourSix.UseCases.UseCases.Agendas.NovaAgenda;
using FourSix.UseCases.UseCases.Medicos.ObtemMedico;
using FourSix.UseCases.UseCases.Pacientes.ObtemPaciente;
using System.Diagnostics.CodeAnalysis;

namespace FourSix.WebApi.Modules
{
    [ExcludeFromCodeCoverage]
    public static class UseCasesExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            #region [ Pacientes ]
            services.AddScoped<IObtemPacienteUseCase, ObtemPacienteUseCase>();
            #endregion

            #region [ Medico ]
            services.AddScoped<IObtemMedicoUseCase, ObtemMedicoUseCase>();
            #endregion

            #region [ Pedidos ]
            services.AddScoped<INovaAgendaUseCase, NovaAgendaUseCase>();
            #endregion

            return services;
        }
    }
}
