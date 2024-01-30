using System;
using Xunit;
using AESWebAPI;

namespace UnitTests
{
    public class ServiceTests
    {
        [Fact]
        public void Encrypt_GivenPlainTextAndKey_ReturnsEncryptedText()
        {
            // Arrange
            var encryptionService = new AESEncryptionService();
            string plainText = "Hello, David!";
            string key = "giUvo4vuNheChPfP7hNWPQ==";

            // Act
            string encryptedText = encryptionService.Encrypt(plainText, key);

            // Assert
            Assert.NotNull(encryptedText);
            // Add more assertions based on your encryption service functionality
        }

        [Fact]
        public void Decrypt_GivenEncryptedTextAndKey_ReturnsDecryptedText()
        {
            // Arrange
            var encryptionService = new AESEncryptionService();
            string encryptedText = "giUvo4vuNheChPfP7hNWPQ==";
            string key = "1/y3hSibEgZwpf04";

            // Act
            string decryptedText = encryptionService.Decrypt(encryptedText, key);

            // Assert
            Assert.NotNull(decryptedText);
            // Add more assertions based on your encryption service functionality
        }
    }
}
