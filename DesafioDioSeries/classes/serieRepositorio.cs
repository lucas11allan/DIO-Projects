using System;
using System.Collections.Generic;
using DesafioDioSeries.interfaces;


namespace DesafioDioSeries
{
    //O : indica que a classe atual implementa a interface de repositorios de Series
    public class serieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualiza(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaporId(int id)
        {
            return listaSerie[id];
        }
    }
}