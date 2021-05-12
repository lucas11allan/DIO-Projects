using System.Collections.Generic;

namespace DesafioDioSeries.interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaporId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id);
         int ProximoId();
    }
}