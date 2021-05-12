using System.Collections.Generic;

namespace DesafioDioSeries.interfaces
{
    //O T será substituído pela classe que for atribuida a esse repositorio quando o mesmo for chamado
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaporId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}