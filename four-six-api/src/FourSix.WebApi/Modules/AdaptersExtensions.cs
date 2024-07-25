using FourSix.Controllers.Adapters.Agendas.NovaAgenda;
using FourSix.Controllers.Adapters.Medicos.ObtemMedico;
using FourSix.Controllers.Adapters.Pacientes.ObtemPaciente;
using System.Diagnostics.CodeAnalysis;

namespace FourSix.WebApi.Modules
{
    [ExcludeFromCodeCoverage]
    public static class AdaptersExtensions
    {
        public static IServiceCollection AddAdapters(this IServiceCollection services)
        {
            #region [ Medicos ]
            services.AddScoped<IObtemMedicoAdapter, ObtemMedicoAdapter>();
            #endregion

            #region [ Pacientes ]
            services.AddScoped<IObtemPacienteAdapter, ObtemPacienteAdapter>();
            #endregion

            #region [ Agenda ]
            services.AddScoped<INovaAgendaAdapter, NovaAgendaAdapter>();
            #endregion

            return services;
        }
    }
}
