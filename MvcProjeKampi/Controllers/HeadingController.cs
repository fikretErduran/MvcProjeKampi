using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EFHeadingDal());
        CategoryManager cm =new CategoryManager(new EFCategoryDal());
        WriterManager wm = new WriterManager(new EFWriterDal());  
        public ActionResult Index()
        {
            var headingvalues = hm.GetHeadingList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> ValueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            List<SelectListItem> ValueWriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.WriterName +" "+x.WriterSurName,
                                                    Value = x.WriterID.ToString()

                                                }).ToList();
            
            ViewBag.Categoryvalue=ValueCategory;
            ViewBag.Writervalue = ValueWriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse (DateTime.Now.ToShortTimeString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}