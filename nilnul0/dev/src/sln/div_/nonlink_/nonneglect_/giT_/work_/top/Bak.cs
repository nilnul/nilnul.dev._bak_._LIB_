using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs.folder;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules=new ConcurrentBag<fs._address.DivI>();

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}


		public void _void(
			string folder
		)
		{
			//if (nilnul.fs.folder.be_.dev_.srcs_.bak_._NeglectX.Be_ofAddress(folder))
			//{
			//	Trace.TraceInformation(
			//		$"{folder} is marked as not to be baked."
			//	);

			//	return;
			//}
			//Trace.Indent();

			//if (nilnul.fs.git.module.work.be_.Empty.Singleton.Be_ofAddress(folder))
			//{
			//	Trace.TraceInformation(
			//		$"{typeof(Bak).FullName}.{nameof(_void)}( {folder}): work is empty; maybe this is a readonly repo waiting for a remote to grow space to push"
			//	);

			//	new nonneglect_.i
			//	return;
			//}

			Trace.TraceInformation(
				$"{typeof(Bak).FullName}.{nameof(_void)}( {folder}) ... "
			);

			if (cfg.isShieldBaked(folder))
			{
				Trace.TraceInformation(
					$"{folder} is already baked."
				);
				return;
			}

			new nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete.Bak(cfg)._exe(folder);

			//new sln.div_.module_.nonlink_.nonneglect_.incomplete.Bak(cfg)._exe(folder);



			Trace.TraceInformation(
				$" ... {typeof(Bak).FullName}.{nameof(_void)}( {folder})"
			);




		}
	}
}
