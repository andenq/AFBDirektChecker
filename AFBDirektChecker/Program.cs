using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFBDirektChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Options
    {
        [Option('f', "address-file", Required = true,
          HelpText = "File containing email addresses to email when new entry has been discovered")]
        public string InputFile { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
