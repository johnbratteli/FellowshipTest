using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Text;
using FellowshipTest.Models;

namespace FellowshipTest.Controllers
{
    public class PersonController : Controller
    {
        private string _baseUrl = "https://demo.fellowshiponeapi.com/v1/People/";
        private string _mode = "mode=demo";

        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Person/Details/5

        // TODO-maybe: would like to use the list retrieved by List,
        // but that would likely require using session
        public ActionResult Details(int id)
        {
            var foundPeopleRes = new Results();
            var foundPerson = new Person();
            var searchMethod = "Search?id=";

            var url = _baseUrl + searchMethod + id + "&" + _mode;
            // get data from FellowshipOne API
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode != HttpStatusCode.OK)
            {
                // TODO: put error message on page
                throw new WebException("No response or bad response from " + url);
            }
            else
            {
                // and put it in an object
                XmlSerializer ser = new XmlSerializer(typeof(Results));
                XmlReader reader = XmlReader.Create(url);
                foundPeopleRes = (Results)ser.Deserialize(reader);
                // get the one (there will only be one) person out of the result set
                foundPerson = foundPeopleRes.people[0];
                return View(foundPerson);
            }
        }

        //
        // GET: /Person/List/joe+bob
        // GET: /Person/List/1234567

        public ActionResult List(string name = null, int? hsdid = null)
        {
            var searchMethod = "";
            var searchVal = "";
            var url = "";
            var foundPeopleRes = new Results();
            var foundPeople = new List<Person>();

            // this allows us to search using a name or a household ID
            if (name != null)
            {
                ViewBag.Message = "People matching \"" + name + "\"";
                searchMethod = "Search?SearchFor=";
                searchVal = name;
            }
            else if (hsdid != null)
            {
                ViewBag.Message = "Members of Household";
                searchMethod = "Search?hsdid=";
                searchVal = hsdid.ToString();
            }
            else
            {
                throw new ArgumentNullException("List needs a name or hsdid");
            }            

            url = _baseUrl + searchMethod + searchVal + "&" + _mode;
            // get data from FellowshipOne API
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            if (res.StatusCode != HttpStatusCode.OK)
            {
                // TODO: put error message on page
                throw new WebException("No response or bad response from " + url);
            }
            else
            {
                // and put it in an object
                XmlSerializer ser = new XmlSerializer(typeof(Results));
                XmlReader reader = XmlReader.Create(url);
                foundPeopleRes = (Results)ser.Deserialize(reader);
                // prefer to pass a list of people rather than result set
                foundPeople = foundPeopleRes.people;
                return View(foundPeople);
            }
        }
        /*
                //
                // GET: /Person/List/joe+bob
                public ActionResult List(string name)
                {
                    ViewBag.Message = "People matching \""+name+"\"";
                    var foundPeopleRes = new Results();
                    var foundPeople = new List<person>();
                    var searchMethod = "Search?SearchFor=";

                    var url = _baseUrl + searchMethod + name + "&" + _mode;
                    // get data from FellowshipOne API
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    if (res.StatusCode != HttpStatusCode.OK)
                    {
                        // TODO: put error message on page
                        throw new WebException("No response or bad response from " + url);
                    }
                    else
                    {
                        // and put it in an object
                        XmlSerializer ser = new XmlSerializer(typeof(Results));
                        XmlReader reader = XmlReader.Create(url);
                        foundPeopleRes = (Results)ser.Deserialize(reader);
                        // prefer to pass a list of people rather than result set
                        foundPeople = foundPeopleRes.people;
                        return View(foundPeople);
                    }
                }
                //
                // GET: /Person/List/1234567

                [ActionName("ListHsdid")]
                public ActionResult List(int hsdid)
                {
                    ViewBag.Message = "Members of Household";
                    var foundPeopleRes = new Results();
                    var foundPeople = new List<person>();
                    var searchMethod = "Search?hsdid=";

                    var url = _baseUrl + searchMethod + hsdid + "&" + _mode;
                    // get data from FellowshipOne API
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    if (res.StatusCode != HttpStatusCode.OK)
                    {
                        // TODO: put error message on page
                        throw new WebException("No response or bad response from " + url);
                    }
                    else
                    {
                        // and put it in an object
                        XmlSerializer ser = new XmlSerializer(typeof(Results));
                        XmlReader reader = XmlReader.Create(url);
                        foundPeopleRes = (Results)ser.Deserialize(reader);
                        // prefer to pass a list of people rather than result set
                        foundPeople = foundPeopleRes.people;
                        return View(foundPeople);
                    }
                }
        */
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

        //
        // GET: /Person/CreateAddress/1234567

        public ActionResult CreateAddress(string personID)
        {
            var personURI = _baseUrl + personID;
            // TODO: figure out how to assign this correctly
            var type = new AddressType(1, "Primary", "https://demo.fellowshiponeapi.com/v1/Addresses/AddressTypes/1");
            if (personID == null || personURI == null || type == null)
            {
                throw new ArgumentNullException("I hate this!");
            }
            else
            {
                //var mod = new Address(personID, personURI, type);
                var mod = new Address();
                mod.person.id = personID;
                mod.person.uri = personURI;
                mod.addressType = type;
                return View(mod);
            }
        }
        
        //
        // POST: /Person/CreateAddress

        [HttpPost]
        //public ActionResult CreateAddresss(Address addr)
        public ActionResult CreateAddress(FormCollection collection)
        {
            Address addr = new Address(collection);

            /*
            addr.person.id = collection["person.id"];
            collection.Remove("person.id");
            addr.person.uri = collection["person.uri"];
            collection.Remove("person.uri");
            addr.addressType.id = collection["addressType.id"];
            collection.Remove("person.id");
            addr.addressType.name = collection["addressType.name"];
            collection.Remove("addressType.name");
            addr.addressType.uri = collection["addressType.uri"];
            */
            //Address addr = (Address)collection;
            var postMethod = "Addresses";
            var personID = addr.person.id;
            var url = _baseUrl + personID + postMethod;
            var xmlString = new StringBuilder();

            // serialze address object to xml
            XmlWriter writer = XmlWriter.Create(xmlString);
            XmlSerializer ser = new XmlSerializer(typeof(Address));
            ser.Serialize(writer, addr);

            try
            {
                // set up web request
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "text/xml; encoding='utf-8'";

                //bytes = System.Text.Encoding.ASCII.GetBytes(v_objXm);

                //reqStream = req.GetRequestStream();
                


                return RedirectToAction("Details/"+personID);
            }
            catch
            {
                return View();
            }
        }
    }

    // allows us to overload ActionResult methods
    public class RequireRequestValueAttribute : ActionMethodSelectorAttribute
    {
        public RequireRequestValueAttribute(string valueName)
        {
            ValueName = valueName;
        }
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return (controllerContext.HttpContext.Request[ValueName] != null);
        }
        public string ValueName { get; private set; }
    }
}
