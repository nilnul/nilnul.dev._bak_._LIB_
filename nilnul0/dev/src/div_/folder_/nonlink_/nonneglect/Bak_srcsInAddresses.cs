using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs.addresses_.disjoint;
using System.Linq;

namespace nilnul.dev.src.div_.folder_.nonlink_.nonneglect
{
	/// <summary>
	/// the processed is:
	///		a folder
	///		nonlink: not a link itself; any of the ancestor is nonlink
	/// </summary>
	public  class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<fs._address.DivI>())
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
			nilnul.fs.folder_.Normal _div_inSrc
		)
		{

			fs.address_.ShieldI shield = _div_inSrc.en.address.en;

			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(exe)}({_div_inSrc})>>>");

			/// get the parent src

			var parent = nilnul.fs.address_.Shield.FroAddress(
				_cfg.srcs.addresses.Where(
					a => nilnul.fs.address.re_.Sup.Singleton.re(a, _div_inSrc.en.address.en)
				).Single()
			);



			uint distance = nilnul.fs.address_.shield.co_.sup._DistanceX1._ofSupSub(parent, shield);

			switch (distance)
			{
				case 0: //src
					new nilnul.dev.src_.folder_.nonlink_.nonneglect.Bak_srcsAsAddresses(cfg).exe(
					   _div_inSrc.ToString()
					);

					break;
				case 1: //sln
					new nilnul.dev.sln_.nonlink_.nonneglect.Bak_srcsInAddresses(cfg).__Exe(_div_inSrc.ToString());
					break;

				default:    //inside sln
					new nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect.Bak_srcsInAddresses(cfg,new ConcurrentBag<fs._address.DivI>()).void0(
						 shield
						);
					break;
			}


		}

		public  void Exe(
			nilnul.fs.address_.ShieldI _shield
		)
		{
			exe(
						  new nilnul.fs.folder_.Normal(
						   _shield
						   )
			);
		}

		public void exe(Exist address)
		{
			Exe(address.en);
		}
		public void exe(FolderI en)
		{
			exe(en.address);
		}

		


	}
}
