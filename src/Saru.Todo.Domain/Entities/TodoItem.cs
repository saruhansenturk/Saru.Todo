using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Saru.Todo.Entities
{
    public class TodoItem: BasicAggregateRoot<Guid>, IBaseEntity
    {
        public string Content { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
        public bool IsDeleted { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
