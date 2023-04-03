using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiApp1.Models
{
    [Table("Clientes ")]
    public partial class Clientes
    {
        [PrimaryKey][AutoIncrement]
        public Int32 Id { get; set; }
        [Unique, MaxLength(100)]
        public String Nome { get; set; }
    }
}
