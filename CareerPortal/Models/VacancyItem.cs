namespace CareerPortal.Models
{
    public class VacancyItem
    {
        public string _id { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string contactEmail { get; set; } = string.Empty;
        public string company { get; set; } = string.Empty;
        public string location { get; set; } = string.Empty;
        public decimal salary { get; set; }
    }
}
