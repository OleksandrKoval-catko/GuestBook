using System;
using Microsoft.EntityFrameworkCore;
using GuestBookApi.Models;

namespace GuestBookApi.Context
{
    public class MainContext : DbContext
    {
        public DbSet<GuestNote> GuestNotes { get; set; }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }


    }
}
