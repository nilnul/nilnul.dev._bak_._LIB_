using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.work
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI2> innerModules;

		private nilnul.fs.address_.ShieldI1 _module;

		public nilnul.fs.address_.ShieldI1 module
		{
			get => _module;
			set => _module = value;
		}


		public Bak(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
			,
			ConcurrentBag<nilnul.fs._address.DivI2> innerModules
		)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
		}

		public void __Exe(string work)
		{

			if (nilnul.fs.folder.be_.dev_.src_.bak_._NeglectX.Be_ofAddress(work, cfg.git))
			{
				Trace.TraceWarning(
					$"{work} is neglected"
				);
				//if (module != null)
				//{
				//	innerModules.Add(
				//		nilnul.fs.address_.shield.duo_.sup._DifX1._ofAddresses(
				//			module
				//			,
				//			work
				//		)
				//	);

				//}
			}
			else
			{
				new nonlink_.nonneglect.Bak(cfg, innerModules) { module = this.module }.void_ofAddress(work);
			}


			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(work, cfg.git)
			)
			{
				new work_.top.Bak(cfg).__Exe(work);
			}
			else
			{
				new work_.nontop.Bak(cfg, innerModules)._exe(work);
			}
		}



		public void _Exe(Work1 work)
		{
			__Exe(work.ToString());
		}


	}
}