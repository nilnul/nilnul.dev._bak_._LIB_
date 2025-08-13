using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;
using nilnul.win.program_;

namespace nilnul.dev.src.div_.exist_.nondelay
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
			
				if (nilnul.fs.folder.be_._NormalX.Be_ofShield(_shield.ToString()))
				{
					new div_.folder_.nonlink.Bak(cfg).Exe( _shield);
					//return;
				}
				else
				{
					Trace.TraceInformation($"not a normal folder; maybe symlink or reparse: {_shield}");
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

		public void exe(Normal div_inSrc)
		{
			exe(div_inSrc.en);
		}


	}
}
