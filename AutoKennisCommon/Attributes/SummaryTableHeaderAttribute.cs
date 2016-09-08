using System;
namespace AutoKennis
{
	public class SummaryTableHeaderAttribute: Attribute
	{
		public readonly string ColumnName;

		public SummaryTableHeaderAttribute(string columnName)
		{
			ColumnName = columnName;
		}
	}
}

