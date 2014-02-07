using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AFBDirektChecker
{
    class CheckerProgram
    {
        Options options;
        string[] emails;
        bool hasEntries = false;
        public CheckerProgram(Options options)
        {
            this.options = options;
            Console.WriteLine("Loading {0}", options.AddressFile);
            this.emails = File.ReadAllLines(options.AddressFile);
            Console.WriteLine("\nEmails ({0}):", emails.Length);
            Util.PrintArray(emails);

            new Thread(new ThreadStart(ThreadLoop)).Start();
        }

        private void ThreadLoop()
        {
            while (true)
            {
                using (WebClient webClient = new WebClient())
                {
                    string data = webClient.DownloadString(options.URL);
                    if (data.Contains("inga objekt för närvarande"))
                    {
                        hasEntries = false;
                    }
                    else
                    {
                        if (!hasEntries)
                        {

                        }
                    }
                }
                Thread.Sleep(30 * 1000); //30 seconds sleep
            }
        }
    }
}
