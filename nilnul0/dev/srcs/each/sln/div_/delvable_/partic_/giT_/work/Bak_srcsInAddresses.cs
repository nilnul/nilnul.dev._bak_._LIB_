using nilnul.fs._address;
using nilnul.fs.folder;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work
{
	/// <summary>
	/// 
	/// </summary>
	///


	[Obsolete(nameof(nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_.incomplete.dir_.delve_.attend_.werk.Bak_srcsInAddresses))]

	public class Bak_srcsInAddresses
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe(
			string folderAddress
		)
		{
			try
			{
				if (nilnul.fs.folder_.git_.work.be_._TopX.__Be_ofAddress(folderAddress))
				{

					//if (module != null)
					//{
					//	innerModules.Add(
					//		nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
					//			module
					//			,
					//			folderAddress
					//		)
					//	);

					//}


					 work_.top.Bak_srcsInAddresses._Vod(cfg,this._module,this.innerModules,this.innerModules2reinclude,folderAddress);
				}
				else
				{

					new work_.nontop.Bak(cfg, innerModules,innerModules2reinclude,module) ._exe(folderAddress);
				}
			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				throw;
				return;
			}
		}
	}
}