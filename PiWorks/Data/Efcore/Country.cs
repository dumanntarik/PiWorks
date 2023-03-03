using System;
using System.Collections.Generic;

namespace PiWorks.Data.Efcore;

public partial class Country
{
    public int Id { get; set; }

    public string? Country1 { get; set; }

    public string? Date { get; set; }

    public int? DailyVaccinations { get; set; }

    public string? Vaccines { get; set; }
}
