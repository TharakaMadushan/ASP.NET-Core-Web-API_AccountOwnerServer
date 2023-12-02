using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OwnerParameters : QueryStringParameters
    {
        public OwnerParameters()
        {
            OrderBy = "name";
        }

        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

        public uint MinYearOfBirth { get; set; }
        public uint MaxYearOfBirth { get; set; } = (uint)DateTime.Now.Year;

        public bool ValidYearRange => MaxYearOfBirth > MinYearOfBirth;
        public string Name { get; set; }
    }
}
