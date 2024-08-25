using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saru.Todo.Dtos;
using Saru.Todo.Entities;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Saru.Todo.Services
{
    public class TodoService : ApplicationService, ITodoService
    {
        private readonly IRepository<TodoItem, Guid> _todoItemRepository;

        public TodoService(IRepository<TodoItem, Guid> todoItemRepository) => _todoItemRepository = todoItemRepository;

        public async Task<List<TodoItemDto>> GetListAsync()
        {
            var listofTodos = await _todoItemRepository.GetListAsync(t => !t.IsDeleted);

            var mappedList = listofTodos.Select(t => new TodoItemDto
            {
                Id = t.Id,
                Content = t.Content,
                IsDone = t.IsDone,
                Created = t.CreationTime
            }).ToList();

            return mappedList.Count != 0 ? mappedList : new List<TodoItemDto>();
        }

        public async Task<TodoItemDto> CreateAsync(CreateItemDto? item)
        {
            if (item is null)
                throw new Exception("Your request is null...");


            var createdTodo = await _todoItemRepository.InsertAsync(entity: new TodoItem
            {
                Content = item.Content,
                IsDone = item.IsDone
            }, autoSave: true);

            TodoItemDto mappedTodo = new()
            {
                Content = createdTodo.Content,
                IsDone = createdTodo.IsDone,
                Created = createdTodo.CreationTime
            };

            return mappedTodo;
        }


        public async Task SoftDeleteAsync(Guid id) => await _todoItemRepository.DeleteAsync(id: id, autoSave: true);

    }
}
