namespace AttributesC
{

    #region 

    
    [Softwareattribute("project description","projectname","clientname","startdate","enddate")]
    public class hdfcaccount
    {
        [Softwareattribute(description = "this is project description")]
        public string projectname{ get; set; }
        public string description { get; set; }

        public string clientname { get; set; }

        public string startdate { get; set; }

        public string enddate { get; set; }




        [Softwareattribute(description = "default constructor")]
        public hdfcaccount() { }

        [Softwareattribute(description = "paramererised constructor with description")]
        public hdfcaccount(string a ,string b,string c,string d,string e)
        {
            this.description = a;
            this.projectname = b;
            this.clientname = c;
            this.startdate = d;
            this.enddate = e;

        }

        public string  printproject(string projectname)
        {
            return projectname;
        }

        public string printdescription(string description)
        {
            return description;
        }

        public string projectcode(string startdate ,string enddate)
        {
            return startdate + "U+0020-U+0020" + enddate;
        }

        public void printdetails()
        { 

            Console.WriteLine(projectname);
            Console.WriteLine(description);
            Console.WriteLine(startdate);
            Console.WriteLine(enddate);
            Console.WriteLine(clientname);
         }

        #endregion

    }


    internal class Program
    { 

        static void Main(string[] args)
        {

            try
            {
                hdfcaccount h1 = new hdfcaccount("HDFC BANK", " project 101", " client name", " Nov-2022 ", "Nov 2024");
                h1.printdetails();

                Console.WriteLine("===========================");

                iciciaccount i1 = new iciciaccount("ICICI BANK", "project 201", "client name ", "DEC 2022", "oct 2023");
                i1.printdetails();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message"+ e.Message);
            }
            
        




        }
    }
}