using System.ComponentModel;

namespace Core.Entities
{
    public class PortfolioItems : BaseEntity
    {
        [DisplayName("Project Name")]
        public string  ProjectName { get; set; }
        [DisplayName("Project Description")]
        public string Description { get; set; }
        [DisplayName("Image")]
        public string ImageUrl { get; set; }
    }
}
