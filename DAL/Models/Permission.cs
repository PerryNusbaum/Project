using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Permission
    {
        public Permission()
        {
            GroupPermissions = new HashSet<GroupPermission>();
            UserPermissions = new HashSet<UserPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
