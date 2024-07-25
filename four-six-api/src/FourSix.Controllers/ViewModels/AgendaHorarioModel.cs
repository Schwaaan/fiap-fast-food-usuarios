namespace FourSix.Controllers.ViewModels
{
    public class AgendaHorarioModel
    {
        public AgendaHorarioModel(string hora, string status)
        {
            Hora = hora;
            Status = status;
        }

        public string Hora { get; }
        public string Status { get; }
    }
}
