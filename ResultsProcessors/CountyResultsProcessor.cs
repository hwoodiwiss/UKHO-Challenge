using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKHO_Challenge.Models;
using UKHO_Challenge.Providers;
using System.IO;

namespace UKHO_Challenge.ResultsProcessors
{
    public class CountyResultsProcessor : IResultsProcessor
    {
        private readonly IMappingProvider _mappingProvider;
        private readonly string ResultsFileName = "ResultsFile.csv";

        public CountyResultsProcessor(IMappingProvider mappingProvider)
        {
            this._mappingProvider = mappingProvider;
        }
        public IDictionary<string, CountyResult> ProcessResults(IDictionary<string, CountyResult> currResults, List<string> accumulatedErrors)
        {
            if(currResults == null)
            {
                //Want to ignore case in case of inconsistencies in results files
                currResults = new Dictionary<string, CountyResult>(StringComparer.OrdinalIgnoreCase);
            }

            if(accumulatedErrors == null)
            {
                accumulatedErrors = new List<string>();
            }

            var resultsLines = File.ReadAllLines(ResultsFileName);

            foreach(var result in resultsLines.Select(ProcessLine))
            {
                accumulatedErrors.AddRange(result.Errors);
                if(result.Results?.FruitResults != null && result.Results?.FruitResults.Count > 0)
                {
                    currResults.TryAdd(result.County, result.Results);
                }
            }

            return currResults;
        }

        public ProcessedLineResult ProcessLine(string line)
        {
            var errors = new List<string>();
            var lineParts = line.Split(',');

            if(lineParts.Count() == 0 || lineParts.Count() == 1)
            {
                return new ProcessedLineResult
                {
                    Errors = new List<string>
                    {
                        $"A line was empty or had invalid data. Full line: {line}"
                    },
                    Results = new CountyResult(),
                };
            }

            var county = lineParts[0];
            
            var lineResults = lineParts.Skip(1);
            var countyResult = new CountyResult();
            var resultErrors = new List<string>();

            for(int i = 0; i < lineResults.Count(); i++)
            {

            }

            return new ProcessedLineResult
            {
                County = county,
                Results = countyResult,
                Errors = resultErrors,
            };
            
        }
    }
}
