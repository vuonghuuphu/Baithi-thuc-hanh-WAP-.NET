using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiThi.Models
{
    public class ExamDetail
    {
        public int Id { set; get; }
        public string Subject { set; get; }
        public string StartTime { set; get; }
        public string Examdate { set; get; }
        public string Duration { set; get; }
        public string Classroom { set; get; }
        public string Faculty { set; get; }
        public string Status { set; get; }
    }
}