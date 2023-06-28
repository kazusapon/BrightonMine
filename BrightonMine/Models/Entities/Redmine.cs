using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BrightonMine.Models.Entities;

public class Redmine
{
    public int Id { get; set; }

    public string Name { get; set; }

    [Required]
    public string Url { get; set; }

    [Required]
    public string ApiKey { get; set; }

    public ICollection<Project> Projects { get; } = new List<Project>();
}
