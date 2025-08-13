using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.git_.work_.top
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

		//[Obsolete(nameof(dev.sln.div_.module_.nonlink_.nonneglect.Bak) ,false)]
		[Obsolete(nameof(nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top.Bak) ,false)]
		public void _void(
			string folder
		)
		{

			//new nilnul.dev.sln.div_.module_.nonlink_.nonneglect.Bak(_cfg)._void(folder);
			//return;

			//if (nilnul.fs.folder.be_.dev_.srcs_.bak_._NeglectX.Be_ofAddress(folder))
			//{
			//	Trace.TraceInformation(
			//		$"{folder} is marked as not to be baked."
			//	);
				
			//	return;
			//}
			Trace.TraceInformation(
				$"{typeof(Bak).FullName}.{nameof(_void)}( {folder}) ... "
			);
			//Trace.Indent();

			


			if (cfg.isShieldBaked(folder))
			{
				Trace.TraceInformation(
					$"{folder} is already baked."
				);
			}
			else
			{

				new top_.incomplete.Bak(cfg)._exe(folder );

			}

			Trace.TraceInformation(
				$" ... {typeof(Bak).FullName}.{nameof(_void)}( {folder})"
			);
	



		}
	}
}
