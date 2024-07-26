using FourSix.Controllers.Adapters.Agendas.AlteraAgenda;
using FourSix.Controllers.Adapters.Agendas.NovaAgenda;
using FourSix.Controllers.Adapters.Medicos.ObtemMedico;
using FourSix.Controllers.Adapters.Pacientes.ObtemPaciente;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics.CodeAnalysis;

namespace FourSix.WebApi.Modules
{
    [ExcludeFromCodeCoverage]
    public static class RoutesExtensions
    {
        public static void AddRoutesMaps(this IEndpointRouteBuilder app)
        {
            #region [ Pacientes ]

            app.MapGet("pacientes/{cpf}",
            [SwaggerOperation(Summary = "Obtém paciente")]
            ([SwaggerParameter("CPF do paciente")] string cpf, IObtemPacienteAdapter adapter) =>
            {
                return adapter.Obter(cpf);
            }).WithTags("Pacientes");
            
            #endregion

            #region [ Medicos ]

            app.MapGet("medicos/{crm}",
            [SwaggerOperation(Summary = "Obtém Medico")]
            ([SwaggerParameter("CRM do cliente")] string crm, IObtemMedicoAdapter adapter) =>
            {
                return adapter.Obter(crm);
            }).WithTags("Medicos");

            #endregion

            #region [ Agendas ]

            app.MapPost("agendas/anonymous",
            [SwaggerOperation(Summary = "Cria nova agenda")]
            ([FromBody] NovaAgendaRequest request, INovaAgendaAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Agendas").AllowAnonymous();

            app.MapPost("agendas",
            [SwaggerOperation(Summary = "Cria nova agenda")]
            ([FromBody] NovaAgendaRequest request, INovaAgendaAdapter adapter) =>
            {
                return adapter.Inserir(request);
            }).WithTags("Agendas").RequireAuthorization();

            app.MapPut("agendas/{id}",
            [SwaggerOperation(Summary = "Altera agenda")]
            ([SwaggerParameter("Id da agenda")] Guid id, [FromBody] AlteraAgendaRequest request, IAlteraAgendaAdapter adapter) =>
            {
                return adapter.Alterar(id, request);
            }).WithTags("Agendas").RequireAuthorization();

            #endregion
        }
    }
}
