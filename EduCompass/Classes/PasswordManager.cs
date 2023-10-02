using System;
using System.Security.Cryptography;

namespace EduCompass.Classes;

public class PasswordManager
{
    public static string HashPassword(string password)
    {
        // Generate a random salt
        byte[] salt;
        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

        // Create the hash and combine it with the salt
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
        byte[] hash = pbkdf2.GetBytes(20);
        byte[] hashBytes = new byte[36];
        Array.Copy(salt, 0, hashBytes, 0, 16);
        Array.Copy(hash, 0, hashBytes, 16, 20);

        // Convert the hashed password to a string and return it
        string hashedPassword = Convert.ToBase64String(hashBytes);
        return hashedPassword;
    }

    public static bool VerifyPassword(string password, string hashedPassword)
    {
        // Convert the hashed password from string to bytes
        byte[] hashBytes = Convert.FromBase64String(hashedPassword);

        // Get the salt from the hashed password
        byte[] salt = new byte[16];
        Array.Copy(hashBytes, 0, salt, 0, 16);

        // Create the hash with the given salt
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
        byte[] hash = pbkdf2.GetBytes(20);

        // Compare the generated hash with the stored hash
        for (int i = 0; i < 20; i++)
        {
            if (hashBytes[i + 16] != hash[i])
            {
                return false;
            }
        }

        return true;
    }
}