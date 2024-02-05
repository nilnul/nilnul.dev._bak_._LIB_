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

namespace nilnul.dev.srcs.each.sln.directory_.link_.giT_.work_.top
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
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

		public Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		private Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
		}





		/// <summary>
		/// 
		/// </summary>
		/// <param name="shield">
		/// a link
		/// </param>
		internal void exe(
			//ShieldI shield
		)
		{

			var old = _cfg._addDestiny_assumeLink(this._module);
			if (old.Key is null)
			{
				///unjoint
				///

				new directory_.delvable_.giT_.work_.top.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude) {module=this.module }.__exe();

			}
			else
			{
				Trace.TraceWarning(
					$"{this._module} is already processed by {old.Key}, which is linked by {old.Value}"
				);

			}

			
		}

		//public  void exe_ofAddress(
		//	string folderAddress
		//)
		//{
		//	exe(
		//		nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
		//	);
		//}
	}
}