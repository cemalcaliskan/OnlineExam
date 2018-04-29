using OnineSinav.BLL.Concrete;
using OnlineSinav.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineSinav.UI.WebMVC.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        ExamService _examService;

        public ExamController()
        {
            _examService = new ExamService();
        }

        public ActionResult List()
        {
            return View(_examService.GetList());
        }

        public ActionResult GetExam(int id)
        {
            Exam currentExam = _examService.GetByID(id);
            Question currentQuestion = currentExam.Questions.ToList()[0];

            Session["Correct"] = 0;
            Session["Wrong"] = 0;
            Session["Exam"] = currentExam;
            Session["Question"] = currentQuestion;
            return View(currentExam);
        }

        public PartialViewResult BindQuestion(int id)
        {
            Exam currentExam = _examService.GetByID(id);
            return PartialView("_PartialQuestion", currentExam.Questions.ToList()[0]);
        }
    }
}