using app.clientesChGio.common.DTOs;

namespace app.clientesChGio.services.Interfaces
{
    public interface IClienteService
    {
        Task<BaseResponse<ClienteDTO>> Insertar(ClienteDTO clienteDTO);

        Task<BaseResponse<ClienteDTO>> SeleccionarUno(int id);

        Task<BaseResponse<List<ClienteDTO>>> SeleccionarTodos();

        Task<BaseResponse<ClienteDTO>> Actualizar(int id, ClienteDTO cliente);

        Task<BaseResponse<string>> Eliminar(int id);

    }
}
