using nilnul.fs;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div.dir
{
	/// <summary>
	/// whether this as a dir is unjoint, is unknown
	/// </summary>
	///
	[Obsolete()]
	public  class Bak_srcsInAddresses
		:nilnul.dev.sln.div._dir.IBak
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


		public void __exe(
			nilnul.fs.address_.shield_.BaseDir folder
		)
		{
			if (nilnul.fs.folder.dir.be_._SymlinkX._Be(folder) )
			{
				new dir_.link.Bak4unjoint(_cfg, innerModules,innerModules2reinclude,module).exe(folder);
				return;

			}
			new directory_.delvable.Bak4unjoint(_cfg, innerModules,innerModules2reinclude,module)._exe(folder);

		}

		// void __exe(
		//	string folder
		//)
		//{


		//}


	
	}
}