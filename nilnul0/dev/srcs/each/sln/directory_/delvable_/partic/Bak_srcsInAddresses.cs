//using nilnul.dev.src.div.dir.cognomen_.commentedSegs._parse.parener._dotter.lex.symbol_;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.partic
{
	//[Obsolete("categorize according to git first; then depth1st; then for the intent.")]
	/// <summary>
	/// by git category.
	/// </summary>
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

		public void _vod(
			string folderAddress
			
		)
		{
			try
			{
				switch (nilnul.fs.folder.categorize_.git_.plainWorkRepo_.Deadlined.Category_ofAddress(folderAddress))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
						new nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.plain.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module=_module}._exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						new partic_.giT_.work.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) {module=_module }.__exe_ofAddress(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						break;
					default:
						Trace.TraceError(
							$"{folderAddress} is triaged into an unknown category other than Plain|Work|Repo"
						);
						break;
				}
			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing by {this.GetType().FullName}: {folderAddress}: {e}");
				throw;
			}

			catch (Exception e) //for example timeout
			{
				Trace.TraceWarning($"exception in categorize for git in baking  by {this.GetType().FullName}: {folderAddress}: {e}");
			}

		}

		public void vod(
			nilnul.fs.address_.ShieldI folder
			
		)
		{

			_vod(folder.ToString());
		}
		public  void vod_ofAddress(
			string _shield
		)
		{
			vod(
				nilnul.fs.address_.shield_._AddressX1.Create(_shield)
				
			);
		}

	}
}
