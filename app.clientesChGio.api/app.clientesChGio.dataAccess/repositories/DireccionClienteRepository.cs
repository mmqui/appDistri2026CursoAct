using app.clientesChGio.dataAccess.context;
using app.clientesChGio.entities.models;

namespace app.clientesChGio.dataAccess.repositories
{
    public class DireccionClienteRepository : CrudGenericService<DireccionCliente>, IDireccionClienteRepository
    {
        public DireccionClienteRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<DireccionCliente> Insertar(DireccionCliente direccionCliente)
        {
            return await InsertEntity(direccionCliente);
        }

        public async Task Eliminar(int id)
        {
            await DeleteEntity(id);
        }

        public async Task<DireccionCliente> SeleccionarUno(int id)
        {
            return await SelectEntity(id);
        }

        public async Task<List<DireccionCliente>> SeleccionarTodos()
        {
            return await SelectEntitiesAll();
        }

        public async Task Actualizar(DireccionCliente cliente)
        {
            await UpdateEntity(cliente);
        }
    }
}
