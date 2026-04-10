using app.clientesChGio.dataAccess.context;
using app.clientesChGio.entities.models;

namespace app.clientesChGio.dataAccess.repositories
{
    public class ClienteRepository : CrudGenericService<Cliente>, IClienteRepository
    {
        public ClienteRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Cliente> Insertar(Cliente cliente)
        {
            return await InsertEntity(cliente);
        }

        public async Task Eliminar(int id)
        {
            await DeleteEntity(id);
        }

        public async Task<Cliente> SeleccionarUno(int id)
        {
           return await SelectEntity(id);
        }

        public async Task<List<Cliente>> SeleccionarTodos()
        {
            return await SelectEntitiesAll();
        }

        public async Task Actualizar(Cliente cliente)
        {
            await UpdateEntity(cliente);
        }
    }
}
