using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BaiThi.Models
{
    public class Datacontex : DbContext
    {
        public Datacontex() : base("Exam")
        { }
            public DbSet<ExamDetail> Exam { set; get; }
    }
}