using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.fs;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.addresses_._disjoint.item_.rawen_.cognable
{
	/// <summary>
	/// </summary>
	 public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI sup { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }
		public Div div { get; internal set; }

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public  void exe(
			//nilnul.fs.address_.ShieldI _shield
			
		)
		{
			var _shield =  new nilnul.fs.address_.shield_.BaseDiv(
				sup
				,
				div
				);
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(_shield) )
			{
				new rawen_.cognable_.folder.Bak(cfg) { sup=sup,cognom=cognom,div=div}.exe( _shield);


			}
			else
			{
				Trace.TraceWarning($" {_shield} is not a folder");
			}
			
		}

		

	}
}
