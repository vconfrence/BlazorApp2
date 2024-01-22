using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.HubModels;

public  class PeriodEndingDateModel
{

    public PeriodEndingDateModel() { }

    public int PeriodIndex { get; set; }
    public DateTime PeriodEndingDate { get; set; }
    public String DateString { get; set; }

}
