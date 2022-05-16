using Dapper;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private DbSession _db;
        public TarefaRepository(DbSession dbSession)
        {
            _db = dbSession;
        }
        public async Task<List<Tarefa>> GetTarefasAsync()
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Tarefas WHERE [Status] = 0 AND [Apagado] = 0 ORDER BY Date ASC";
                List<Tarefa> tarefas = (await conn.QueryAsync<Tarefa>(sql: query)).ToList();
                return tarefas;
            }
        }
        public async Task<Tarefa> GetTarefaByIdAsync(int id)
        {
            using (var conn = _db.Connection)
            {
                string query = "SELECT * FROM Tarefas WHERE Id = @id";
                Tarefa tarefa = await conn.QueryFirstOrDefaultAsync<Tarefa>
                    (sql: query, param: new { id });
                return tarefa;
            }
        }
        public async Task<TarefaContainer> GetTarefasEContadorAsync()
        {
            using (var conn = _db.Connection)
            {
                string query =
                    @"SELECT COUNT(*) FROM Tarefas
    	          SELECT * FROM Tarefas";
                var reader = await conn.QueryMultipleAsync(sql: query);
                return new TarefaContainer
                {
                    Contador = (await reader.ReadAsync<int>()).FirstOrDefault(),
                    Tarefas = (await reader.ReadAsync<Tarefa>()).ToList()
                };
            }
        }
        public async Task<int> SaveAsync(Tarefa novaTarefa)
        {
            using (var conn = _db.Connection)
            {
                string command = @"INSERT INTO Tarefas(Descricao, Date, Status, Apagado)
    		VALUES(@Descricao, @Date, @Status, @Apagado)";
                var result = await conn.ExecuteAsync(sql: command, param: novaTarefa);
                return result;
            }
        }
        public async Task<int> UpdateTarefaStatusAsync(Tarefa atualizaTarefa)
        {
            using (var conn = _db.Connection)
            {
                string command = @"
    		     UPDATE Tarefas SET Status = @Status WHERE Id = @Id";
                var result = await conn.ExecuteAsync(sql: command, param: atualizaTarefa);
                return result;
            }
        }
        public async Task<int> DeleteAsync(Tarefa deleteTarefa)
        {
            using (var conn = _db.Connection)
            {
                string command = @"
    		     UPDATE Tarefas SET Apagado = @Apagado WHERE Id = @Id";
                var result = await conn.ExecuteAsync(sql: command, param: deleteTarefa);
                return result;
            }
        }
    }
}
