namespace lesson_21_extension_method_1
{
    public sealed class Road // inheritance not allow, extensions is needed while class is sealed
    {
        public string Number { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} общей протяженность {Length}";
        }
    }
}