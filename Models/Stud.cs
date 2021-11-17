using System;
using System.Collections.Generic;

namespace core6App1.Models
{
    public partial class Stud
    {
        public string StudNo { get; set; } = null!;
        public string? StudName { get; set; }
        public string ClassNo { get; set; } = null!;
        public string? ClassNa { get; set; }
        public string? TeaCode { get; set; }
        public string? Email { get; set; }
        public string? TeaName { get; set; }
        public string? DeptId { get; set; }
        public string DeptNo { get; set; } = null!;
        public string? DeptName { get; set; }
        public string? SortName { get; set; }
        public string? ChiefId { get; set; }
        public string? ChiefName { get; set; }
        public string? ProgramName { get; set; }
        public string Sex { get; set; } = null!;
    }
}
