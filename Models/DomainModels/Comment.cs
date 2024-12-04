namespace BasicMVC.Models
{
    public class Comment()
    {

        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public string CommentText { get; set; } = string.Empty;

        public string OwnerID { get; set; } = string.Empty; //represents the physical value in the database
        public MVCUser Owner { get; set; } = null!; //navigation property for MVCUser

        public int PostIDNumber { get; set; }

        //navigation property showing relationship by convention comments/ many side
        public Post Post { get; set; } = null!;

    }
}