using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.lang_.cognom._tex.symbol_;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.each.div_.delvable
{
	/// <summary>
	///		from this on, we no longer need to look about the progenitors, thus we can look about the child only
	/// </summary>
	public class Bak_byTier
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		internal IEnumerable<Seg[]> segsEs;

		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }
		public Div div { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public Bak_byTier(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<fs._address.DivI>())
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
			//nilnul.fs.address_.ShieldI _div_inSrc
		)
		{
			var _shield = new nilnul.fs.address_.shield_.BaseDiv(
				src
				,
				div
			);

			var distance = this.segsEs.Where(s=>s.Length!=0).Count();

			switch (distance)
			{
				case 0: //subsrc
					new nilnul.dev.src.div_.cognable_.empty.Bak(cfg) {src=src,div=div,cognom=this.cognom }.vod(
					  // _div_inSrc.ToString()
					);

					break;
				case 1: //sln
					new nilnul.dev.srcs.each.sln_.delvable.BakTraverse(cfg)._vod(_shield);

					//var time =
					//nilnul.fs.folder.cfg.bak.visited._VwX.Time0nul(_div_inSrc);
					//cfg.slnVisitingEs.Add( (_div_inSrc.ToString(),time??DateTime.MinValue) );

					//new nilnul.dev.srcs.each.sln_.delvable.BakTackler(cfg)._startTask(_div_inSrc);
					break;

				default:    //inner sln
					new nilnul.dev.src.sln.directory_.unjoint.Bak4unjoint(
						cfg, new ConcurrentBag<fs._address.DivI>()
					)._exe(
						 _shield
					);
					break;
			}


		}
	}
}
