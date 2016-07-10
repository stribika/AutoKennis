using System;
using System.Runtime.Serialization.Json;

namespace AutoKennisWeb {
	public class AppConfig {
		public static AppConfig Instance { get; private set; } = new AppConfig();

		private readonly object sync = new object();

        private volatile DataContractJsonSerializer jsonSerializer = null;

        public DataContractJsonSerializer JsonSerializer
        {
            get
            {
                if (jsonSerializer == null)
                {
                    lock (sync)
                    {
                        if (jsonSerializer == null)
                        {
                            jsonSerializer = new DataContractJsonSerializer(new FormDTO().GetType());
                        }
                    }
                }

                return jsonSerializer;
            }
        }

        private volatile IFormDAO formDAO = null;

		public IFormDAO FormDAO {
			get {
				if (formDAO == null) {
					lock (sync) {
						if (formDAO == null) {
							formDAO = new FormDAO(
                                "Host=localhost;Username=AutoKennis;Database=AutoKennis",
                                Npgsql.NpgsqlFactory.Instance,
                                JsonSerializer
                            );
						}
					}
				}

				return formDAO;
			}
		}

        private volatile EmailSender emailSender = null;

        public EmailSender EmailSender {
            get
            {
                if (emailSender == null)
                {
                    lock (sync)
                    {
                        if (emailSender == null)
                        {
                            emailSender = new EmailSender(FormDAO, JsonSerializer);
                        }
                    }
                }

                return emailSender;
            }
        }
	}
}

