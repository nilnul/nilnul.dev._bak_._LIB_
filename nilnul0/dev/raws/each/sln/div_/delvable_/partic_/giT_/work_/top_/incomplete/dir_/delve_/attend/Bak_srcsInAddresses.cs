using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_;
using nilnul.fs._address;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_.incomplete.dir_.delve_.attend
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

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		public void __exe_ofAddress(string address4dir)
		{


			//Trace.TraceInformation($@"baking {typeof(Bak).FullName}:{folder}...");

			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {this.GetType().FullName} for {address4dir}");
				cfg.cancel.ThrowIfCancellationRequested();
				return;// false;
			}



			if (new nilnul.fs.folder.be_.git_.Work(cfg.git).be_ofAddress(address4dir))
			{
				new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_.incomplete.dir_.delve_.attend_.werk.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude,module) { }.__exe_0address4dir(address4dir);
				return;
			}

			/// it's a rack
			//Trace.TraceInformation($@"baked {typeof(Bak).FullName}:{folder}");

		}



		public void _Exe(Work work)
		{
			__exe_ofAddress(work.ToString());
		}


	}

}