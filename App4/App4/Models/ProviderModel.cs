using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Models
{
    public class ProviderModel
    {
        [PrimaryKey, AutoIncrement]
        public int ProviderId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Telephone { get; set; }
    }
}
