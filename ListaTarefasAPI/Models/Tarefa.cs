namespace ListaTarefasAPI.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }
        public string Descricao { get; set; }
        public bool concluida { get; set; }
        public int TipoTarefaId { get; set; }
        public TipoTarefa? TipoTarefa { get; set; }
    }
}
