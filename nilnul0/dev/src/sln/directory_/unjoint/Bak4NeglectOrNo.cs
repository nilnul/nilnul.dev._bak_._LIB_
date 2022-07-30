using nilnul.dev;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shields_;
using nilnul.win.program_;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.directory_.unjoint
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak4unjoint
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

		public Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		private Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Bak4unjoint(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}



		internal void _exe(
			ShieldI shield
		)
		{
			cfg.cancel.ThrowIfCancellationRequested();
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be(shield,cfg.git) )
			{
				Trace.TraceWarning(
					$"{shield} is neglected"
				);
			}
			else
			{
				new unjoint_.nonneglect.Bak_srcsInAddresses(
					cfg, innerModules,innerModules2reinclude,module
				) { }.__exe(shield.ToString());
			}
		}

		public  void exe_ofAddress(
			string folderAddress
		)
		{
			_exe(
				nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
			);
		}
	}
}