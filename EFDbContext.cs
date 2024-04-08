using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project_Windows.Models; //truy xuất đến các lớp: Customer,…
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Windows
{
    internal class EFDbContext : DbContext
    {
        
        public DbSet<Account> Account { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubjectScoreDetail> SubjectScoreDetails { get; set; }
        public DbSet<Term> Terms { get; set; }
        public void ConfigureServices(IServiceCollection services)
           => services.AddDbContext<EFDbContext>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DTBQLSVMain"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().HasData(
                new Branch
                {
                    BranchID = 1,
                    NameBranch = "Công nghệ thông tin",
                },
                new Branch
                {
                    BranchID = 2,
                    NameBranch = "Quản trị kinh doanh",
                },
                new Branch
                {
                    BranchID = 3,
                    NameBranch = "Kế toán",
                },
                new Branch
                {
                    BranchID = 4,
                    NameBranch = "Ngôn ngữ Anh",
                },
                new Branch
                {
                    BranchID = 5,
                    NameBranch = "Quản trị nhân lực",
                }
            );

           modelBuilder.Entity<Class>().HasData(
                new Class
                {
                    ClassID = 1,
                    NameClass = "21DHTT01",
                    BranchID = 1,
                },
                new Class
                {
                    ClassID = 2,
                    NameClass = "21DHTT02",
                    BranchID = 1,
                },
                new Class
                {
                    ClassID = 3,
                    NameClass = "21QTKD01",
                    BranchID = 2,
                },
                new Class
                {
                    ClassID = 4,
                    NameClass = "21QTKD02",
                    BranchID = 2,
                },
                new Class
                {
                    ClassID = 5,
                    NameClass = "21KT01",
                    BranchID = 3,
                },
                new Class
                {
                    ClassID = 6,
                    NameClass = "21KT01",
                    BranchID = 3,
                },
                new Class
                {
                    ClassID = 7,
                    NameClass = "21DHNA01",
                    BranchID = 4,
                },
                new Class
                {
                    ClassID = 8,
                    NameClass = "21DHNA02",
                    BranchID = 4,
                },
                new Class
                {
                    ClassID = 9,
                    NameClass = "21QTNL01",
                    BranchID = 5,
                },
                new Class
                {
                    ClassID = 10,
                    NameClass = "21QTNL02",
                    BranchID = 5,
                }

            );
           modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 2154810083,
                    NameStudent = "Võ Hiếu Sinh",
                    SexStudent = "Nam",
                    AddressStudent = "Bình Thuận",
                    BirthDay = DateTime.Parse("2003-03-27"),
                    Phone = "0933516029",
                    Email = "2154810083@vaa.edu.vn",
                    ClassID = 1,
                    BranchID= 1,
                },
                new Student
                {
                    StudentID = 215888488,
                    NameStudent = "Trần Nguyễn Khánh TRang",
                    SexStudent = "Nữ",
                    AddressStudent = "Cà Mau",
                    BirthDay = DateTime.Parse("2003-12-24"),
                    Phone = "0933516029",
                    Email = "2154810083@vaa.edu.vn",
                    ClassID = 1,
                    BranchID = 1,

                },
                new Student
                {
                    StudentID = 21588477,
                    NameStudent = "Lê Công Phượng",
                    SexStudent = "Nam",
                    AddressStudent = "Nghê An",
                    BirthDay = DateTime.Parse("2003-01-24"),
                    Phone = "0933516029",
                    Email = "2154810100@vaa.edu.vn",
                    ClassID = 2,
                    BranchID = 1,
                },
                new Student
                {
                    StudentID = 21588812234,
                    NameStudent = "Lionel Messi",
                    SexStudent = "Nam",
                    AddressStudent = "Argentina",
                    BirthDay = DateTime.Parse("2000-10-10"),
                    Phone = "0382080567",
                    Email = "lionelmessi@vaa.edu.vn",
                    ClassID = 1,
                    BranchID = 1,
                },
                new Student
                {
                    StudentID = 7777777,
                    NameStudent = "Cristiano Ronaldo",
                    SexStudent = "Nam",
                    AddressStudent = "Potural",
                    BirthDay = DateTime.Parse("2000-07-07"),
                    Phone = "7777777777",
                    Email = "cristianoronaldo@vaa.edu.vn",
                    ClassID = 1,
                    BranchID = 1,
                }

            ) ;

           modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectID = 1,
                    SubjectName = "Lập trình Windows",
                    SubjectCredit = 3,
                },
                new Subject
                 {
                    SubjectID = 2,
                    SubjectName = "Lập trình di động",
                    SubjectCredit = 3,
                },
                new Subject
                {
                    SubjectID = 3,
                    SubjectName = "Lập trình Web",
                    SubjectCredit = 3,
                },
                new Subject
                {
                    SubjectID = 4,
                    SubjectName = "Trí tuệ nhân tạo",
                    SubjectCredit = 3,
                },
                 new Subject
                 {
                     SubjectID = 5,
                     SubjectName = "Công nghệ phần mềm",
                     SubjectCredit = 3,
                 },
                  new Subject
                  {
                      SubjectID = 6,
                      SubjectName = "Đồ án cơ sở ngành",
                      SubjectCredit = 3,
                  },
                 new Subject
                 {
                     SubjectID = 7,
                     SubjectName = "Đồ án chuyên ngành",
                     SubjectCredit = 3,
                 },
                  new Subject
                  {
                      SubjectID = 8,
                      SubjectName = "Lập trình python",
                      SubjectCredit = 3,
                  },
                 new Subject
                 {
                     SubjectID = 9,
                     SubjectName = "Phân tích và thiết kế giải thuật",
                     SubjectCredit = 2,
                 }

            );
            modelBuilder.Entity<Account>().HasData(
                new
                {
                    Id = 2,
                    Username = "sinh123",
                    Password = "123456",
                    RoleID = 1,
                },
                new
                {
                    Id = 3,
                    Username = "sinhdeptrai",
                    Password = "123456",
                    RoleID = 2,
                },
                new
                {
                    Id = 4,
                    Username = "sinh1",
                    Password = "123456",
                    RoleID = 1,
                }

            );


        }
    }
}
