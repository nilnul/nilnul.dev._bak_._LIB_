﻿using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.giT_.work_.nontop_.nonintent
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;


		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;


		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		internal void _Exe(
			string _location__nonrootWork
			)
		{
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

						/// work or detached repo
						/// 
						new sln_.nonlink.directory_.nonlink_.giT_.nonplain.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude)
						{
							module = this.module
						}._void(child);

						//if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						//{
						//	if (module != null)
						//	{
						//		innerModules.Add(
						//			nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
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
