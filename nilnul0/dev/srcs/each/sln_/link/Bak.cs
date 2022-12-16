using nilnul.dev;
using nilnul.fs.address_;
using nilnul.fs.address_.shields_;
using nilnul.win.program_;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln_.link
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak4unjoint
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}


	

		

		public Bak4unjoint(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
			
)
		{
			_cfg = cfg;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="shield">
		/// a link
		/// </param>
		internal void exe(
			ShieldI shield
		)
		{

			var old = _cfg._addDestiny_assumeLink(shield);
			if (old.Key is null)
			{
				///unjoint
				///

				new dev.srcs.each. sln_.delvable.BakTraverse(cfg) { }._vod(shield);

			}
			else
			{
				Trace.TraceWarning(
					$"{shield} is already processed by {old.Key}, which is linked by {old.Value}"
				);

			}

			
		}

		public  void exe_ofAddress(
			string folderAddress
		)
		{
			exe(
				nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
			);
		}
	}
}