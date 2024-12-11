using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        public string Director { get; private set; }
        public int RunTime { get; private set; }
        public string MediaType { get; private set; }

        public Video(string title, string category, string director, int runTime, string mediaType) : base(title, category)
        {
            Director = director;
            RunTime = runTime;
            MediaType = mediaType;
        }

        // Override GetInfo to include additional properties
        public override void GetInfo()
        {
            base.GetInfo(); // Call the base class method
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"RunTime: {RunTime} minutes");
            Console.WriteLine($"MediaType: {MediaType}");
        }
    }
}
