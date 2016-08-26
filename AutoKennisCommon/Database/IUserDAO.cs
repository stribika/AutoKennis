using System;

namespace AdminPortal {
	public interface IUserDAO {
		void AddUser(User user);
		User GetUser(string name);
	}
}

