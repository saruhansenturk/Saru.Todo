using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Saru.Todo.Dtos;
using Saru.Todo.Localization;
using Saru.Todo.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace Saru.Todo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoController : AbpControllerBase
{
    protected TodoController(ITodoService todoService)
    {
        LocalizationResource = typeof(TodoResource);
    }

    //[HttpGet]
    //public async Task<IActionResult> GetAllTodoItemList()
    //{
    //    var listOfTodos = await _todoService.GetListAsync();

    //    return Ok(listOfTodos);
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateTodoItem(CreateItemDto request)
    //{
    //    var createdObject = await _todoService.CreateAsync(request);

    //    return Ok(createdObject);
    //}

    //[HttpGet]
    //public async Task<IActionResult> DeleteTodoItem(Guid id)
    //{
    //    await _todoService.DeleteAsync(id);

    //    return Ok();
    //}

}
