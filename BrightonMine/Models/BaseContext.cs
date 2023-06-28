using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BrightonMine.Models.Entities;

namespace BrightonMine.Models;

public class BaseContext : DbContext
{
    public string _connectionString { get; }

    public BaseContext()
    {
        this._connectionString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "App.db");
    }

    public DbSet<Redmine> redmines { get; set; }

    public DbSet<Project> projects { get; set; }

    public DbSet<TicketVersion> ticketVersions { get; set; }

    public DbSet<Tracker> trackers { get; set; }

    public DbSet<Membership> memberships { get; set; }

    public DbSet<Issue> issues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source={ this._connectionString }");
    }
}
