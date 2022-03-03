using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        //navigational
        public List<MovieGenre> MoviesOfGenre { get; set; }

    }
}
