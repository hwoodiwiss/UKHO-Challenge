using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKHO_Challenge.Models;
using UKHO_Challenge.Providers;

namespace UKHO_Challenge.ResultsProcessors
{
    public class CountyResultsProcessor : IResultsProcessor
    {
        private readonly IMappingProvider _mappingProvider;

        public CountyResultsProcessor(IMappingProvider mappingProvider)
        {
            this._mappingProvider = mappingProvider;
        }
        public IDictionary<string, FruitResult> ProcessResults(IDictionary<string, FruitResult> currResults)
        {
            if(currResults == null)
            {
                currResults = new Dictionary<string, FruitResult>();
            }
        }
    }
}
