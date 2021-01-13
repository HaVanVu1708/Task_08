using System;

namespace HVVMusic.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
    // to suport the tag hepler

    // pass information to the view about the number of pages avaiable
    //the current page and the total numbers of products
    //==> create ViewModel class to pass data betwen a controller and a view 
}
