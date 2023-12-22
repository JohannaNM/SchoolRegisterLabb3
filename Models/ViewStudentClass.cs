using System;
using System.Collections.Generic;

namespace SchoolRegisterLabb3.Models;

public partial class ViewStudentClass
{
    public string? FullName { get; set; }

    public int? FkclassId { get; set; }

    public int StudentId { get; set; }
}
