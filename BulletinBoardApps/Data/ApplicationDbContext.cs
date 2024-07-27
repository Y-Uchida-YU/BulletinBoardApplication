//--------------------------------------
//  Create  : 2024/07/27 Y.Uchida
//
//  Contents: データベース接続情報。
//　　　　　  Database connection information.
//
//  Update  : None
//--------------------------------------


using Microsoft.EntityFrameworkCore;
using BulletinBoardApps.Models;

namespace BulletinBoardApps.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option)
            : base(option)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
