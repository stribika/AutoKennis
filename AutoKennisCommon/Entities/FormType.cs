using System;
namespace AutoKennis
{
	public enum FormType
	{
		[Description("Auto-Advies")]
		AutoAdvies,

		[Description("Aankoop-Begeleiding")]
		AankoopBegeleiding,

		[Description("Aankoop-Keuring")]
		AankoopKeuring,

		[Description("Garantie-Keuring")]
		GarantieKeuring,

		[Description("Reparatie-Keuring")]
		ReparatieKeuring,
	}
}

