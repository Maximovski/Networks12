using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Networks1
{
    class Program
    {
        private static string dataHtml;
        private static string Headers1;
        private static string Headers2;
        private static string Headers3;
        private static string Headers4;
        private static string Headers5 = "++++++";
        private static string img;
        private static string src = "";
        private static string width = "";
        private static string height = "";
        private static string border = "";
        private static string search = "";
        static void Main()
        {
            
            GetHtml();

            SearchHeaders();

            Console.WriteLine("___________________________________" +
                "_______________________________" +
                "______________________________");
            Console.WriteLine("Headers1");
            Console.WriteLine(Headers1);
            Console.WriteLine("Headers2");
            Console.WriteLine(Headers2);
            Console.WriteLine("Headers3");
            Console.WriteLine(Headers3);
            Console.WriteLine("Headers4");
            Console.WriteLine(Headers4);
            Console.WriteLine("Headers5");
            Console.WriteLine(Headers5);
            Console.ReadLine();
        }


        public static void GetHtml() {
            string urlAddress = "http://www.5byte.ru/9/0038.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();
                dataHtml = data;
                Console.WriteLine(dataHtml);
                
                response.Close();
                readStream.Close();
            }
        }
        public static void SearchIMG() {
              

            }
        
        //working
        public static void SearchHeaders() {
            string H1 = "<h1>";
            string H2 = "<h2>";
            string H3 = "<h3>";
            string H4 = "<h4>";
            string H5 = "<h5>";
            string searchString = "";
            string H11 = "</h1>"; 
            string H21 = "</h2>";
            string H31 = "</h3>";
            string H41 = "</h4>";
            string H51 = "</h5>";
            string H111 = "/h1>";
            string H211 = "/h2>";
            string H311 = "/h3>";
            string H411 = "/h4>";
            string H511 = "/h5>";
            string searchString1 = "";
            string searchString11 = "";

            for (int i = 0; i < dataHtml.Length - 6; i++) {
                
                searchString += "" + dataHtml[i] + dataHtml[i+1] + dataHtml[i+2] + dataHtml[i + 3];
               
                if (searchString == H1) {
                    for (int j = i + 4; j < dataHtml.Length - 4; j++)
                    {
                        searchString1 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] + dataHtml[j + 4];
                        searchString11 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3];
                        if (searchString1 != H1)
                        {
                            Headers1 = Headers1 + dataHtml[j];
                        }
                        if (searchString1 == H11)
                        {
                            break;
                        }
                        if (searchString11 == H111)
                        {
                            break;
                        }
                        searchString1 = "";
                        searchString11 = "";
                    }
                }
                if (searchString == H2)
                {
                    for (int j = i + 4; j < dataHtml.Length - 4; j++)
                    {
                        searchString1 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] + dataHtml[j + 4];
                        searchString11 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3];
                        if (searchString1 != H1)
                        {
                            Headers2 = Headers2 + dataHtml[j];
                        }
                        if (searchString1 == H21)
                        {
                            break;
                        }
                        if (searchString11 == H211)
                        {
                            break;
                        }
                        searchString1 = "";
                        searchString11 = "";
                    }
                }
                if (searchString == H3)
                {
                    for (int j = i + 4; j < dataHtml.Length - 4; j++)
                    {
                        searchString1 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] + dataHtml[j + 4];
                        searchString11 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] ;
                        if (searchString1 != H31)
                        {
                            Headers3 = Headers3 + dataHtml[j];
                        }
                        if (searchString1 == H31)
                        {
                            break;
                        }
                        if (searchString11 == H311)
                        {
                            break;
                        }
                        searchString1 = "";
                        searchString11 = "";
                    }
                }
                if (searchString == H4)
                {
                    for (int j = i + 4; j < dataHtml.Length - 4; j++)
                    {
                        searchString1 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] + dataHtml[j + 4];
                        searchString11 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3];
                        if (searchString1 != H41)
                        {
                            Headers4 = Headers4 + dataHtml[j];
                        }
                        if (searchString1 == H41)
                        {
                            break;
                        }
                        if (searchString11 == H411)
                        {
                            break;
                        }
                        searchString1 = "";
                        searchString11 = "";
                    }
                }
                if (searchString == H5)
                {
                    for (int j = i + 4; j < dataHtml.Length - 4; j++)
                    {
                        searchString1 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3] + dataHtml[j + 4];
                        searchString11 += "" + dataHtml[j] + dataHtml[j + 1] + dataHtml[j + 2] + dataHtml[j + 3];
                        if (searchString1 != H51)
                        {
                            Headers5 = Headers5 + dataHtml[j];
                        }
                        if (searchString1 == H51)
                        {
                            break;
                        }
                        if (searchString11 == H511)
                        {
                            break;
                        }
                        searchString1 = "";
                        searchString11 = "";
                    }
                }
                searchString = "";
            }
        }
    }
}
