﻿using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.div
{
	/// <summary>
	///		from this on, we no longer need to look about the progenitors, thus we can look about the child only
	/// </summary>
	///
	[Obsolete(nameof(Bak_byCognom),true)]
	public class Bak_srcsInAddresses
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


		

		public  void vod(
			//nilnul.fs.address_.ShieldI _div_inSrc
		)
		{
			var _div_inSrc = new nilnul.fs.address_.shield_.BaseDiv(
	src
	,
	div
);
			///check from inside whether it's neglected

			if (nilnul.fs.folder.be_.deV_.src_.bak_.neglect.Anto.Be(_div_inSrc))
			{
				new div_.nonneglect.Bak_srcsInAddresses(cfg) { src=src,div=div,cognom=cognom }.exe(_div_inSrc);
			}
			else
			{
				Trace.TraceWarning($"{_div_inSrc} is configured to neglect (we may bak it later if a date is specified).");
			}

			
		}
	}
}
