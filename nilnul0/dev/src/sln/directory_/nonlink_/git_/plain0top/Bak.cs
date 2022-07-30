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

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.plain0top
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		//private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<DivI>())
		//{
		//}

		//private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<DivI>())
		//{
		//}
	




		public bool isTop(
			string folder
		)
		{

			//if (nilnul.fs.folder.be_.dev_.src_.bak_._NeglectX.Be_ofAddress(folder, cfg.git))
			//{
			//	Trace.TraceWarning(
			//		$"{folder} is neglected"
			//	);
			//}
			//else
			//{
			//	new nonlink_.nonneglect_.git_.plain0top.Bak(cfg) {  }.isTop(folder);
			//}

			if (nilnul.fs.folder.be_.git_._NoneX.Be_ofAddress(folder,cfg.git))
			{
				new sln_.nonlink.directory_.nonlink_.git_.plain.Bak(cfg)
				{
				}._Exe(folder);
				return false;
			}
			else
			{
				new sln_.nonlink.directory_.nonlink_.git_.work_.top.Bak(cfg, innerModules, innerModules2reinclude) 
				{
					moduleAbove=this._module
				}.__Exe(folder);
				return true;

			}

			

		}
	}
}
