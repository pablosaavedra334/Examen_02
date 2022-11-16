using System.ComponentModel.DataAnnotations;

namespace Ex_02.Data.Entity
{
    public class Plantas
    {

        public int Id { get; set; }



        [Display(Name = "Producto")]

        [MaxLength(200,ErrorMessage = "El campo producto tiene como limite 200 caracteres")]
        [Required]
        public string Nombre { get; set; } = null!;




        [Display(Name = "Tipo")]
        [MaxLength(20, ErrorMessage = "El campo producto tiene como limite 200 caracteres")]
        [Required]
        public string Tipo { get; set; } = null!;




        [Display(Name = "Años")]
        [MaxLength(8, ErrorMessage = "El campo producto tiene como limite 200 caracteres")]
        [Required]
        public int Años { get; set; }


        [Display(Name = "Precio")]
        [Required]
        public decimal Precio { get; set; }



        public DateTime Plantación { get; set; }


        [Display(Name = "Plantines")]
        public double Plantines { set; get; }



        public bool Disponible { set; get; }



        [Display(Name = "Color")]
        [Required]
        public string Color { get; set; } = null!;


        [Display(Name = "Temperatura")]
        public string Temperatura { get; set; } = null!;

        [Display(Name = "Dias")]
        [Required]
        public string Dias { get; set; } = null!;


        [Display(Name = "Tamaño")]
        [Required]
        public string Tamaño { get; set; } = null!;


        //[Display(Name = "Color")]
        //[Required]
        //public string  { get; set; } = null!;




        //fecha de plamatcion,  plantines, se vendio o no (v o f), 4 campos relevantes, 5 requeridos y 5 null










    }
}
