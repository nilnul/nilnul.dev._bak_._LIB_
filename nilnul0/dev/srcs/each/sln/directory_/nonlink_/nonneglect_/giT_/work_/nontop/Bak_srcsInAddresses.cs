using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.giT_.work_.nontop
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public nilnul.fs.address_.ShieldI module;
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules)
		{
			_cfg = cfg;
			this.innerModules = innerModules;

		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}


		public void _exe(
			string folder
		)
		{

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

				new nontop_.intent.Bak_srcsInAddresses(cfg).Exe(folder);
			}
			else
			{
				new nontop_.nonintent.Bak_srcsInAddresses(cfg, innerModules) { module = this.module }._Exe(folder);
			}

		}
	}
}