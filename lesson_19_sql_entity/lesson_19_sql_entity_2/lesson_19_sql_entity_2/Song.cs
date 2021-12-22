namespace lesson_19_sql_entity_2
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        
        public virtual Group Group { get; set; }
    }
}