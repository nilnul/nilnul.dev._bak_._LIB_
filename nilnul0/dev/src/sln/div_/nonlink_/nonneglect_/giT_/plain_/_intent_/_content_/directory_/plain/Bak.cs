using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.plain_._intent_.directory_.plain
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private nilnul.fs.address_.ShieldI _module0Intent;

		public nilnul.fs.address_.ShieldI module0Intent
		{
			get => _module0Intent;
			set => _module0Intent = value;
		}


		public Bak(Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		public Bak(Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		public void __Exe(string work)
		{
			var workBe = new nilnul.fs.folder.be_.git_.Work(cfg.git);
			foreach (string child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(work))
			{
				if (cfg.cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelling {work}");
					cfg.cancel.ThrowIfCancellationRequested();
					return;
					break;
				}
				if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(child))
				{
					continue;
				}

				if (
					 workBe.be_ofAddress(child)
				)
				{
					if (module0Intent != null)
					{
						innerModules.Add(
							nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
								module0Intent
								,
								child
							)
						);
					}
					new dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top.Bak(cfg)._void(work);
				}
				else
				{

					new plain.Bak(cfg, innerModules, innerModules2reinclude) { module0Intent = this.module0Intent }.__Exe(work);
				}
			}
		}



		public void _Exe(Work work)
		{
			__Exe(work.ToString());
		}


	}
}