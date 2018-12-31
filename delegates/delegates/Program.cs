using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
  class Program
  {
    static void Main(string[] args)
    {
      var photoProcessor = new PhotoProcessor();
      var photoFilters = new PhotoFilters();
      PhotoProcessor.PhotoFiltersHandler handler = photoFilters.ApplyBrightness;
      handler += photoFilters.ApplyContrast;
      photoProcessor.Process(string.Empty, handler);
      Console.WriteLine("Precess any key to continue ...");
      Console.ReadLine();
    }
  }
}
