using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Enums;


namespace Shared
{
    public class ProductQueryParams
    {
        private const int DeafultPageSize = 5;
        private const int MaxPageSize = 10;
        public int?TypeId {get;set;}
         public int?BrandId { get; set; }
        public ProductSortingOptions sort { get; set; }
        public string? search { get; set; }
        public int pageNumber { get; set; } = 1;
        private int pagesize= DeafultPageSize;

        public int PageSize
        {
            get { return pagesize; }
            set { pagesize=  value>MaxPageSize?MaxPageSize:value; }
        }







    }
}
