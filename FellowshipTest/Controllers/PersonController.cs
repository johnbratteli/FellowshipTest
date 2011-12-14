using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace FellowshipTest.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            // TODO: put this somewhere better
            //var people = new List<person>();
            people ppl;
            var url = "https://demo.fellowshiponeapi.com/v1/Households/1551556/People?mode=demo";
            // get data from FellowshipOne API
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse) req.GetResponse();
            if (res.StatusCode != HttpStatusCode.OK)
            {
                // TODO: put error message on page
                throw new WebException("No response or bad response from " + url);
            }
            else
            {
                // and put it in an object
                //XmlSerializer ser = new XmlSerializer(typeof(person));
                XmlSerializer ser = new XmlSerializer(typeof(people));
                XmlReader reader = XmlReader.Create(url);
                //people = (List<person>)ser.Deserialize(reader);
                //return View(people);
                ppl = (people)ser.Deserialize(reader);
                return View(ppl);

            }
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
