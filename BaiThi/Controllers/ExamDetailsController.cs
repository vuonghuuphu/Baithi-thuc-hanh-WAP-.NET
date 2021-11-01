using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiThi.Models;

namespace BaiThi.Controllers
{
    public class ExamDetailsController : Controller
    {
        private Datacontex db = new Datacontex();

        public ActionResult Index()
        {
            return View(db.Exam.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamDetail examDetail = db.Exam.Find(id);
            if (examDetail == null)
            {
                return HttpNotFound();
            }
            return View(examDetail);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,StartTime,Examdate,Duration,Classroom,Faculty,Status")] ExamDetail examDetail)
        {
            if (ModelState.IsValid)
            {

                db.Exam.Add(examDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(examDetail);
        }

    }
}
