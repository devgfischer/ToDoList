<div align="center">
    <h2><strong>Projeto TODO APP | ToDoList</strong></h2>
</div>

## Resumo do Projeto:

Consiste na criação de uma aplicação para gerenciar uma lista de tarefas - Cadastrar - Buscar - Atualizar - Excluir.

Com ela, criei uma API REST (Swagger) utilizando C# e .NET 6 com Dapper, também utilizei Microsoft SQL Server como Banco de Dados.

<div align="center">
    <img src="https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white">
     <img src="https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white">
    <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
     <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">
    <img src="https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=Swagger&logoColor=white">
    <img src="https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white">
</div>

A WEB API vai expor ```endpoints``` que permitem consultar e realizar as operações para visualizar, incluir, alterar e excluir informações da Tarefas.

<strong>OS ENDPOINTS SÃO:</strong>

- ```/api/Tarefas/GetTarefas```: Puxa todas as Tarefas cadastradas em ordem ASC;
- ```/api/Tarefas/Tarefa/{id}```: Puxa um ID relacionada a tal Tarefa;
- ```/api/Tarefas/GetTodosAndCount```: Puxa Todas as Tarefas até mesmo as deletadas.
- ```/api/Tarefas/Save```: Salva/Cadastra uma Tarefa; 
- ```/api/Tarefas/UpadteTodosStatus```: Atualiza o Status de uma Tarefa.
- ```/api/Tarefas/Delete```: Deleta uma Tarefa, mas deixa ela como "ausente", podendo assim filtrar ela para determinada consulta.

## :hammer: Sua funcionalidade:

- ```Cadastro de Tarefa```: É possível cadastrar quantas tarefas você desejar, junto de uma data no qual ela deve ser concluída

- ```Buscar e fazer atualizações de Tarefa```: Podemos filtrar e atualizar as Tarefas, podendo atualizá-las se a mesma ja foi conclúida.

- ```Exclusão```: Ela deixa a tarefa como "Ausente" mas não exclui, isso para pertmir que a tal Tarefa possa ser filtrada futuramente caso tenha sido concluída ou não.

- ```Lista Ordenada```: Ordena as Tarefas por Ordem ASC
 
## 📁 Acesso ao Projeto:

```Baixe o arquivo .zip ou abra diretamente na IDE Visual Studio```.

## 🛠️ Abrir e rodar o projeto:

- ```Configurar Banco de Dados```: Configure o Banco de Dados SQL ou Qualquer outro banco de sua preferência em appsettings.json.

Basta compilar o código uma vez, para que todas as dependências sejam instaladas corretamente.

Após isso, abra seu SGBD e crie seu Banco de Dados com base na API.
