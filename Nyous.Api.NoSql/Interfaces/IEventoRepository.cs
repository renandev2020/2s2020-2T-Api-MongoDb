using Nyous.Api.NoSql.Domains;
using System.Collections.Generic;

namespace Nyous.Api.NoSql.Interfaces
{
    public interface IEventoRepository
    {
        List<EventoDomain> Listar();
        EventoDomain BuscarPorId(string id);

        void Adcionar(EventoDomain evento);

        void Atualizar(string id, EventoDomain evento);

        void Remover(string id);
    }
}
