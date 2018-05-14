
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.Services.Common;

namespace Agent.Sdk
{
    public class AgentClientCertificateManager : IVssClientCertificateManager
    {
        private readonly X509Certificate2Collection _clientCertificates = new X509Certificate2Collection();
        public X509Certificate2Collection ClientCertificates => _clientCertificates;
        public AgentClientCertificateManager(string clientCertificateArchiveFile, string clientCertificatePassword)
        {
            if (!string.IsNullOrEmpty(clientCertificateArchiveFile))
            {
                _clientCertificates.Add(new X509Certificate2(clientCertificateArchiveFile, clientCertificatePassword));
            }
        }
    }
}