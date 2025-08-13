using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder;


namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.intent_.git_.plain0Nontop.bak_
{
	/// <summary>
	/// 
	/// </summary>
	public class ReportNewModule
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI2> innerModules ;


		public ReportNewModule(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI2>())
		{
			_cfg = cfg;
		}

		//private Bak(Io cfg, ConcurrentBag<DivI2> innerModules1)
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
		public bool isModuleNewed(
			string folderAddress
		)
		{


			if (nilnul.fs.folder.be_.HasDocument.Singleton.Be_ofAddress(folderAddress))
			{
				new plain0Nontop_.nonempty.Bak(cfg).Exe(folderAddress);
			}
			else
			{
				Trace.TraceWarning($"intendGit:{folderAddress} is empty");

			}
		}
	}
}