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
using nilnul.lang_.cognom._tex.symbol_;
using nilnul.win.program_;

namespace nilnul.dev.src.div._bak.cognable
{
	/// <summary>
	/// </summary>
	/// <see cref="dev.srcs.each.div_._delvable.cognable.IWhetherFolder"/>
	public class IfFolder
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		internal IEnumerable<Seg[]> segsEs;

		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }
		public Div div { get; internal set; }

		public IfFolder(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public  void vod(
			//nilnul.fs.address_.ShieldI _shield
			
		)
		{
			var _shield = new nilnul.fs.address_.shield_.BaseDiv(
				src
				,
				div
			);

			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(_shield) )
			{
				/// as the div is provided by user, we don't check whether any seg is nonparticipant or not, assuming the user explicitly requires it to be participant.
				new dev.srcs.each.div_._delvable.cognable_.folder.WhetherUnjoint(cfg) {
					src=src,
					cognom=cognom,
					div=div
					,
					segsEs=segsEs
				}.exe(

				);
				return;
			}

			Trace.TraceWarning($" {_shield} is not a folder");
			
		}

		

	}
}
