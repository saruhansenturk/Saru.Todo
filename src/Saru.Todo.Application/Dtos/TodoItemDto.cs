using System;

namespace Saru.Todo.Dtos;

public class TodoItemDto
{
    public Guid Id { get; set; }
    public string Content { get; set; }
    public bool IsDone { get; set; }
    public DateTime Created { get; set; }
}