using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Parcial_Aplicada_2_Emminton.Models
{
    public class Articulo
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(0, 100000, ErrorMessage = "El rango es de 0 a 100000")]
        public int ArticuloId { get; set; }
        [Required(ErrorMessage ="El Campo descripcion no puede estar vacio.")]
        [MinLength(10, ErrorMessage ="La descripcion debe tener minimo (10 caracteres).")]
        [MaxLength(100, ErrorMessage = "La descripcion pasa el maximo de  (100 caracteres).")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(1, 2000, ErrorMessage = "El rango es de 1 a 100000")]
        public decimal Existencia { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [Range(1, 2000, ErrorMessage = "El rango es de 1 a 100000")]
        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }
        public Articulo()   {    }

        public Articulo(int articuloId, string descripcion, decimal existencia, decimal costo, decimal valorInventario)
        {
            ArticuloId = articuloId;
            Descripcion = descripcion;
            Existencia = existencia;
            Costo = costo;
            ValorInventario = valorInventario;
        }
    }
}
