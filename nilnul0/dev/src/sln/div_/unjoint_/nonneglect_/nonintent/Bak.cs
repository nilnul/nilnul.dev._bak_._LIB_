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

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.nonintent
{
	public class Bak
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

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public void _void(
			string folderAddress
		)
		{
			try
			{
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folderAddress))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
						new nonintent_.giT_.plain.Bak(cfg,innerModules,innerModules2reinclude,module)._vod(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						new giT_.work_.nonintent.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude,module).Exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						break;
					default:
						Trace.TraceError(
							$"{folderAddress} is triaged into an unknown category other than Plain|Work|Repo"
						);
						break;
				}




			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing by {this.GetType().FullName}: {folderAddress}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{folderAddress}: {e} ");
			}


		}


	}
}
