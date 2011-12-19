using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Text;
using FellowshipTest.ViewModels;
using FellowshipTest.Models;


namespace FellowshipTest.Controllers
{
    public class AddressController : Controller
    {
        private string _baseUrl = "https://demo.fellowshiponeapi.com/v1/People/";
        private string _mode = "mode=demo";

        //
        // GET: /Address/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Address/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Address/Create

        //
        // GET: /Person/CreateAddress/1234567

        public ActionResult Create(string personID)
        {
            var personURI = _baseUrl + personID;
            var newMethod = "/Addresses/new";

            // TODO: figure out how to assign this correctly
            var type = new AddressType(1, "Primary", "https://demo.fellowshiponeapi.com/v1/Addresses/AddressTypes/1");

            var url = _baseUrl + personID + newMethod + "?" + _mode;
            // get new address from FellowshipOne API
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
                XmlSerializer ser = new XmlSerializer(typeof(Address));
                XmlReader reader = XmlReader.Create(url);
                var addr = (Address)ser.Deserialize(reader);
                var addrView = (AddressView)addr;
                return View(addrView);
            }
        }

        //
        // POST: /Person/CreateAddress

        [HttpPost]
        public ActionResult Create(AddressView addrView)
        {
            var postMethod = "/Addresses";
            var personID = addrView.Addr.person.id;
            var url = _baseUrl + personID + postMethod;
            string xmlString;
            

            // serialze address object to xml
            //XmlWriter writer = XmlWriter.Create(xmlString);
            //XmlWriter writer = 
            XmlSerializer ser = new XmlSerializer(typeof(Address));
            //ser.Serialize(writer, addrView.Addr);
            
            MemoryStream stream = new MemoryStream();
            ser.Serialize(stream, addrView.Addr);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            xmlString = reader.ReadToEnd();
            reader.Close();

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Accept = "application/xml";

            byte[] bArray = Encoding.UTF8.GetBytes(xmlString);

            req.Method = "POST";
            req.ContentLength = bArray.Length;
            req.ContentType = "application/xml; charset=utf-8";
            
            Stream requestStream = req.GetRequestStream();
            requestStream.Write(bArray, 0, bArray.Length);
            requestStream.Close();
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            Stream responseStream = res.GetResponseStream();
            //StreamReader sr = new StreamReader(responseStream);
            //string str = sr.ReadToEnd();
            //sr.Close();


            //try
            //{

            //string content = ser.Serialize(
            
            // set up serialized stream
                
                /*
                // set up web request
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/xml;charset=utf-8";
                req.ContentLength = stream.GetBuffer().Count();
                
                stream = (MemoryStream) req.GetRequestStream();
                ser.Serialize(stream, addrView.Addr);
                stream.Close();
                //write 
                //XmlWriter writer = XmlWriter.Create(req.GetRequestStream());
                //XmlWriter writer = new XmlTextWriter(req.GetRequestStream(), System.Text.Encoding.UTF8);
                //ser.Serialize(writer, addrView.Addr);
                //req.ContentLength = ser
                //StreamWriter sWriter = new StreamWriter(req.GetRequestStream());
                ////sWriter.WriteLine(writer.ToString());
                //sWriter.Close();
                //writer.Close();
                */
                

                //HttpWebResponse resp = (HttpWebResponse) req.GetResponse();

                if (res.StatusCode != HttpStatusCode.OK && res.StatusCode != HttpStatusCode.Created)
                {
                    throw new HttpException((int)res.StatusCode, res.StatusDescription);
                }

                //bytes = System.Text.Encoding.ASCII.GetBytes(v_objXm);

                //reqStream = req.GetRequestStream();



                return RedirectToAction("Details", "Person", new { id = personID });
            //}
            //catch
            //{
                return View();
            //}
        }
        
        //
        // GET: /Address/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Address/Edit/5

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
        // GET: /Address/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Address/Delete/5

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
