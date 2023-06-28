using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightonMine.Models.Entities;

public class Project
{
    public int Id { get; set; }

    public int RedmineId { get; set; }

    public Redmine Redmine { get; set; } = null!;

    public int RedmineProjectId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}

