using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Models
{
    public class RegionModel
    {
        [PrimaryKey, AutoIncrement]
        public int RegionId { get; set; }
        public int ProviderId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
