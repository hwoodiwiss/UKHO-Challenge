using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKHO_Challenge.Providers
{
    public interface IMappingProvider
    {
        public Dictionary<string, string> GetMapping();
    }

    public class StaticMappingProvider : IMappingProvider
    {
        public Dictionary<string, string> GetMapping()
        {
            return new Dictionary<string, string>()
            {
                {"A", "Apple"},
                {"B", "Banana"},
                {"O", "Orange"},
                {"K", "Kiwi"},
                {"G", "Grapes"}
            };
        }
    }
}
