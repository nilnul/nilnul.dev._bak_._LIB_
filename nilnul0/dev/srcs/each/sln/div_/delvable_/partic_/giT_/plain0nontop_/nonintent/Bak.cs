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

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.plain0nontop_.nonintent
{
	public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg):this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
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

					foreach (var child in nilnul.fs.folder.dirs_._ExcludeVsX.EnumerateAsAddresses(
						_location__nonrootWork))
					{
						var gitCategory = nilnul.fs.folder.categorize_.giT_.plainWorkRepo_._ByIsInsideGitDirX.Category_ofAddress(_location__nonrootWork);

						switch (gitCategory)
						{
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

								break;
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

								new nilnul.dev.src.sln.div_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(child);

								break;
							case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
								/// it must be bare.
								/// 
								break;
							default:
								break;
						}

						if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						{
							new nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(child);
						}
						else
						{
							new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.plain0Nontop.Bak(cfg,innerModules)._Exe(child);
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
