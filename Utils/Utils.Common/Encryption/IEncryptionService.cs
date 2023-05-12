namespace Utils.Common.Encryption
{
    public interface IEncryptionService
    {
        string Encrypt(string key, string data);
        string Decrypt(string key, string data);
        string GenerateEncryptionKey();
    }
}