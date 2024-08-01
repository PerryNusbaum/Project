using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UserGroupMemberships = new HashSet<UserGroupMembership>();
            UserPermissions = new HashSet<UserPermission>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public string PasswordHash { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserGroupMembership> UserGroupMemberships { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
