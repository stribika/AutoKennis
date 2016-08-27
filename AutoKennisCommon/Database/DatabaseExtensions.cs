using System;
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
	}
}

