using Swashbuckle.AspNetCore.Annotations;

namespace FourSix.Controllers.Adapters.Agendas.NovaAgenda
{
    [SwaggerSchema(Required = new[] { "dataAgenda", "medicoId" })]
    public class NovaAgendaRequest
    {
        /// <summary>
        /// Data do Horario
        /// </summary>
        /// <example>2023-10-24T18:00</example>
        [SwaggerSchema(Nullable = false)]
        public DateTime DataAgenda { get; set; }

        /// <summary>
        /// Id do Cliente
        /// </summary>
        /// <example>717b2fb9-4bbe-4a8c-8574-7808cd652e0b</example>
        [SwaggerSchema(Nullable = false)]
        public Guid MedicoId { get; set; }
    }
}
