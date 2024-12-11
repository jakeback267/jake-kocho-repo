using System;

namespace BiblioInheritance
{
  class Book : Resource 
  {
    public string Author
    { get; private set; }
    public int PageCount
    { get; private set; }

    public Book(string title, string category, string author, int pageCount) : base(title, category)
    {
      Author = author;
      PageCount = pageCount;
    }


  }
 
}