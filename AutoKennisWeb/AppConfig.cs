using System;

namespace AutoKennisWeb {
	public class AppConfig {
		public static AppConfig Instance { get; private set; } = new AppConfig();

		private readonly object sync = new object();

		private volatile IFormDAO formDAO = null;

		public IFormDAO FormDAO {
			get {
				if (formDAO == null) {
					lock (sync) {
						if (formDAO == null) {
							formDAO = new FormDAO("Host=localhost;Username=AutoKennis;Database=AutoKennis", Npgsql.NpgsqlFactory.Instance);
						}
					}
				}

				return formDAO;
			}
		}
	}
}

