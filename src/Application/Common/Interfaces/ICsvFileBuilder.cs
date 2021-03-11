using APIService.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace APIService.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
