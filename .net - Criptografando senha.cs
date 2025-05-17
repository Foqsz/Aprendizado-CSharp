using System.Security.Cryptography;
using System.Text;

namespace MyRecipeBook.Application.Services.Cryptografhy;

public class PasswordEncripter
{
    public string Encrypt(string password)
    {
        var chaveAdicional = "ABC";

        var newPassword = $"{password}{chaveAdicional}";

        var bytes = Encoding.UTF8.GetBytes(newPassword);
        var hashBytes = SHA512.HashData(bytes);

        return StringBytes(hashBytes);
    }

    /// <summary>
    /// convertendo um array de bytes de volta em string
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    private static string StringBytes(byte[] bytes)
    {
        var sb = new StringBuilder();
        foreach (byte b in bytes)
        {
            var hex = b.ToString("x2");
            sb.Append(hex);
        }
        return sb.ToString();
    }
}


//ativando 
        var criptografiaDeSenha = new PasswordEncripter();

        user.Password = criptografiaDeSenha.Encrypt(request.Password);
