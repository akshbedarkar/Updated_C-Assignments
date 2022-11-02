﻿
using CustomAttributes.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CustomAttrubuteAndTests.ClientApps;

namespace CustomAttrubuteAndTests
{
    

    
    [Softwareattribute("project description", "projectname", "clientname", "startdate", "enddate")]
    public class hdfcaccount
    {
        #region 
        [Softwareattribute(description = "this is project description")]
        public string projectname { get; set; }
        public string description { get; set; }

        public string clientname { get; set; }

        public string startdate { get; set; }

        public string enddate { get; set; }




        [Softwareattribute(description = "default constructor")]
        public hdfcaccount() { }

        [Softwareattribute(description = "paramererised constructor with description")]
        public hdfcaccount(string a, string b, string c, string d, string e)
        {
            this.description = a;
            this.projectname = b;
            this.clientname = c;
            this.startdate = d;
            this.enddate = e;

        }


        #endregion
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                hdfcaccount h1 = new hdfcaccount("this is description", " this is projectname", "clientname", "startdate", "enddate");
                Console.WriteLine("this is hdfc bank details");
                Console.WriteLine(h1.projectname);
                Console.WriteLine(h1.description);
                Console.WriteLine(h1.startdate);
                Console.WriteLine(h1.enddate);
                Console.WriteLine(h1.clientname);

                Console.WriteLine("===========================");
                iciciaccount i1 = new iciciaccount("it is icici bank description", "this is icici project", "this is icici client", "this is icici start date", "this is icici end date");
                Console.WriteLine("this is icici bank details");
                Console.WriteLine(i1.projectname);
                Console.WriteLine(i1.description);
                Console.WriteLine(i1.startdate);
                Console.WriteLine(i1.enddate);
                Console.WriteLine(i1.clientname);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message"+e.Message);
            }







        }
    }



}