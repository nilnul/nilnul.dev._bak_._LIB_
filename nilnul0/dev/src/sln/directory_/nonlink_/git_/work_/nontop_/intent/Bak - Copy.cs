using nilnul.dev;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.giT_.work_.nontop_.intent
{
	/// <summary>
	/// 
	/// </summary>
	 public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<nilnul.fs._address.DivI>();

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		//private Bak(Io cfg, ConcurrentBag<DivI> innerModules1)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules1;
		//}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe( 
			string folderAddress
		) {
			try
			{
				if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(folderAddress, cfg.git))
				{
					Trace.TraceWarning(
						$"{folderAddress} is neglected"
					);
				}
				else
				{
					new sln_.nonlink.div_.nonlink_.nonneglect_.intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg ).Exe(folderAddress);
				}


				
			}
			catch (OperationCanceledException ex)
			{
				Trace.TraceWarning($"in {this.GetType().FullName} for {folderAddress}, exception:{ex}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" +e.Message
				);
				return ;
			}
		}
	}
}