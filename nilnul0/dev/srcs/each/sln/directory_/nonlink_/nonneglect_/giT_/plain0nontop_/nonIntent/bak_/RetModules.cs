using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.plain0nontop_.nonIntent.bak_
{
	public class RetModules
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public RetModules(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		internal void _Exe(
			string _location__nonrootWork
			)
		{
			var cancel = cfg.cancel;
			try
			{
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before {_location__nonrootWork}");
					cancel.ThrowIfCancellationRequested();
					return;

				}
				//Trace.TraceInformation($"beginning {_location__nonrootWork}...");
				Trace.Indent();
				try
				{
					foreach (string child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(
										_location__nonrootWork))
					{
						cancel.ThrowIfCancellationRequested();
						if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						{
							new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(child);
						}
						else
						{
							new git_.plain0Nontop.Bak(cfg,innerModules)._Exe(child);
						}

					}
				}

				finally
				{
					Trace.Unindent();

				}

			}
			
			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
