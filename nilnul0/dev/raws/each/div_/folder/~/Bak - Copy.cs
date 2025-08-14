using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.src.div_.exist
{
	/// <summary>
	/// the div is a folder.
	/// </summary>
	 public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
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
