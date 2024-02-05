﻿using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work_.nontop_.nonintent
{
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

		/// <summary>
		/// innerDivs
		/// </summary>
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		/// <summary>
		/// innerDivs2reinclude
		/// </summary>

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}


		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules
			) : this(cfg, innerModules, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules;
		}



		internal void _exe(
			string _location__nonrootWork
			)
		{
			if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be_ofAddress(_location__nonrootWork))
			{
				Trace.TraceWarning(
					$"{_location__nonrootWork} is nonparticipant|deserted;"
				);
				// it's not intended. So we neednot add it to the child modules;
				return;

			}


			new nonintent_.partic.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module = this.module }.Exe(_location__nonrootWork);


			//if (nilnul.fs.folder.be_.dev_.baK_._neglect._PerNameX.Be_ofAddress(_location__nonrootWork, cfg.git))
			//{
			//	Trace.TraceWarning(
			//		$"{_location__nonrootWork} is neglected"
			//	);
			//	if (module != null)
			//	{
			//		innerModules.Add(
			//			nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
			//				module
			//				,
			//				_location__nonrootWork
			//			)
			//		);
			//	}
			//	///todo: no child is enumerated here. so inner modules are commited into parent module
			//}
			//else  //not to neglect
			//{
			//	bool? aft = nilnul.fs.folder.sign_.dev_.src_.bak_._AftX.Be_ofAddress(_location__nonrootWork, cfg.git);
			//	if (aft == false)
			//	{
			//		if (module != null)
			//		{
			//			innerModules.Add(
			//				nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
			//					module
			//					,
			//					_location__nonrootWork
			//				)
			//			);
			//		}
			//	}

			//	else
			//	{
			//		if (aft == true)
			//		{
			//			if (module != null)
			//			{
			//				innerModules2reinclude.Add(
			//					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
			//						module
			//						,
			//						_location__nonrootWork
			//					)
			//				);
			//			}

			//		}
			//		new nonintent_.nonneglect.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude) { module = this.module }.Exe(_location__nonrootWork);
			//	}
			//}
		}
	}
}
