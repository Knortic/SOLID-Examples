using System.Collections.Generic;

namespace ISPSolution
{
    public interface IDVD : ILibraryItem
    {
       List<string> Actors { get; set; }
       int RuntimeInMinutes { get; set; }
    }
}
