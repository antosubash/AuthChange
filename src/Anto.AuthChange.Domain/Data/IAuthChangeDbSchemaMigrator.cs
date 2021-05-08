using System.Threading.Tasks;

namespace Anto.AuthChange.Data
{
    public interface IAuthChangeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
