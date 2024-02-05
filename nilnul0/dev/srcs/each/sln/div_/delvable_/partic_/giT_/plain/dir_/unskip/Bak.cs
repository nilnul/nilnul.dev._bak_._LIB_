using nilnul.dev;
using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.plain.dir_.unskip
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="nilnul.fs.folder.dirs_.unnegle_.unvsgen_.unclave_.baK_._UnSkippedX"/>
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

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
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

		/// <summary>
		/// <see cref=""/>
		/// </summary>
		/// <param name="work"></param>
		/// <see cref="sln.directory_.giT_.plain.Bak"/>
		public void _exe(
			string work
		)
		{
			if (nilnul.fs.folder.dir.be_._SymlinkX.Be_ofAddress(work))
			{
				new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.plain.dir_.unskip_.link.Bak4unjoint(_cfg,innerModules,innerModules2reinclude) {module=this.module  }.exe_ofAddress(work);

				//new directory_.link_.giT_.plain.Bak4unjoint(_cfg,innerModules,innerModules2reinclude) {module=this.module  }.exe_ofAddress(work);
				return;

			}

			new unskip_.unjoint.Bak4unjoint(cfg,innerModules,innerModules2reinclude) { module=this.module}.__exe(work);

			//new directory_.delvable_.giT_.plain.Bak4unjoint(cfg,innerModules,innerModules2reinclude) { module=this.module}.__exe(work);

			

		}
	}
}
