using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithAsp.Net5.Models
{
    public class Person
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("fist_name")]
        public string Fistname { get; set; }
        [Column("last_name")]
        public string Lastname { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("gender")]
        public string Gender { get; set; }
    }
}
