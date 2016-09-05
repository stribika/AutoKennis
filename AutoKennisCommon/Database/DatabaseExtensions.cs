using System;
using System.Collections.Generic;
using System.Data.Common;

namespace AutoKennis
{
	public static class DatabaseExtensions
	{
		public static void SetParameter<T>(this DbCommand command, string name, T value)
		{
			var param = command.CreateParameter();
			param.ParameterName = "@" + name;
			param.Value = value;
			command.Parameters.Add(param);
		}

		public static T QueryForOne<T>(this DbConnection connection, string sql, Func<DbDataReader, T> func)
		{
			return connection.QueryForOne(sql, new Dictionary<string, object>(), func);
		}

		public static T QueryForOne<T>(this DbConnection connection, string sql, IDictionary<string, object> parameters, Func<DbDataReader, T> func)
		{
			var result = connection.Query(sql, parameters, func);
			return result[0];
		}

		public static IList<T> Query<T>(this DbConnection connection, string sql, Func<DbDataReader, T> func)
		{
			return connection.Query(sql, new Dictionary<string, object>(), func);
		}

		public static IList<T> Query<T>(this DbConnection connection, string sql, IDictionary<string, object> parameters, Func<DbDataReader, T> func)
		{
			IList<T> result = new List<T>();

			using (var command = connection.CreateCommand()) {
				command.CommandText = sql;

				foreach (var name in parameters.Keys) {
					command.SetParameter(name, parameters[name]);
				}

				var reader = command.ExecuteReader();

				if (reader.HasRows) {
					while (reader.Read()) {
						result.Add(func(reader));
					}
				}
			}

			return result;
		}
	}
}

