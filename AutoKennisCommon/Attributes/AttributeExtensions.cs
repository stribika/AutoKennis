using System;
using System.Reflection;
namespace AutoKennis
{
	public static class AttributeExtensions
	{
		public static string GetDescription<T>(this T enumValue) where T: struct
		{
			if (!typeof(T).IsEnum) { return null; }

			var members = typeof(T).GetMember(enumValue.ToString());

			foreach (var mem in members) {
				var attr = mem.GetCustomAttribute<DescriptionAttribute>();

				if (attr != null) { return attr.Description; }
			}

			return null;
		}

		public static string GetTableName(this FormType formType)
		{
			return formType.ToString() + "Form";
		}
	}
}

