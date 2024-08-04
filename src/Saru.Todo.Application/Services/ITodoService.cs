using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saru.Todo.Dtos;
using Volo.Abp.Application.Services;

namespace Saru.Todo.Services
{
    public interface ITodoService: IApplicationService
    {
        Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(CreateItemDto? item);
        Task DeleteAsync(Guid id);
    }
}
