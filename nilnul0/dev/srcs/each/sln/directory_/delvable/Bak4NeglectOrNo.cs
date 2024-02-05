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

namespace nilnul.dev.srcs.each.sln.directory_.delvable
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak4unjoint:dev.sln.directory_.delvable.IBak
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

		public Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		public Bak4unjoint(
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

			//if (
			//	//nilnul.fs.folder.be_.dev_.baK_._NeglectX
			//	fs.folder.dir.be_.deV_.baK_._NondelveX._Be_0folder(
			//		shield
			//	//,cfg.git
			//	)
			//)
			//{
			//	Trace.TraceWarning(
			//		$"{shield} is unopen;"
			//	);

			//	// todo: we don't need this,  as this shall be done in previous steps.
			//	//return;
			//}

			if (fs.folder.be_.deV_.baK_._NonparticipantX.Be(shield))
			{
				Trace.TraceWarning(
					$"{shield} wont take part in the bakking process;"
				);



				/// todo: even it's nonpartic, we need to know whether it's intended for depo, or it's worktop, such as to include it into parent module's exclude when necessary.
				/// it's probably a worktop, or intended.
				///
				new delvable_.unpartic.Bak_srcsInAddresses(this._cfg, this.innerModules, this.innerModules2reinclude, this._module).vod(
					shield
				);

				return;
			}
			new nilnul.dev.srcs.each.sln.directory_.delvable_.partic.Bak_srcsInAddresses(
				cfg, innerModules, innerModules2reinclude, module
			)
			{ }._vod(shield.ToString());

		}

		public void exe_ofAddress(
			string folderAddress
		)
		{
			_exe(
				nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
			);
		}
	}
}