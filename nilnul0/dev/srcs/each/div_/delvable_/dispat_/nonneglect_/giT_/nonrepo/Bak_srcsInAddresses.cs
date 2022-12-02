using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.num._quotient;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.unjoint_.nonneglect_.giT_.nonrepo
{
	/// <summary>
	/// not a git repo(the ".git" folder), be it bare or not. a plain folder, a work (top or nontop)
	/// todo: 
	/// </summary>
	///
	[Obsolete("rename this to " + nameof(nilnul.dev.src.div_.cognable_.empty_.nonneglect_.giT_.nonrepo.IBak))]
	public class Bak_srcsInAddresses
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		 public void Exe(
			//nilnul.fs.FolderI folder
			)
		{
			var shield = new nilnul.fs.address_.shield_.BaseDiv(
				src
				,
				div
			);

			var folder = new nilnul.fs.Folder(shield);
			Trace.TraceInformation($"baking src:{folder}");
			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
			}
			//Trace.TraceInformation($"{nameof(Cfg.doneContainers)}:{Cfg.doneContainers}");

			if (
				cfg.isShieldBaked(folder.ToString())
			)
			{
				Trace.TraceInformation($" {folder} already done ");
			}
			else
			{
				new nilnul.dev.src_.folder_.unjoint_.nonneglect_.giT_.nonrepo_.incomplete.Bak_srcsInAddresses(cfg)
				{
					src = this.src
					,
					div = this.div
					,
					cognom = this.cognom
				}.Exe(
					// folder
				);
			}
		}

		// public void Exe(
		//	string folder
		//)
		//{
		//	Exe(nilnul.fs.Folder.FroAddress(folder));
		//}
	}
}