using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaRepository _tarefaRepo;
        public TarefasController(ITarefaRepository tarefaRepo)
        {
            _tarefaRepo = tarefaRepo;
        }
        [HttpGet]
        [Route("GetTarefas")]
        public async Task<IActionResult> GetTarefasAsync()
        {
            var result = await _tarefaRepo.GetTarefasAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("Tarefa/{id}")]
        public async Task<IActionResult> GetTodoItemByIdAsync(int id)
        {
            var tarefa = await _tarefaRepo.GetTarefaByIdAsync(id);
            return Ok(tarefa);
        }
        [HttpGet]
        [Route("GetTodosAndCount")]
        public async Task<IActionResult> GetTodosAndCountAsync()
        {
            var resultado = await _tarefaRepo.GetTarefasEContadorAsync();
            return Ok(resultado);
        }
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> SaveAsync(Tarefa novaTarefa)
        {
            var result = await _tarefaRepo.SaveAsync(novaTarefa);
            return Ok(result);
        }
        [HttpPost]
        [Route("UpdateTodoStatus")]
        public async Task<IActionResult> UpdateTodoStatusAsync(Tarefa atualizaTarefa)
        {
            var result = await _tarefaRepo.UpdateTarefaStatusAsync(atualizaTarefa);
            return Ok(result);
        }
        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> DeleteAsync(Tarefa deleteTarefa)
        {
            var result = await _tarefaRepo.DeleteAsync(deleteTarefa);
            return Ok(result);
        }
    }
}
