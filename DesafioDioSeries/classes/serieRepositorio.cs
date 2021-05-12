using System;
using System.Collections.Generic;
using DesafioDioSeries.interfaces;


namespace DesafioDioSeries
{
    //O : indica que a classe atual implementa a interface de repositorios de Series
    public class serieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualiza(int id)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Series RetornaporId(int id)
        {
            throw new NotImplementedException();
        }
    }
}