using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      Resource test = new Resource("jeff", "history");
      test.GetInfo();
      test.UpdateStatus();
      Console.WriteLine($"Updated Status: {test.Status}");
      */
      /*
      Book test = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", "Charles Petzold", 396);

      test.GetInfo();
      */
      /*
      Periodical p = new Periodical("Wired", "Technology", "Monthly");
      p.UpdateStatus();
      Console.WriteLine(p.Status);
      */
      Video v = new Video("Ex machina", "Alex Garland", "Sci-Fi", 108, "On-Demand");   
      v.GetInfo();
    }
  }
}