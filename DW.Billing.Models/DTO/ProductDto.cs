using System;

namespace DW.Billing.Models.DTO
{
    public class ProductDto
    {
        public int Id_producto { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
    }
}
