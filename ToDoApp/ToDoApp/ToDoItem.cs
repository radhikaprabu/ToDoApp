using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ToDoApp
{
    public class ToDoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ItemID { get; set; }

        public string Item { get; set; }

        public bool Done { get; set; }
    }
}
