﻿using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder.doc_.link.create_;
using System;
using System.Collections.Concurrent;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.plain.dir_.unskip_.attend;

// this is a dir under sln:
// [Obsolete("intention0no shall be determined on directory;",true)]
public class Bak_srcsInAddresses
{
	private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
	public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
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


	private Bak_srcsInAddresses(
		nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
	) : this(
		cfg, innerModules1, new ConcurrentBag<DivI>()
	)
	{
	}

	private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
	{
	}


	public void _exe(
		string folder
	)
	{

		var gitCategory = nilnul.fs.folder.categorize_.giT_.plainWorkRepo_._ByIsInsideGitDirX.Category_ofAddress(folder);

		switch (gitCategory)
		{
			case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:


				new plain.dir_.unskip.plain.Bak(
													cfg
													,
													innerModules
													,
													innerModules2reinclude
												)
				{ module = this._module }._vod(child);
				new nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.p.giT_.plain.Bak(
													cfg
													,
													innerModules
													,
													innerModules2reinclude
												)
				{ module = this._module }._vod(child);

				//this.innerModules = bak.innerModules;
				//this.innerModules2reinclude = bak.innerModules2reinclude;

				break;
			case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

				///a work under plain  must be top
				///



				nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work_.top.Bak_srcsInAddresses.Exe(cfg, _module, innerModules, innerModules2reinclude, child);

				//this.innerModules = topBakker.innerModules;
				//this.innerModules2reinclude = topBakker.innerModules2reinclude;

				break;
			case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
				/// it must be bare.
				/// 
				break;
			default:
				break;
		}
		directory_.delvable_.

		if (
			nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX.IsIntend_ofShieldAddress(folder) /// this is a dir under slan todo: subsrc allowed.
		)
		{
			//if (module is not null)
			//{
			//	innerModules.Add(
			//		nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
			//			module
			//			,
			//			folder
			//		)
			//	);

			//}
			sln.div_.delvable_.partic_.intent.Bak_srcsInAddress.Exe(_cfg, module, this.innerModules, this.innerModules2reinclude, folder);
			return;

			//new div_.nonneglect_.intent.Bak_srcsInAddress(cfg).Exe(folder);
		}

		new srcs.each.sln.div_.delvable_.partic_.nonintent.Bak(cfg, innerModules, innerModules2reinclude, module)._void(folder);


	}
}