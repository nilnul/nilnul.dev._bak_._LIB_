using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.plain0Nontop
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
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




		public Bak(Io cfg, ConcurrentBag<DivI> innerModules1)
		{
			this.cfg = cfg;
			this.innerModules = innerModules1;
		}

		private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//	_cfg = cfg;
		}


		public void _Exe(
			string folder
		)
		{

			//try
			//{
			if (
			nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX.IsIntend_ofShieldAddress(folder)
		)
			{
				if (module != null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							module
							, 
							folder
						)
					);

				}

				new plain0nontop_.intent.Bak(cfg).Exe(folder);
			}
			else
			{
				new plain0nontop_.nonIntent.Bak(cfg, innerModules) { module = this.module }._Exe(folder);
			}
		}
	}
}
