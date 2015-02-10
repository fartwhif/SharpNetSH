﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ignite.SharpNetSH.HTTP
{
	public sealed class SSLCertificate : IOutputObject, IMultiResponseProcessor
	{
		internal SSLCertificate()
		{ }

		public string IpPort { get; protected set; }
		public string CertificateHash { get; protected set; }
		public Guid ApplicationId { get; protected set; }
		public string CertificateStoreName { get; protected set; }
		public string VerifyClientCertificateRevocation { get; protected set; }
		public string VerifyRevocationUsingCachedClientCertificateOnly { get; protected set; }
		public string UsageCheck { get; protected set; }
		public uint RevocationFreshnessTime { get; protected set; }
		public uint URLRetrievalTimeout { get; protected set; }
		public string CtlIdentifier { get; protected set; }
		public string CtlStoreName { get; protected set; }
		public bool DsMapperUsage { get; protected set; }
		public bool NegotiateClientCertificate { get; protected set; }

		void IOutputObject.AddValue(String title, String value)
		{
			switch (title.ToLower())
			{
				case "ip:port": IpPort = value; break;
				case "certificate hash": CertificateHash = value; break;
				case "application id": ApplicationId = new Guid(value); break;
				case "certificate store name": CertificateStoreName = value; break;
				case "verify client certificate revocation": VerifyClientCertificateRevocation = value; break;
				case "verify revocation using cached client certificate only": VerifyRevocationUsingCachedClientCertificateOnly = value; break;
				case "usage check": UsageCheck = value; break;
				case "revocation freshness time": RevocationFreshnessTime = uint.Parse(value); break;
				case "url retrieval timeout": URLRetrievalTimeout = uint.Parse(value); break;
				case "ctl identifier": CtlIdentifier = value; break;
				case "ctl store name": CtlStoreName = value; break;
				case "ds mapper usage": DsMapperUsage = value.ToLower() == "enabled"; break;
				case "negotiate client certificate": NegotiateClientCertificate = value.ToLower() == "enabled"; break;
				default:
					throw new Exception("Invalid Raw Certificate Data. Title: " + title + ", Value: " + value);
			}
		}

		IEnumerable IMultiResponseProcessor.ProcessResponse(IEnumerable<string> responseLines)
		{
			var certificates = new List<SSLCertificate>();
			if (responseLines == null || responseLines.Contains("The system cannot find the file specified.")) return certificates;

			var currentCertificateRows = new List<string>();
			foreach (var line in responseLines.Skip(3))
			{
				if (String.IsNullOrWhiteSpace(line))
				{
					if (currentCertificateRows.Count > 0)
					{
						var certificate = new SSLCertificate();
						certificate.ProcessRawData(@"\s+:\s+", currentCertificateRows);
						certificates.Add(certificate);
					}
					currentCertificateRows = new List<string>();
				}
				else
					currentCertificateRows.Add(line);
			}

			return certificates;
		}
	}
}