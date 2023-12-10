using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subjects
    {
        public long SubjectId { get; set; }
        public long ProfessorId { get; set; }
        public long StudentId { get; set; }
        public string? SubjectCode { get; set; }
        public string? Units { get; set; }
    }
}
