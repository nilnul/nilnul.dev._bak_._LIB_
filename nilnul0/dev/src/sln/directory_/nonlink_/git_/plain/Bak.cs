using nilnul.dev;
using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.plain
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}


		public Bak(Io cfg)
		{
			this.cfg = cfg;
		}



		public void _Exe(
			string folder
		)
		{
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(folder, cfg.git))
			{
				Trace.TraceWarning(
					$"{folder} is neglected"
				);
			}
			else
			{
				new nonlink_.nonneglect_.git_.plain.Bak(cfg) { }._exe_ofAddress(folder);
			}

		}
	}
}
