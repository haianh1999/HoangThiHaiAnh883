using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangThiHaiAnh883.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<HoangThiHaiAnh883.Models.CompamyHthA883> CompamyHthA883 { get; set; }

        public DbSet<HoangThiHaiAnh883.Models.HTHA0883> HTHA0883 { get; set; }
    }
