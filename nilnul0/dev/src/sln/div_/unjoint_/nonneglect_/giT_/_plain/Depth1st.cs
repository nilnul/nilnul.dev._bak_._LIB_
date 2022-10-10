using nilnul.dev;
using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_._plain
{
	/// <summary>
	/// 
	/// </summary>
	public class Depth1st
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
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



		public void _vod(
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

					foreach (var child in nilnul.fs.folder.dirs_._ExcludeVsX.EnumerateAsAddresses(
						_location__nonrootWork))
					{
						var gitCategory = nilnul.fs.folder.categorize_.giT_.plainWorkRepo_._ByIsInsideGitDirX.Category_ofAddress(_location__nonrootWork);

						switch (gitCategory)
						{
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

								new nilnul.dev.src.sln.directory_.giT_.plain.Bak(
									cfg
									,
									innerModules
									,
									innerModules2reinclude
								)
								{ module=this.module}._Exe(child);

								break;
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

								///it must be top

								new nilnul.dev.src.sln.directory_.giT_.work_.top.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module=this.module}.__exe(child);

								break;
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
								/// it must be bare.
								/// 
								break;
							default:
								break;
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
