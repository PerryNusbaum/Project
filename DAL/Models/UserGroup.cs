using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            GroupPermissions = new HashSet<GroupPermission>();
            UserGroupMemberships = new HashSet<UserGroupMembership>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
        public virtual ICollection<UserGroupMembership> UserGroupMemberships { get; set; }
    }
}
