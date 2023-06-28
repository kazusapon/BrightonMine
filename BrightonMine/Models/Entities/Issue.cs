using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightonMine.Models.Entities;

public class Issue
{
    public int Id { get; set; }

    public int RedmineIssueId { get; set; }

    public string Subject { get; set; }

    public int ProjectId { get; set; }

    public Project Project { get; set; }
    
    public int TrackerId { get; set; }

    public Tracker Tracker { get; set; }

    public int MembershipId { get; set; }

    public Membership Membership { get; set; }

    public int VersionId { get; set; }

    public TicketVersion ticketVersion { get; set; }
}
