﻿using AwesomeNetwork.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AwesomeNetwork.Configs;

namespace AwesomeNetwork.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration<Friend>(new FriendConfiguration());
            builder.ApplyConfiguration<Message>(new MessageConfuiguration());
        }
    }
}
