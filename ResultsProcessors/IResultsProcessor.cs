using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKHO_Challenge.Models;

namespace UKHO_Challenge.ResultsProcessors
{
    public interface IResultsProcessor
    {
        public IDictionary<string, CountyResult> ProcessResults(IDictionary<string, CountyResult> currResults, List<string> accumulatedErrors);
    }
}
