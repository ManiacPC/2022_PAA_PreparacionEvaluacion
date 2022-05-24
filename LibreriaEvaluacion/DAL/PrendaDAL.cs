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

        public bool Eliminar(int id)
        {
            int indiceElementoBuscado = BuscarPorId(id);

            if (indiceElementoBuscado >= 0) // encontró un elemento
            {
                return PrendaDTO.RemoveAt(indiceElementoBuscado); // ToDo: No hemos implementado RemoveAt
            }

            return false; // Si llega a esta línea, significa que algo ocurrió mal (no se encontró el elemento)
        }

        public int BuscarPorId(int id)
        {
            // recorrer la lista usando foreach para poder
            // identificar el índice donde se encuentra
            // (si no se encuentra, devuelve -1)
            for(int i = 0; i < PrendaDTO.datos.Count; i++)
            {
                if (PrendaDTO.datos[i].Id == id) // comparamos
                {
                    return i;
                }
            }

            // Si no retorna nada en el for, devolvemos -1
            return -1;
        }
        
    }
}
