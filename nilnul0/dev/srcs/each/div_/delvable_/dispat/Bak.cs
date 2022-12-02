using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.div_.cognable_.empty
{
	
	public  class Bak
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
			if (nilnul.fs.folder.be_.deV_.src_.bak_.neglect.Anto.Be(folder))
			{
				new empty_.nonneglect.Bak(cfg) { src=src,div=div,cognom=this.cognom}.exe(
					//folder
				);
			}
			else
			{
				Trace.TraceWarning($"{folder} is configured to bak later.");
			}

			

		}


		//public  void _vod_ofAddress(
		//	string folder
		//)
		//{
		//	vod(nilnul.fs.Folder.FroAddress(folder) );
		//}

		

	}

}
