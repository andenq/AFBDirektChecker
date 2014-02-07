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
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                new CheckerProgram(options);
            }
            else
            {
                Console.Write(options.GetUsage());
            }
        }
    }

    class Options
    {
        [Option('f', "address-file", Required = true,
          HelpText = "File containing email addresses to email when entries have been discovered.")]
        public string AddressFile { get; set; }

        [Option('u', "url", Required=false, DefaultValue="http://www.afb.se/redimo/jsp/objects_to_let/inc_index.jsp",
            HelpText="Custom URL to check for entries.")]
        public string URL { get; set; }

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
