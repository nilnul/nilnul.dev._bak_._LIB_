#define BAK_SERIAL0
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.src.sln.directory_.giT_.nonplain_.work0bare
{
	/// <summary>
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

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
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>

		public void _void(
			string folder
		)
		{

			///shuffle the namespace segment.
			///

			if (nilnul.fs.folder.dir.be_._SymlinkX.Be_ofAddress(folder))
			{
				new directory_.link.Bak4unjoint(_cfg, innerModules).exe_ofAddress(work);

			}

			else
			{
				new directory_.unjoint_.giT_.work.Bak4unjoint(cfg, innerModules) { module = this.module }.__exe(work);
			}





			//Trace.TraceInformation($@"baking {typeof(Bak).FullName}:{folder}...");

			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cfg.cancel.ThrowIfCancellationRequested();
				return;// false;
			}

			win.prog_.Git git = cfg.git;


			if (nilnul.fs.folder.be_.git_.Work.Singleton.be_ofAddress(folder))
			{
				new directory_.nonlink_.giT_.work.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude) { module=this.module}.__Exe(folder);
			}
			else
			{
				return;
			}

			//Trace.TraceInformation($@"baked {typeof(Bak).FullName}:{folder}");




		}
	}
}
