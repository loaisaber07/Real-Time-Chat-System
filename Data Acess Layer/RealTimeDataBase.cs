using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public class RealTimeDataBase : IdentityDbContext<User>
    {
        public DbSet<Message> Messages { get; set;}
        public DbSet<UserMessage> UserManagers { get; set;} 
        public DbSet<Group> groups { get; set;} 
        public DbSet<GroupMember> GroupManagers { get; set;}  
        public DbSet<GroupMessage> GroupMessages { get; set;}
        public DbSet<UserFriend> userFriends { get; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {  
            builder.Entity<UserMessage>().HasKey(x => new { x.MessageId, x.SenderId , x.ReciverId });
            builder.Entity<GroupMember>().HasKey(s=> new {s.GroupId, s.UserId}); 
            builder.Entity<GroupMessage>().HasKey(x => new { x.GroupId, x.SenderId , x.MessageId});
            builder.Entity<UserFriend>().HasKey(s=> new {s.SendUser, s.FriendId});


            base.OnModelCreating(builder);
        }
    }
}
