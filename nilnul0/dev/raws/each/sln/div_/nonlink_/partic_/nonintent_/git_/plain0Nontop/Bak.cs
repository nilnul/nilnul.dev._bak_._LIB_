using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.nonintent_.git_.plain0Nontop
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public Bak(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
			,         
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
		}




		public void _void(
			string _location__nonrootWork
		)
		{
			
			try
			{
				if (cfg.cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before {_location__nonrootWork}");
					return;
				}
				//Trace.TraceInformation($"beginning {_location__nonrootWork}...");
				Trace.Indent();
				try
				{

					foreach (var child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(
						_location__nonrootWork))
					{
						if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						{
							new nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(child);
						}
						else
						{
							new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.plain0nontop_.nonIntent.Bak(cfg,innerModules)._Exe(child);
						}

					}
				}
				finally
				{
					Trace.Unindent();

				}
			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing by {this.GetType().FullName}: {_location__nonrootWork}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
