namespace SharmaMidtermB.Models {
    public class Player {
        public int PlayerId { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!; 
        public int ShirtNumber { get; set; }
        public DateTime FirstMatch { get; set; }
    }
}
