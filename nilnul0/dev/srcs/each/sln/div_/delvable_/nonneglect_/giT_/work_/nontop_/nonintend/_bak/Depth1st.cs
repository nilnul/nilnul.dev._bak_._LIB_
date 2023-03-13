using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.nontop._bak
{
	/// <summary>
	/// depth first traverse
	/// </summary>
	public class Depth1st
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

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Depth1st(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Depth1st(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Depth1st(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Depth1st(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}


		internal void _exe(
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
					var neglected = nilnul.fs.folder.dnts_._neglect._cfg_.doc_._DefaultX.Captions_ofAddress(_location__nonrootWork);

					foreach (
						var dir
						in
						nilnul.fs.folder.dirs_.notDotLed_.deV_._ExcludeAutogenX.Dirs_ofAddress(
							_location__nonrootWork
						)
					)
					{
						var dnt = dir.denote.en;

						if (
							neglected.Contains(
								dnt
								,
								nilnul.txt.eq_.CaseInsensitive.Singleton
							)
						)
						{
							continue;
						}

						var child = System.IO.Path.Combine(_location__nonrootWork, dnt);

						cancel.ThrowIfCancellationRequested();

						/// nonplain
						/// work(top or nontop) or  repo_.bare (not repo_.embed)
						/// 

						switch (
							nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(
								child
							)
						){
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
								///top or nontop
								new nilnul.dev.src.sln.directory_.giT_.work.Bak_srcsInAddresses(
									cfg, this.innerModules,this.innerModules2reinclude
									) { module=this.module}.__exe(child);


								break;
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
								

								break;
							default:
								/// if the dir is a crashed/corrupted module, then git would indicate it's plain of the trichonotomy
								Trace.TraceError(
									$"{child} as a dir under a module is triaged into an unknown category other than Work|Repo;  if the dir is a crashed/corrupted module,or the owner is not the current user, then git would indicate it's plain of the trichonotomy; we would not traverse into it, and plz check/rectify it."
								);

								break;
						}

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
