using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Professor
    {
        public long ProfessorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
