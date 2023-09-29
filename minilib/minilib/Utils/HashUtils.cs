using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace minilib.Utils;

/// <summary>
/// Provides utility methods for hashing.
/// </summary>
public static class HashUtils
{
  /// <summary>
  /// Returns the MD5 hash of the specified input string.
  /// </summary>
  /// <param name="input">The input string.</param>
  /// <returns>The MD5 hash of the specified input.</returns>
  public static string Md5(string input) => Md5(Encoding.Default.GetBytes(input));

  /// <summary>
  /// Returns the MD5 hash of the specified input bytes using .NET's default encoding.
  /// </summary>
  /// <param name="input">The input bytes.</param>
  /// <returns>The MD5 hash of the specified input.</returns>
  public static string Md5(byte[] input) => GetHash(MD5.Create(), input);

  /// <summary>
  /// Returns the SHA1 hash of the specified input string.
  /// </summary>
  /// <param name="input">The input string.</param>
  /// <returns>The SHA1 hash of the specified input.</returns>
  public static string Sha1(string input) => Sha1(Encoding.Default.GetBytes(input));

  /// <summary>
  /// Returns the SHA1 hash of the specified input bytes using .NET's default encoding.
  /// </summary>
  /// <param name="input">The input bytes.</param>
  /// <returns>The SHA1 hash of the specified input.</returns>
  public static string Sha1(byte[] input) => GetHash(SHA1.Create(), input);

  /// <summary>
  /// Returns the SHA256 hash of the specified input string.
  /// </summary>
  /// <param name="input">The input string.</param>
  /// <returns>The SHA256 hash of the specified input.</returns>
  public static string Sha256(string input) => Sha256(Encoding.Default.GetBytes(input));

  /// <summary>
  /// Returns the SHA256 hash of the specified input bytes using .NET's default encoding.
  /// </summary>
  /// <param name="input">The input bytes.</param>
  /// <returns>The SHA256 hash of the specified input.</returns>
  public static string Sha256(byte[] input) => GetHash(SHA256.Create(), input);

  /// <summary>
  /// Returns the SHA384 hash of the specified input string.
  /// </summary>
  /// <param name="input">The input string.</param>
  /// <returns>The SHA384 hash of the specified input.</returns>
  public static string Sha384(string input) => Sha384(Encoding.Default.GetBytes(input));

  /// <summary>
  /// Returns the SHA384 hash of the specified input bytes using .NET's default encoding.
  /// </summary>
  /// <param name="input">The input bytes.</param>
  /// <returns>The SHA384 hash of the specified input.</returns>
  public static string Sha384(byte[] input) => GetHash(SHA384.Create(), input);

  /// <summary>
  /// Returns the SHA512 hash of the specified input string.
  /// </summary>
  /// <param name="input">The input string.</param>
  /// <returns>The SHA512 hash of the specified input.</returns>
  public static string Sha512(string input) => Sha512(Encoding.Default.GetBytes(input));

  /// <summary>
  /// Returns the SHA512 hash of the specified input bytes using .NET's default encoding.
  /// </summary>
  /// <param name="input">The input bytes.</param>
  /// <returns>The SHA512 hash of the specified input.</returns>
  public static string Sha512(byte[] input) => GetHash(SHA512.Create(), input);

  /// <summary>
  /// Computes the hash of the specified bytes using the specified hash algorithm and returns a lowercase hex string representation of it.
  /// </summary>
  /// <param name="hashAlgorithm">The hash algorithm.</param>
  /// <param name="bytes">The input bytes.</param>
  /// <returns>A lowercase hex string representation of the computed hash</returns>
  public static string GetHash(HashAlgorithm hashAlgorithm, byte[] bytes) =>
    // Compute the hash and return a lowercase hex string representation of it.
    BitConverter.ToString(hashAlgorithm.ComputeHash(bytes)).Replace("-", "");
}
