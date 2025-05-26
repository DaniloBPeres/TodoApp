using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaskModel : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public bool Completed { get; set; } = false;
    }
}
