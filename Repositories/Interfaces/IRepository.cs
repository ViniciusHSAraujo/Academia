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
        void Excluir(long id);
        T Buscar(long id);
        List<T> Listar();
        IPagedList<T> Listar(int? pagina);

    }
}
