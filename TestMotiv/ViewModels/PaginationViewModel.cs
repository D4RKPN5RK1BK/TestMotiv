using System;
using System.Collections.Generic;

namespace TestMotiv.ViewModels
{
    public class PaginationViewModel
    {
        public int PageSize { get; set; }
        
        public int CurrentPage { get; set; }
        
        public int Total { get; set; }

        public Dictionary<string, string> UrlParams { get; set; } = new Dictionary<string, string>();

        public string UrlParamsAsUrl => UrlParams.ToString();

        public bool HasPreviousPage => CurrentPage > 1;

        public bool HasNextPage => CurrentPage < TotalPages;

        public int TotalPages => (int)Math.Ceiling(Total / (double)PageSize);
    }
}