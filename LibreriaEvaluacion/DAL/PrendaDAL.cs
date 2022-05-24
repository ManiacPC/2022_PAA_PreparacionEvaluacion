using LibreriaEvaluacion.DTO; // importando DTO

namespace LibreriaEvaluacion.DAL
{
    public class PrendaDAL
    {
        public bool Insertar(PrendaDTO dato)
        {
            return PrendaDTO.Add(dato);
        }

        public List<PrendaDTO> Listar()
        {
            return PrendaDTO.datos; 
            // devuelve lista estática para no fallar en el paso del patrón de diseño
        }
        
    }
}
