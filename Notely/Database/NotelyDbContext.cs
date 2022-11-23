using Microsoft.EntityFrameworkCore;
using Notely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notely.Database
{
    public class NotelyDbContext : DbContext
    {
        public NotelyDbContext(DbContextOptions<NotelyDbContext> options) : base(options) { }
        public DbSet<Note> Notes { get; set; }
    }
}
