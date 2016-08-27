using Npgsql;
using System;
using System.Data.Common;
using System.Runtime.Serialization.Json;
using AutoKennis;

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

		private volatile DataContractJsonSerializer jsonSerializer = null;

		public DataContractJsonSerializer JsonSerializer {
			get {
				if (jsonSerializer == null) {
					lock (sync) {
						if (jsonSerializer == null) {
							jsonSerializer = new DataContractJsonSerializer(typeof(FormDTO));
						}
					}
				}

				return jsonSerializer;
			}
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

		private volatile IFormDAO formDAO = null;

		public IFormDAO FormDAO {
			get {
				if (formDAO == null) {
					lock (sync) {
						if (formDAO == null) {
							formDAO = new FormDAO(DatabaseConnectionString, DatabaseProvider, JsonSerializer);
						}
					}
				}

				return formDAO;
			}
		}
	}
}

