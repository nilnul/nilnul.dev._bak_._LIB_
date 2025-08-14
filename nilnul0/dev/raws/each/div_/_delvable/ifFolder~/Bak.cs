using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.src.div
{
	/// <summary>
	/// for a virtual div. the div might be nonexistant.
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
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(_shield) )
			{
				new div_.exist.Bak(cfg).exe( _shield);


			}
			else
			{
				Trace.TraceWarning($" {_shield} is not a folder");
			}
			
		}

		

	}
}
