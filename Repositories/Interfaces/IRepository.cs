using Academia.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Academia.Repositories.Interfaces {
    public interface IRepository<T> {

        void Cadastrar(T obj);
        void Editar(T obj);
        void Excluir(int id);
        T Buscar(int id);
        List<T> Listar();
        IPagedList<T> Listar(int? pagina, string pesquisa);

    }
}
