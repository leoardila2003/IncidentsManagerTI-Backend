using System.Data;
using Npgsql;

namespace Backend.Persistence.DapperConnection;

public class ConnectionFactory : IDbConnectionFactory
{
  private readonly NpgsqlDataSource _dataSource;

  public ConnectionFactory(string connectionString)
  {
    var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
    _dataSource = dataSourceBuilder.Build();
  }

  public IDbConnection CreateConnection()
  {
    throw new NotImplementedException();
  }

  public void Dispose()
  {
    _dataSource.Dispose();
  }
}