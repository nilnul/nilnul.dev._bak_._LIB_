using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.fs.address_.shield_.dev_.insideSrc
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

		public  void exe(
			
			nilnul.fs.address_.ShieldI _shield
		)
		{

			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(exe)}({_shield})>>>");

			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be_ofAddress(_shield.ToString()))
			{

				 new shield_.dev_.insideSrc_.exist.Bak(cfg).Exe( _shield  );
			}
			else
			{
				cfg.shieldsNewlyBaked.Add(_shield.ToString());

				Trace.TraceError($"{_shield} is not a folder (it is file or notexist)");
			}
		}

		public void exe(string address) {
			exe(
				nilnul.fs.address_.shield_._AddressX1.Create(address)
			);
		}

		

	}
}
