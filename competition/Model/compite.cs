using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace competition.Model;

public class compite
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Attendences { get; set; }
    public string Tags { get; set; }
}
