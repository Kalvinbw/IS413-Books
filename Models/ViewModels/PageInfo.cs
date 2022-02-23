using System;
namespace Books.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumProjects { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }

        // Calculate how many pages we need
        public int TotalPages => (int)Math.Ceiling((double)TotalNumProjects / ProjectsPerPage);
    }
}
