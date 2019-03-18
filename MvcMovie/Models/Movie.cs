using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name ="标题")]
        public string Title { get; set; }

        
        [DataType(DataType.Date)]
        [Display(Name = "发布日期")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="流派")]
        public string Genre { get; set; }
        [Display(Name ="价格")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        [Display(Name ="收视率")]
        public string Rating { get; set; }
    }
}
