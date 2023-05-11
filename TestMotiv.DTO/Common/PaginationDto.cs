using System;
using System.Collections.Generic;
using System.Linq;

namespace TestMotiv.DTO
{
    public class PaginationDto
    {
        public PageDataDto PageData { get; set; }
        
        public int Total { get; set; }

        public Dictionary<string, string> FilterDict { get; set; } = new Dictionary<string, string>();

        public bool HasPreviousPage => PageData.CurrentPage > 1;

        public bool HasNextPage => PageData.CurrentPage < TotalPages;

        public int TotalPages => (int)Math.Ceiling(Total / (double)PageData.PageSize);
        
        public string FilterDictAsUrl => string.Join("&", FilterDict.Select(i => $"Filter.{i.Key}={i.Value}"));
    }
}