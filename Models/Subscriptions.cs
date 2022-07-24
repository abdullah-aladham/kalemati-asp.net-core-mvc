using System.ComponentModel.DataAnnotations.Schema;

namespace Kalemati.Models
{
    public class Subscriptions
    {
        public int Id { get; set; }
        public string sub_name { get; set; }
        public DateTime sub_start { get; set; }
        public DateTime sub_end { get; set; }
        public string sub_token { get; set; }
        public bool isdeleted { get; set; }
        [ForeignKey("School")]
        public School School { get; set; }
        public int Sc_id { get; set; }
    }
}
