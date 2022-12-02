using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs.addresses_.disjoint;
using System.Linq;
using nilnul.fs.address_;
using nilnul.fs._address;
using System.Collections.Generic;
using System;

namespace nilnul.dev.src.div_.nonneglect
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(srcs.each.div_._delvable),true)]
	public  class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }
		public Div div { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }

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
			nilnul.fs.address_.ShieldI _div_inSrc
		)
		{
	


			var distance = this.cognom.Count();



			switch (distance)
			{
				case 0: //src
					new nilnul.dev.src.div_.cognable_.empty_.nonneglect.Bak(cfg).exe(
					  // _div_inSrc.ToString()
					);

					break;
				case 1: //sln
					new nilnul.dev.src.sln_.unjoint_.nonneglect.Bak_srcsInAddresses(cfg).__exe(_div_inSrc.ToString());
					break;

				default:    //inside sln
					new nilnul.dev.src.sln.directory_.unjoint_.nonneglect.Bak_srcsInAddresses(cfg,new ConcurrentBag<fs._address.DivI>())._exe(
						 _div_inSrc
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
			exe(en.address);
		}

		


	}
}
