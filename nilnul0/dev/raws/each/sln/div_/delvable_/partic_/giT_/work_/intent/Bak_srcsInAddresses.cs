using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using nilnul.fs.folder;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.intent
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete("depth first, see workTop or work nontop", false)] // for sln, the intent is known.

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


		Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, nilnul.fs.address_.ShieldI module)
			: this(cfg, new ConcurrentBag<DivI>(), new ConcurrentBag<DivI>(), module)
		{

		}
		public Bak_srcsInAddresses(Io cfg, string folderOfIntent) : this(
				cfg
				,
				nilnul.fs.address_.Shield.FroAddress(folderOfIntent)
			)
		{
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		public Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void vod(
		//string folderAddress
		)
		{
			var folderAddress = this._module.ToString();
			try
			{
				if (nilnul.fs.folder_.git_.work.be_._TopX.__Be_ofAddress(folderAddress))
				{
					new delvable_.partic_.giT_.work_.top.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude, module)._vod();
				}
				else///it cannot be ".git"
				{


					//new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop_.intent.Bak(cfg,innerModules,innerModules2reinclude,module)._exe(folderAddress);
					new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop_.intent.Bak(
						cfg, innerModules, innerModules2reinclude)
					{ module = this._module }._exe();


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
		static public void Exe(
Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent, ConcurrentBag<DivI> innerModulesReinclude4Parent,
			string folderAddress
		)
		{

			if (parentModule is not null)
			{
				innerModules4Parent.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						parentModule
						,
						folderAddress
					)
				);
			}

			new Bak_srcsInAddresses(cfg, folderAddress).vod();

		}

	}
}