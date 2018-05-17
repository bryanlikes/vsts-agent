using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.DistributedTask.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.OAuth;
using Microsoft.VisualStudio.Services.WebApi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pipelines = Microsoft.TeamFoundation.DistributedTask.Pipelines;
using Microsoft.Win32;
using Microsoft.VisualStudio.Services.Agent.Util;

namespace Agent.Sdk
{
    public class AgentCertificateSettings
    {
        public bool SkipServerCertificateValidation { get; set; }
        public string CACertificateFile { get; set; }
        public string ClientCertificateFile { get; set; }
        public string ClientCertificatePrivateKeyFile { get; set; }
        public string ClientCertificateArchiveFile { get; set; }
        public string ClientCertificatePassword { get; set; }
        public IVssClientCertificateManager VssClientCertificateManager { get; set; }
    }

    public class AgentWebProxySettings
    {
        public string ProxyAddress { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
        public List<string> ProxyBypassList { get; set; }
        public IWebProxy WebProxy { get; set; }
    }

    public interface ITraceWriter
    {
        void Info(string message);
        void Verbose(string message);
    }
}
