using System;

namespace AutoKennis {
	public interface IUserDAO {
		void AddUser(User user);
		User GetUser(string name);
		bool IsFirstRun();
	}
}

