using Microsoft.AspNetCore.Mvc;

namespace Itra.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        public int created { get; set; }
        public int updated { get; set; }
        
        public string name { get; set; }
        
        public bool bool_0 { get; set; }
        public bool bool_1 { get; set; }
        public bool bool_2 { get; set; }

        public string str_0 { get; set; } = null!;
        public string str_1 { get; set; } = null!;
        public string str_2 { get; set; } = null!;

        public int int_0 { set; get; }
        public int int_1 { set; get; }
        public int int_2 { set; get; }

        public int date_0 { set; get; }
        public int date_1 { set; get; }
        public int date_2 { set; get; }

        public string text_0 { set; get; } = null!;
        public string text_1 { set; get; } = null!;
        public string text_2 { set; get; } = null!;
    }
}
