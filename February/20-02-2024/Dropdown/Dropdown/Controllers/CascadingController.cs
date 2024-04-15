using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Dropdown.Controllers
{
    public class CascadingController : Controller
    {
        Dropdown.StudentPortalDbEntities studentPortalDbEntities = new Dropdown.StudentPortalDbEntities();
        // GET: Cascading
        public ActionResult Index()
        {
            ViewBag.CountryList=new SelectList(GetCountryList(),"cid","cname");
            return View();
        }

        /*public ActionResult GetStateList(int cid)
        {
            List<state> statelist = new List<state>();
            statelist=studentPortalDbEntities.states.Where(x=>x.cid==cid).ToList();
            ViewBag.StateList=new SelectList(statelist,"sid","sname");
            return PartialView("DisplayStates");

        }*/
        public JsonResult GetStateList(int cid)
        {
            List<state> statelist = studentPortalDbEntities.states.Where(x => x.cid == cid).ToList();
            var stateListSelectList = new SelectList(statelist, "sid", "sname");
            return Json(stateListSelectList,  JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCityList(int sid)
        {
            List<city> citylist = studentPortalDbEntities.cities.Where( x => x.sid == sid).ToList();
            var stateListSelectList = new SelectList(citylist, "cityid", "cityname");
            return Json(stateListSelectList, JsonRequestBehavior.AllowGet);
        }


        public List<Country> GetCountryList()
        {
            
            List<Country> countryList = studentPortalDbEntities.Countries.ToList();
            return countryList;
        }
    }
}