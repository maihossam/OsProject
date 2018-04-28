using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFit
{
    class Process
    {
        string processID;
        UInt64 processsize;
        UInt64 startingaddress;

      public  Process(string id, UInt64 ps)
        {
            processID = id;
            processsize = ps;
           
        }
        public void setStartingAddress(UInt64 s)
        {
            startingaddress=s;
        }
       public UInt64 getStartingAddress()
        {
            return startingaddress;
        }
        public void setProcessSize(UInt64 h)
        {
            processsize=h;
        }
        public UInt64 getProcessSize()
        {
            return processsize;
        }
       public string getProcessID()
        {
            return processID;
        }
        void setProcessID(string id)
        {
            processID=id;
        }
        
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
