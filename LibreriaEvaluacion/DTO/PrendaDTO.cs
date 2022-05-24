using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEvaluacion.DTO
{
    public class PrendaDTO
    {
        private int id;
        private string marca;
        private string talla;
        private int precio;

        public static List<PrendaDTO> datos = new List<PrendaDTO>()
        {
            new PrendaDTO() { id = 1, marca = "Adidas", talla = "XL", Precio = 50000 },
            new PrendaDTO() { id = 2, marca = "Nike", talla = "L", Precio = 45000 },
            new PrendaDTO() { id = 3, marca = "Puma", talla = "S", Precio = 40000 }
        };
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Talla { get => talla; set => talla = value; }
        public int Precio { get => precio; set => precio = value; }

        // Métodos
        public static bool Add(PrendaDTO nuevosDatos)
        {
            try
            {
                datos.Add(nuevosDatos); // añadir nuevo objeto a lista estática

                return true; // si añade bien, devuelve true
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
}
