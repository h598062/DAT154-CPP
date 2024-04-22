﻿using System;
using System.Collections.Generic;

namespace Voluntary_Task_Solution.Models;

public partial class Grade
{
    public int Studentid { get; set; }

    public string Coursecode { get; set; } = null!;

    public string Grade1 { get; set; } = null!;

    public virtual Course CoursecodeNavigation { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
