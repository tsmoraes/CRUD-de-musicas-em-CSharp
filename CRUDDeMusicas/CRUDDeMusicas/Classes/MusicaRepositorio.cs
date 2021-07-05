using System;
using System.Collections.Generic;
using CRUD.Musicas.Interfaces;

namespace CRUD.Musicas
{
	public class MusicaRepositorio : IRepositorio<Musica>
	{
        private List<Musica> listaSerie = new List<Musica>();
		public void Atualiza(int id, Musica objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Musica objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Musica> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Musica RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}