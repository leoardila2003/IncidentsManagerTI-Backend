using System.Data;

namespace Backend.Persistence.DapperConnection;

public interface IDbConnectionFactory
{
  IDbConnection CreateConnection();
}