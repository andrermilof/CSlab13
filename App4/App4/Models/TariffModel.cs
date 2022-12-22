using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Models
{
    public class TariffModel
    {
        [PrimaryKey, AutoIncrement]
        public int? TariffId { get; set; }
        [MaxLength(50)]
        public string Provider { get; set; }
        [MaxLength(50)]
        public string Speed { get; set; }
        [MaxLength(50)]
        public string Cost { get; set; }
    }
}
