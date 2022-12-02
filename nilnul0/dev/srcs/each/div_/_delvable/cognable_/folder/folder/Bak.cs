using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.fs;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.addresses_._disjoint.item_.rawen_.cognable_.folder
{
	/// <summary>
	/// </summary>
	 public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI sup { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }
		public Div div { get; internal set; }

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public  void exe(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			

			if (nilnul.fs.folder.be_._NormalX.Be_ofShield(_shield.ToString()))
			{
				new div_.folder_.nonlink.Bak(cfg).Exe(_shield);
				//return;
			}
			else
			{
				Trace.TraceWarning($"{_shield} is a link (such as symbolink).");
			}
		}

		

	}
}
