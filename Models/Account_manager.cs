using System.ComponentModel.DataAnnotations.Schema;

namespace Kalemati.Models
{
    public class Account_manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("School")]
        public School School  { get; set; }
        public int Sch_id { get; set; }
        [ForeignKey("Teacher")]
        public List<Teacher> Teacher { get; set; }
        public int T_id { get; set; }
    }
}
