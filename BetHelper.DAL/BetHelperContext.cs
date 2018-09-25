using BetHelper.DAL.Configurations;
using BetHelper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetHelper.DAL
{
    public class BetHelperContext : DbContext
    {

        public DbSet<Article> Articles { get; set; }

        public DbSet<Tag> Tags { get; set; }

        //public DbSet<Comment> Comments { get;set;}

        public BetHelperContext(DbContextOptions<BetHelperContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ArticleConfiguration());

            modelBuilder.Entity<ArticleTag>()
                .HasKey(x => new { x.ArticleId, x.TagId });

            modelBuilder.Entity<ArticleTag>()
              .HasOne(a => a.Article)
              .WithMany(t => t.ArticleTags)
              .HasForeignKey(a => a.ArticleId);

            modelBuilder.Entity<ArticleTag>()
                .HasOne(t => t.Tag)
                .WithMany(a => a.ArticleTags)
                .HasForeignKey(t => t.TagId);
        }
    }
}
