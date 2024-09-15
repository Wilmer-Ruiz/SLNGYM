using Entidades;

namespace Repositorio
{
    internal interface IListasRepositorio
    {
        Task<IEnumerable<Clientes>> GetAllClientes();

        Task<IEnumerable<Trabajadores>> GetAllTrabajadores();

        Task<IEnumerable<Servicios>> GetAllServicios();

        Task<IEnumerable<Citas>> GetAllCitas();

        Task<IEnumerable<CitaServicio>> GetAllCitaServicio();

    }
}
