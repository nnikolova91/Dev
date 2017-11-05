using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikoletaSolution
{
    class Book
    {
        public string NameBook { get; set; }
        public string NameAutour { get; set; }
        public string Publisher { get; set; }
        public DateTime Data { get; set; }
        public long Isbn { get; set; }
        public decimal Price { get; set; }
        public DateTime Na4alnaData { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
