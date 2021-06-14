using System;
using UKHO_Challenge.Providers;

namespace UKHO_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMappingProvider mappingProvider = new StaticMappingProvider();
            
        }
    }
}
