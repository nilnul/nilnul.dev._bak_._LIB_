using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs.addresses_.disjoint;
using System.Linq;
using System;

namespace nilnul.dev.src_.folder.div_.unjoint
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(srcs.each.div_.IDelvable),true)]
	public  class Bak4sln
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public Bak4sln(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			_cfg = cfg;
		}
//		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg,         
//			ConcurrentBag<nilnul.fs._address.DivI> innerModules
//)
//		{
//			_cfg = cfg;
//			this.innerModules = innerModules;
//		}

		public  void exe(
			nilnul.fs.address_.ShieldI _div_inSrc
		)
		{

			fs.address_.ShieldI shield = _div_inSrc;

			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(exe)}({_div_inSrc})>>>");

			/// get the progenitor src

			var parent = nilnul.fs.address_.Shield.FroAddress(
				_cfg.srcs.addresses.Where(
					a => nilnul.fs.address.re_.Sup.Singleton.re(a, _div_inSrc)
				).Single()
			);

			var div = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
				parent
				,
				_div_inSrc
			);

			var parseds = div.dirs.Select(d =>
				{
					try
					{
						return nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
							d.denote.en
						);

					}
					catch (System.Exception)
					{
						return null;
						//throw;
					}
				}
			//nilnul.txt.parse_.NotedWordsX.Nulable(
			//	d.denote.en
			//)
			);

			if (
				parseds.Where(
					c=>c is  null			
				).Any()
			)
			{
				return;
			}
			var distance=parseds.Where( x=> x.name!="").Count();

			//uint distance = nilnul.fs.address_.shield.co_.sup._DistanceX1._ofSupSub(parent, shield);
			switch (distance)
			{
				case 0: //src
					new nilnul.dev.src_.folder_.unjoint.Bak(cfg).Exe(
					   _div_inSrc.ToString()
					);
					break;
				case 1: //sln			//or commented folder
					new nilnul.dev.src_.folder.dir_.unjoint.Bak_srcsInAddresses(cfg).exe(_div_inSrc.ToString());
					break;
				default:    //inside sln
					new nilnul.dev.srcs.each.sln.directory_.delvable.Bak4unjoint(cfg)._exe(
						 shield
						);
					break;
			}
		}

		public void exe(Exist address)
		{
			exe(address.en);
		}
		public void exe(FolderI en)
		{
			exe(en.folder.en.address);
		}

		


	}
}
