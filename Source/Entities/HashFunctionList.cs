using System;
using System.Text;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace CSharpChecksum.Entities
{
	public class HashFunctionList
	{
		public static string Hash(string hash_function, byte[] data)
		{
			IDigest hash;
			switch (hash_function)
			{
				case "Blake2b - 256 bit":
					hash = new Blake2bDigest(256);
					break;
				case "Blake2b - 512 bit":
					hash = new Blake2bDigest(512);
					break;
				case "SHA-1":
					hash = new Sha1Digest();
					break;
				case "SHA-2 256 bit":
					hash = new Sha256Digest();
					break;
				case "SHA-2 512 bit":
					hash = new Sha512Digest();
					break;
				case "SHA-3 256 bit":
					hash = new Sha3Digest(256);
					break;
				case "SHA-3 512 bit":
					hash = new Sha3Digest(512);
					break;
				default:
					hash = new Sha1Digest();
					break;
			}

			byte[] result = new byte[hash.GetDigestSize()];
			hash.BlockUpdate(data, 0, data.Length);
			hash.DoFinal(result, 0);
			Array.Clear(data, 0, data.Length);
			return ByteArrayToHexString(result);
		}
		
		public static string[] GetHashList()
		{
			string[] list = new string[7];
			list[0] = "Blake2b - 256 bit";
			list[1] = "Blake2b - 512 bit";
			list[2] = "SHA-1";
			list[3] = "SHA-2 256 bit";
			list[4] = "SHA-2 512 bit";
			list[5] = "SHA-3 256 bit";
			list[6] = "SHA-3 512 bit";
			return list;
		}

		public static string ByteArrayToHexString(byte[] Bytes)
		{
			StringBuilder Result = new StringBuilder(Bytes.Length * 2);
			string HexAlphabet = "0123456789ABCDEF";

			foreach (byte B in Bytes)
			{
				Result.Append(HexAlphabet[(int)(B >> 4)]);
				Result.Append(HexAlphabet[(int)(B & 0xF)]);
			}

			return Result.ToString();
		}

		private static byte[] HexStringToByteArray(string Hex)
		{
			byte[] Bytes = new byte[Hex.Length / 2];
			int[] HexValue = new int[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05,
	   0x06, 0x07, 0x08, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
	   0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };

			for (int x = 0, i = 0; i < Hex.Length; i += 2, x += 1)
			{
				Bytes[x] = (byte)(HexValue[Char.ToUpper(Hex[i + 0]) - '0'] << 4 |
								  HexValue[Char.ToUpper(Hex[i + 1]) - '0']);
			}

			return Bytes;
		}

		private static string ToHex(byte[] bytes)
		{
			char[] c = new char[bytes.Length * 2];

			byte b;

			for (int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx)
			{
				b = ((byte)(bytes[bx] >> 4));
				c[cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);

				b = ((byte)(bytes[bx] & 0x0F));
				c[++cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);
			}

			return new string(c);
		}

		private static byte[] HexToBytes(string str)
		{
			if (str.Length == 0 || str.Length % 2 != 0)
				return new byte[0];

			byte[] buffer = new byte[str.Length / 2];
			char c;
			for (int bx = 0, sx = 0; bx < buffer.Length; ++bx, ++sx)
			{
				// Convert first half of byte
				c = str[sx];
				buffer[bx] = (byte)((c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0')) << 4);

				// Convert second half of byte
				c = str[++sx];
				buffer[bx] |= (byte)(c > '9' ? (c > 'Z' ? (c - 'a' + 10) : (c - 'A' + 10)) : (c - '0'));
			}

			return buffer;
		}

		public static string HashFileExtension(string hash_function)
		{
			string extension;

			switch (hash_function)
			{
				case "Blake2b - 256 bit":
					extension = ".blake2b256";
					break;
				case "Blake2b - 512 bit":
					extension = ".blake2b512";
					break;
				case "SHA-1":
					extension = ".sha1";
					break;
				case "SHA-2 256 bit":
					extension = ".sha2-256";
					break;
				case "SHA-2 512 bit":
					extension = ".sha2-512";
					break;
				case "SHA-3 256 bit":
					extension = ".sha3-256";
					break;
				case "SHA-3 512 bit":
					extension = ".sha3-512";
					break;
				default:
					extension = ".sha1";
					break;
			}

			return extension;
		}
	}
}
