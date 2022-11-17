using nilnul.fs._address;
using nilnul.fs.folder;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.intent
{
	/// <summary>
	/// gien srcs, bak a disjoint addresses.
	/// </summary>
	///
	[Obsolete("categorize according to git first; then depth1st; then for the intent.")]
	public  class Bak_srcsInAddress
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

		public Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		private Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Bak_srcsInAddress(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
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
			if (module != null)
			{
				innerModules.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						module
						,
						folderAddress
					)
				);
			}

			try
			{
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folderAddress))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain: /// it can also be that the module is corrupeted
						new giT_.plain_.intent.Bak(cfg)._Exe(folderAddress);
						//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg).Exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						new giT_.work_.intent.Bak_srcsInAddresses(cfg).Exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:  //bare;
																			  //or can it be nonbare repo? If it is, the parent must be worktop,
																			  // even if it is gitRepoNonbare, we can still exclude it without harm;
						break;
					default:
						Trace.TraceError(
							$"{folderAddress} is triaged into an unknown category other than Plain|Work|Repo"
						);
						break;
				}
			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (System.IO.IOException ex)
			{

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