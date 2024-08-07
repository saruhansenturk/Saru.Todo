using System;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Saru.Todo.Entities
{
    [Audited]
    public class TodoItem: FullAuditedAggregateRoot<Guid>
    {
        public string Content { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
    }
}
