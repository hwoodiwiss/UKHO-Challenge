using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKHO_Challenge.Models
{
    public class ProcessedLineResult
    {
        public string County { get; set; }
        public CountyResult Results { get; set; }
        public List<string> Errors { get; set; }
    }
}
