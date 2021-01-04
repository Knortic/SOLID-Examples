using ISPDemo;
using System;

namespace ISPSolution
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
