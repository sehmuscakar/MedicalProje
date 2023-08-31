namespace DataAccessLayer.Dtos.AdminDtos
{
    public class BusinessListDto:AdminBaseDto
    {
        public string About { get; set; }
        public string AboutDecription { get; set; }
        public string Mission { get; set; }
        public string MissionDescription { get; set; }
        public string Vision { get; set; }
        public string VisionDescription { get; set; }
        public string ImageUrl { get; set; }

    }
}
