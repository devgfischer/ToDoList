namespace ToDoList.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }
        public bool Apagado { get; set; }
    }
}