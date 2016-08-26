using System;
using System.Data.Common;

namespace AutoKennis {
	public class UserDAO: IUserDAO {
		private readonly string ConnectionString;

		private readonly DbProviderFactory Provider;

		public UserDAO(string connectionString, DbProviderFactory provider) {
			ConnectionString = connectionString;
			Provider = provider;
		}

		public void AddUser(User user) {
			using (var connection = Provider.CreateConnection()) {
				connection.ConnectionString = ConnectionString;
				connection.Open();

				using (var command = Provider.CreateCommand()) {
					command.Connection = connection;
					command.CommandText = "insert into RegisteredUser (Name, PasswordSalt, PasswordHash) values (@Name, @PasswordSalt, @PasswordHash)";
					Param(command, "Name", user.Name);
					Param(command, "PasswordSalt", user.PasswordSalt);
					Param(command, "PasswordHash", user.PasswordHash);
					command.ExecuteNonQuery();
				}
			}		
		}

		public User GetUser(string username) {
			using (var connection = Provider.CreateConnection()) {
				connection.ConnectionString = ConnectionString;
				connection.Open();

				using (var command = Provider.CreateCommand()) {
					command.Connection = connection;
					command.CommandText = "select PasswordSalt, PasswordHash from RegisteredUser where Name = @Name";
					Param(command, "Name", username);

					using (var reader = command.ExecuteReader()) {
						if (reader.Read()) {
							var passwordSalt = BytesColumn(reader, "PasswordSalt", User.PasswordSaltLength);
							var passwordHash = BytesColumn(reader, "PasswordHash", User.PasswordHashLength);
							return new User(username, passwordSalt, passwordHash);
						} else {
							return new User(username);
						}
					}
				}
			}
		}

		private void Param(DbCommand command, string name, object value) {
			var param = Provider.CreateParameter();
			param.ParameterName = "@" + name;
			param.Value = value;
			command.Parameters.Add(param);
		}

		private byte[] BytesColumn(DbDataReader reader, string column, int length) {
			var buffer = new byte[length];
			reader.GetBytes(reader.GetOrdinal(column), 0, buffer, 0, buffer.Length);
			return buffer;
		}
	}
}

