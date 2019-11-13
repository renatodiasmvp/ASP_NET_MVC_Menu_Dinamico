using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCcomMenuInterativo.Models
{
    public class ItemDeMenu
    {
        public int ItemDeMenuId { get; set; }
        public int ItemPaiId { get; set; }
        public string NomeDoItem { get; set; }
        public string NomeDoController { get; set; }
        public string NomeDaAction { get; set; }
    }
}