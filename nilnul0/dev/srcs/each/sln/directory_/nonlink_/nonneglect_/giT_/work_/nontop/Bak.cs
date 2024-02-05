﻿using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.nontop
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public nilnul.fs.address_.ShieldI module;

		private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

		public Bak(Io cfg, ConcurrentBag<DivI> innerModules)
		{
			_cfg = cfg;
			this.innerModules = innerModules;

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

				new nontop_.intent.Bak(cfg).Exe(folder);
			}
			else
			{
				new nontop_.nonIntent.Bak(cfg, innerModules) { module = this.module }._Exe(folder);
			}

		}
	}
}