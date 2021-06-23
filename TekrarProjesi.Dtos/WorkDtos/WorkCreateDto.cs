using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarProjesi.Dtos.Interfaces;

namespace TekrarProjesi.Dtos.WorkDtos
{
    public class WorkCreateDto:IDto
    {
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
