using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.intent_.git_.plain_.nonempty
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules=new ConcurrentBag<DivI>();


		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		//public Bak(Io cfg, ConcurrentBag<DivI> innerModules1)
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
		)
		{


			CancellationToken cancel = cfg.cancel;
			win.prog_.Git git = cfg.git;

			try
			{
				cancel.ThrowIfCancellationRequested();


				try
				{
					plain0Nontop_.nonempty._bak._IniX.Setup(folderAddress, git);

					cancel.ThrowIfCancellationRequested();
					new sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete_.moduleUndone.Bak(cfg)._Exe(folderAddress);


				}
				catch (Exception e)
				{
					//ini failed 
					throw;

				}



			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				throw;
				return;
			}
		}
	}
}