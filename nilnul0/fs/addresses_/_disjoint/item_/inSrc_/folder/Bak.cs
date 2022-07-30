using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.fs.addresses_._disjoint.member_.inSrc_.folder
{
	/// <summary>
	/// for an individual shield
	/// </summary>
	public class Bak
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public  void Exe(
			nilnul.fs.address_.ShieldI _shield
		)
		{
			///time to map back into nonlink
			///


			new nilnul.dev.src.div_.folder.Bak(cfg).exe(_shield);
			
		}

		public void Exe(AddressI shield)
		{
			Exe(
				nilnul.fs.address_.Shield.FroAddress(shield)
			); ;
			//throw new NotImplementedException();
		}
	}
}
