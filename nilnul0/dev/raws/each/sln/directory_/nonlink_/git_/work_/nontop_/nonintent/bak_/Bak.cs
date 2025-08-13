using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.work_.nontop_.nonIntent
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		private nilnul.fs.address_.ShieldI1 _module;

		public nilnul.fs.address_.ShieldI1 module
		{
			get => _module;
			set => _module = value;
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI2>())
		{
			//_cfg = cfg;
		}
		public ConcurrentBag<nilnul.fs._address.DivI2> innerModules;

	


		public Bak(Io cfg, ConcurrentBag<DivI2> innerModules)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
		}

		internal void _Exe(
			string _location__nonrootWork
			)
		{

			if (nilnul.fs.folder.be_.dev_.src_.bak_._NeglectX.Be_ofAddress(_location__nonrootWork, cfg.git))
			{
				Trace.TraceWarning(
					$"{_location__nonrootWork} is neglected"
				);
			}
			else
			{
				new nonintent_.nonneglect.Bak(cfg, innerModules).Exe(_location__nonrootWork);
			}
			CancellationToken cancel = cfg.cancel;
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

						/// work
						new sln_.nonlink.directory_.nonlink_.git_.work.Bak(cfg, innerModules)
						{
							module=this.module
						}.__Exe(child);

						//if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						//{
						//	if (module != null)
						//	{
						//		innerModules.Add(
						//			nilnul.fs.address_.shield.duo_.sup._DifX1._ofAddresses(
						//				module
						//				, child
						//			)
						//		);

						//	}

						//	new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(child);
						//}
						//else
						//{
						//	new git_.plain0Nontop.Bak(cfg, innerModules) { module = this.module }._Exe(child);
						//}

					}
				}

				finally
				{
					Trace.Unindent();

				}

			}
			catch (OperationCanceledException ex)
			{
				Trace.TraceWarning($"in {this.GetType().FullName} for {_location__nonrootWork}, exception:{ex}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
