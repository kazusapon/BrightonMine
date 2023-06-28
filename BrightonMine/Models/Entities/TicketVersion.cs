using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightonMine.Models.Entities;

public class TicketVersion
{
    public int Id { get; set; }

    public int VersionId { get; set; }

    public string Name { get; set; }

    public int ProjectId { get; set; }

    public Project Project { get; set; }
}
