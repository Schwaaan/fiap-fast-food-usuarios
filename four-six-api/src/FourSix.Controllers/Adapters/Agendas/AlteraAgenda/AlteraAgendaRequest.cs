using Swashbuckle.AspNetCore.Annotations;

namespace FourSix.Controllers.Adapters.Agendas.AlteraAgenda
{
    [SwaggerSchema(Required = new[] { "dataAgenda", "medicoId" })]
    public class AlteraAgendaRequest
    {
        /// <summary>
        /// Data do Horario
        /// </summary>
        /// <example>2023-10-24T18:00</example>
        [SwaggerSchema(Nullable = false)]
        public DateTime DataAgenda { get; set; }
        /// <summary>
        /// Horários
        /// </summary>
        /// <example>2023-10-24T18:00</example>
        [SwaggerSchema(Nullable = false)]
        public ICollection<Tuple<DateTime, DateTime>> Horarios { get; set; }
    }

    public class AlteraAgendaHorarioRequest
    {
        /// <summary>
        /// Horário Inicial
        /// </summary>
        /// <example>2023-10-24T18:00</example>
        [SwaggerSchema(Nullable = false)]
        public DateTime HoraInicio { get; set; }
        /// <summary>
        /// Horário Final
        /// </summary>
        /// <example>2023-10-24T20:00</example>
        [SwaggerSchema(Nullable = false)]
        public DateTime HoraFim { get; set; }
    }
}
