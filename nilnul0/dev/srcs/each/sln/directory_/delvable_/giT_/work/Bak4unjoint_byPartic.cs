using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder_.git_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work
{
	/// <summary>
	/// assume:
	///		unclave_.unnegle_.unvsgen_.baK_._UnSkippedX, and it's delvable( as it's in extra unjoint);
	///	now we need to determine whether it's participant
	/// </summary>
	public class Bak4unjoint
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

		public Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		public Bak4unjoint(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public void __exe(string work)
		{
			cfg.cancel.ThrowIfCancellationRequested();
			if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be_ofAddress(work))
			{
				Trace.TraceWarning(
					$"{work} is neglected"
				);
				new delvable_.unpartic_.giT_.work.Bak_srcsInAddresses(
					cfg, this.innerModules, this.innerModules2reinclude
				).__exe_ofAddress(work);


				return;
			}

			new delvable_.partic_.giT_.work.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude, module).__exe_ofAddress(work);

		}

		internal void __exe(ShieldI shield)
		{
			__exe(shield.ToString());
			//throw new NotImplementedException();
		}

		public void _exe(Work work)
		{
			__exe(work.ToString());
		}


	}
}