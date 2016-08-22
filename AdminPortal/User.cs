using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using CryptSharp.Utility;

namespace AdminPortal {
	public class User {
		public const int PasswordSaltLength = 16;

		public const int PasswordHashLength = 16;

		public string Name { get; private set; }

		public byte[] PasswordSalt { get; private set; }

		public byte[] PasswordHash { get; private set; }

		public User(string name): this(name, new byte[PasswordSaltLength], new byte[PasswordHashLength]) {
		}

		public User(string name, string password) {
			Name = name;

			using (var csprng = new RNGCryptoServiceProvider()) {
				PasswordSalt = new byte[PasswordSaltLength];
				csprng.GetBytes(PasswordSalt);
			}

			PasswordHash = CalculateHash(password);
		}

		public User(string name, byte[] passwordSalt, byte[] passwordHash) {
			Name = name;
			PasswordSalt = passwordSalt;
			PasswordHash = passwordHash;
		}

		public override bool Equals(object obj) {
			var that = obj as User;

			if (that == null) {
				return false;
			}

			return this.Name.Equals(that.Name)
				&& this.PasswordSalt.Equals(that.PasswordSalt)
				&& this.PasswordHash.Equals(that.PasswordHash);
		}

		public override int GetHashCode() {
			unchecked {
				int hashCode = typeof(User).GetHashCode();
				hashCode ^= 7 * hashCode + 11 * Name.GetHashCode();
				hashCode ^= 7 * hashCode + 11 * PasswordSalt.GetHashCode();
				hashCode ^= 7 * hashCode + 11 * PasswordHash.GetHashCode();
				return hashCode;
			}
		}

		public bool Validate(string password) {
			return Enumerable.SequenceEqual(PasswordHash, CalculateHash(password));
		}

		private byte[] CalculateHash(string password) {
			var passwordBytes = Encoding.UTF8.GetBytes(password);
			return SCrypt.ComputeDerivedKey (passwordBytes, PasswordSalt, 128, 8, 4, 4, PasswordHashLength);
		}
	}
}

