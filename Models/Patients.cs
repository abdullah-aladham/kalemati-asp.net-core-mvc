using System.ComponentModel.DataAnnotations.Schema;

namespace Kalemati.Models
{
    public class Patients
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double age { get; set; }
        public double exam_result { get; set; }
        public bool is_deleted { get; set; }
        [ForeignKey("School")]
        public School School { get; set; }
        public int Sch_id { get; set; }
        [ForeignKey("Teacher")]
        public List<Teacher> Teacher { get; set; }
        public int Tch_id { get; set; }


    }
}
