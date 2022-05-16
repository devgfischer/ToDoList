using ToDoList.Models;

namespace ToDoList.Repositories
{
    public interface ITarefaRepository
    {
        Task<List<Tarefa>> GetTarefasAsync();
        Task<Tarefa> GetTarefaByIdAsync(int id);
        Task<TarefaContainer> GetTarefasEContadorAsync();
        Task<int> SaveAsync(Tarefa novaTarefa);
        Task<int> UpdateTarefaStatusAsync(Tarefa atualizaTarefa);
        Task<int> DeleteAsync(Tarefa deleteTarefa);
    }
}
