using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.each.div_.delvable_.dispat
{

	/// <summary>
	/// whether it's participant, is unknown;
	/// </summary>
	public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }
		public Div div { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void vod(
		//nilnul.fs.FolderI folder
		)
		{
			var folder = new nilnul.fs.address_.shield_.BaseDiv(
				src
				,
				div
			);
			if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be(folder))
			{
				Trace.TraceWarning($"{folder} is configured to bak later.");
				return;
			}

			new dev.srcs.each.div_.delvable_.dispat_.partic.Bak(cfg) { src = src, div = div, cognom = this.cognom }.exe(
			//folder
			);

		}
	}
}