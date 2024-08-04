using System;

namespace Saru.Todo.Entities;

public interface IBaseEntity
{
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
}