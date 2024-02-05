using nilnul.fs;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln_.delvable
{
	/// <summary>
	/// not a traverser;
	/// but tackle the bak;
	/// </summary>
	public class BakByPartic
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		internal BakByPartic(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			this.cfg = cfg;
		}



		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public void _startChildTask_0delvable(string folder)
		{
			if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be_ofAddress(folder))
			{
				/// todo: move this out of task.
				Trace.TraceWarning($"{folder} is not participating;");
				return;
			}

			new delvable_.partic.BakTackler(_cfg)._startChildTask_0partic(folder);
			return;
		}

		public void _startChildTask_0delvable(FolderI folder)
		{
			_startChildTask_0delvable(folder.ToString());
		}

		public void _startChildTask_0delvable(nilnul.fs.address_.ShieldI folder)
		{
			_startChildTask_0delvable(folder.ToString());

		}
	}
}