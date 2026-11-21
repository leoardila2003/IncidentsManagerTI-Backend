using System.Data;

namespace Persistence.DapperConnection;

public interface IDbConnectionFactory
{
  IDbConnection CreateConnection();
}