using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Cast
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string? Gender { get; set; }
        public string? TmdbUrl { get; set; }
        public string? ProfilePath { get; set; }
        public List<MovieCast> CastOfMovie { get; set; }
    }
}
