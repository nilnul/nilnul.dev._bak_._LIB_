using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.plain
{

	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;


		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}
		public void _Exe(
			string folder
		)
		{
			try
			{

				if (
					nilnul.dev.sln.div.be_._IntendGitX.Be_ofAddress(folder, cfg.git)
			)
				{
					new plain_.intent.Bak(cfg).Exe(folder);
				}
				else
				{
					new plain.Bak(cfg)._Exe(folder);

				}



			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing {this.GetType().FullName}: {folder}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception when baking {folder}:{e}");
			}

		}



	}
}
