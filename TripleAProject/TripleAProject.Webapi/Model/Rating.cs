using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripleAProject.Webapi.Model
{
    public class Rating
    {
#pragma warning disable CS8618
        protected Rating() { }
#pragma warning restore CS8618

        public Rating(int grade)
        {
            Grade = grade;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public int Grade { get; private set; }
    }
}
