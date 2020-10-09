using System.ComponentModel.DataAnnotations;

namespace YumiAPI.Models{
    public class PageSettings{
        [Key]
        public int Id { get; set; }
            public bool HomeDisplayCarousel { get; set; }
            public bool HomeDisplayTopPicks { get; set; }
            public string HomeHeroTitle { get; set; }
            public string HomeFavTitle { get; set; }
            public string HomeTitle { get; set; }
            public string HomeText { get; set; }
            public string MenuHeaderTitle { get; set; }
            public string AboutHeaderTitle { get; set; }
            public string AboutTitle { get; set; }
            public string AboutText1 { get; set; }
            public string AboutText2 { get; set; }
            public string ContactHeaderTitle { get; set; }
            public string ContactTitle { get; set; }
            public string ContactText { get; set; }
    }
}