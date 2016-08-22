using Npgsql;
using System;
using System.Data.Common;

namespace AdminPortal {
	public class AppConfig {
		public static AppConfig Instance { get; private set; } = new AppConfig();

		private readonly object sync = new object();

		public string DatabaseConnectionString {
			get { return "Host=localhost;Username=autokennis;Database=autokennis"; }
		}

		public DbProviderFactory DatabaseProvider {
			get { return NpgsqlFactory.Instance; }
		}

		private volatile IUserDAO userDAO = null;

		public IUserDAO UserDAO {
			get {
				if (userDAO == null) {
					lock (sync) {
						if (userDAO == null) {
							userDAO = new UserDAO(DatabaseConnectionString, DatabaseProvider);
						}
					}
				}

				return userDAO;
			}
		}
	}
}

