namespace ListaTarefasAPI.Modelos
{
    public class Tarefa
    {
        public int Tarefa { get; set; }
        public string Descricao { get; set; }
        public bool concluida { get; set; }
        public int Tipotarefaid { get; set; }
        public TipoTarefa TipoTarefa { get; set; }
    }
}
