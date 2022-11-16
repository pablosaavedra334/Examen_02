using System.ComponentModel.DataAnnotations;

namespace Ex_02.Data.Entity
{
    public class Riego
    {

        public int Id { get; set; }



        [Display(Name = "Tipo")]
        [Required]
        public string Tipo { get; set; } = null!;





        [Display(Name = "Litros")]
        [MaxLength(8, ErrorMessage = "El campo producto tiene como limite 200 caracteres")]
        [Required]
        public int Litros { get; set; }


        [Display(Name = "Dias")]
        [Required]
        public string Dias { get; set; } = null!;



        public DateTime Tiempo_duracion { get; set; }


        public DateTime Plantación { get; set; }



        [Display(Name = "Temperatura")]
        public string Temperatura { get; set; } = null!;


    }
}
