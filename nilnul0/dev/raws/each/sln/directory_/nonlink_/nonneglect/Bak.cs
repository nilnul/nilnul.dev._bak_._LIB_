using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public Bak(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
		)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
		}


		public void void0(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			string shieldTxt = _shield.ToString();
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(shieldTxt)
			)
			{
				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.plain.Bak(cfg) { }._exe_ofAddress(shieldTxt);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work.Bak(cfg, innerModules) {module=this.module }._Exe(
					   nilnul.fs.folder_.git_.Work.FroAddress(shieldTxt)
				   );
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return;
					break;

				default:
					Trace.TraceError($"sln {shieldTxt}:unknown git.folder.Category");
					return;
			}
		}

		public  void void_ofAddress(
			string _shield
		)
		{
			void0(
				nilnul.fs.address_.shield_._AddressX1.Create(_shield)
				
			);
		}
	}
}
