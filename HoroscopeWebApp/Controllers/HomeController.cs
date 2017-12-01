using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HoroscopeWebApp.Controllers
{
    public class HomeController : Controller
    {

        public static int c = 1000;
        public static int f = 1001;
        public static string sign = "";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignFinder()
        {
            return View();
        }

        public ActionResult Sign()
        {
            return View();
        }

        public ActionResult Horoscope(string date)
        {

            DateTime input = Convert.ToDateTime(date);
            

            while (true)
            {


                //Capricorn (December 22-January 19)
                int capStartMonth = 12;
                int capStartDay = 23;
                int capEndMonth = 01;
                int capEndDay = 19;
                DateTime CapricornStart = Convert.ToDateTime($"{capStartMonth}/{capStartDay}/{c}");
                DateTime CapricornEnd = Convert.ToDateTime($"{capEndMonth}/{capEndDay}/{f}");

                //Aquarius (January 20 to February 18)
                int aquariusStartMonth = 01;
                int aquariusStartDay = 20;
                int aquariusEndMonth = 02;
                int aquariusEndDay = 18;
                DateTime AquariusStart = Convert.ToDateTime($"{aquariusStartMonth}/{aquariusStartDay}/{f}");
                DateTime AquariusEnd = Convert.ToDateTime($"{aquariusEndMonth}/{aquariusEndDay}/{f}");

                //Pisces (February 19 to March 20)
                int piscesStartMonth = 02;
                int piscesStartDay = 19;
                int piscesEndMonth = 03;
                int piscesEndDay = 20;
                DateTime PiscesStart = Convert.ToDateTime($"{piscesStartMonth}/{piscesStartDay}/{f}");
                DateTime PiscesEnd = Convert.ToDateTime($"{piscesEndMonth}/{piscesEndDay}/{f}");

                //Aries (March 21-April 19)
                int ariesStartMonth = 03;
                int ariesStartDay = 21;
                int ariesEndMonth = 04;
                int ariesEndDay = 19;
                DateTime AriesStart = Convert.ToDateTime($"{ariesStartMonth}/{ariesStartDay}/{f}");
                DateTime AriesEnd = Convert.ToDateTime($"{ariesEndMonth}/{ariesEndDay}/{f}");

                //Taurus (April 20-May 20)
                int taurusStartMonth = 04;
                int taurusStartDay = 20;
                int taurusEndMonth = 05;
                int taurusEndDay = 20;
                DateTime TaurusStart = Convert.ToDateTime($"{taurusStartMonth}/{taurusStartDay}/{f}");
                DateTime TaurusEnd = Convert.ToDateTime($"{taurusEndMonth}/{taurusEndDay}/{f}");

                //Gemini (May 21-June 20)
                int geminiStartMonth = 05;
                int geminiStartDay = 21;
                int geminiEndMonth = 06;
                int geminiEndDay = 20;
                DateTime GeminiStart = Convert.ToDateTime($"{geminiStartMonth}/{geminiStartDay}/{f}");
                DateTime GeminiEnd = Convert.ToDateTime($"{geminiEndMonth}/{geminiEndDay}/{f}");

                //Cancer (June 21-July 22)
                int cancerStartMonth = 06;
                int cancerStartDay = 21;
                int cancerEndMonth = 07;
                int cancerEndDay = 22;
                DateTime CancerStart = Convert.ToDateTime($"{cancerStartMonth}/{cancerStartDay}/{f}");
                DateTime CancerEnd = Convert.ToDateTime($"{cancerEndMonth}/{cancerEndDay}/{f}");

                //Leo (July 23-August 22)
                int leoStartMonth = 07;
                int leoStartDay = 23;
                int leoEndMonth = 08;
                int leoEndDay = 22;
                DateTime LeoStart = Convert.ToDateTime($"{leoStartMonth}/{leoStartDay}/{f}");
                DateTime LeoEnd = Convert.ToDateTime($"{leoEndMonth}/{leoEndDay}/{f}");

                //Virgo (August 23-September 22)
                int virgoStartMonth = 08;
                int virgoStartDay = 23;
                int virgoEndMonth = 09;
                int virgoEndDay = 22;
                DateTime VirgoStart = Convert.ToDateTime($"{virgoStartMonth}/{virgoStartDay}/{f}");
                DateTime VirgoEnd = Convert.ToDateTime($"{virgoEndMonth}/{virgoEndDay}/{f}");

                //Libra (September 23-October 22)
                int libraStartMonth = 09;
                int libraStartDay = 23;
                int libraEndMonth = 10;
                int libraEndDay = 22;
                DateTime LibraStart = Convert.ToDateTime($"{libraStartMonth}/{libraStartDay}/{f}");
                DateTime LibraEnd = Convert.ToDateTime($"{libraEndMonth}/{libraEndDay}/{f}");

                //Scorpio (October 23-November 21)
                int scorpioStartMonth = 10;
                int scorpioStartDay = 23;
                int scorpioEndMonth = 11;
                int scorpioEndDay = 21;
                DateTime ScorpioStart = Convert.ToDateTime($"{scorpioStartMonth}/{scorpioStartDay}/{f}");
                DateTime ScorpioEnd = Convert.ToDateTime($"{scorpioEndMonth}/{scorpioEndDay}/{f}");

                //Sagittarius (November 22-December 21)
                int sagittariusStartMonth = 11;
                int sagittariusStartDay = 22;
                int sagittariusEndMonth = 12;
                int sagittariusEndDay = 21;
                DateTime SagittariusStart = Convert.ToDateTime($"{sagittariusStartMonth}/{sagittariusStartDay}/{f}");
                DateTime SagittariusEnd = Convert.ToDateTime($"{sagittariusEndMonth}/{sagittariusEndDay}/{f}");




                if (input > CapricornStart && input < CapricornEnd)
                {

                    //Console.WriteLine("Capricorn");
                    ViewBag.Sign = "Capricorn";
                    sign = "Capricorn";
                    break;

                }
                else if (input > AquariusStart && input < AquariusEnd)
                {

                    //Console.WriteLine("Aquarius");
                    ViewBag.Sign = "Aquarius";
                    sign = "Aquarius";
                    break;

                }
                else if (input > PiscesStart && input < PiscesEnd)
                {

                    //Console.WriteLine("Pisces");
                    ViewBag.Sign = "Pisces";
                    sign = "Pisces";
                    break;

                }
                else if (input > AriesStart && input < AriesEnd)
                {

                    //Console.WriteLine("Aries");
                    ViewBag.Sign = "Aries";
                    sign = "Aries";
                    break;

                }
                else if (input > TaurusStart && input < TaurusEnd)
                {

                    //Console.WriteLine("Taurus");
                    ViewBag.Sign = "Taurus";
                    sign = "Taurus";
                    break;

                }
                else if (input > GeminiStart && input < GeminiEnd)
                {

                    //Console.WriteLine("Gemini");
                    ViewBag.Sign = "Gemini";
                    sign = "Gemini";
                    break;

                }
                else if (input > CancerStart && input < CancerEnd)
                {

                    //Console.WriteLine("Cancer");
                    ViewBag.Sign = "Cancer";
                    sign = "Cancer";
                    break;

                }
                else if (input > LeoStart && input < LeoEnd)
                {

                    //Console.WriteLine("Leo");
                    ViewBag.Sign = "Leo";
                    sign = "Leo";
                    break;

                }
                else if (input > VirgoStart && input < VirgoEnd)
                {

                    //Console.WriteLine("Virgo");
                    ViewBag.Sign = "Virgo";
                    sign = "Virgo";
                    break;

                }
                else if (input > LibraStart && input < LibraEnd)
                {

                    //Console.WriteLine("Libra");
                    ViewBag.Sign = "Libra";
                    sign = "Libra";
                    break;

                }
                else if (input > ScorpioStart && input < ScorpioEnd)
                {

                    //Console.WriteLine("Scorpio");
                    ViewBag.Sign = "Scorpio";
                    sign = "Scorpio";
                    break;

                }
                else if (input > SagittariusStart && input < SagittariusEnd)
                {

                    //Console.WriteLine("Sagittarius");
                    ViewBag.Sign = "Sagittarius";
                    sign = "Sagittarius";
                    break;

                }
                else
                {

                    c++;
                    f++;

                }

               
              
            }

            HttpWebRequest WR = WebRequest.CreateHttp($"http://horoscope-api.herokuapp.com/horoscope/today/{sign}");
            WR.UserAgent = "Grand Circus Detroit .NET Framework Test Client";

            HttpWebResponse Response = (HttpWebResponse)WR.GetResponse();

            StreamReader reader = new StreamReader(Response.GetResponseStream());

            string CardData = reader.ReadToEnd();

            JObject JsonData = JObject.Parse(CardData);

            string Date = JsonData["date"].ToString();
            string Horoscope = JsonData["horoscope"].ToString();

            ViewBag.FoundSign = Date;
            ViewBag.Scope = Horoscope;


            return View("Sign");
        }


    }
}