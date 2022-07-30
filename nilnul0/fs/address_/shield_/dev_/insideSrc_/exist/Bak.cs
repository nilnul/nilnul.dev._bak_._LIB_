using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.fs.address_.shield_.dev_.insideSrc_.exist
{
	/// <summary>
	/// for an individual shield
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

		public  void Exe(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			new nilnul.dev.src.div_.exist.Bak(cfg).exe(_shield);
			
		}

		

	}
}
