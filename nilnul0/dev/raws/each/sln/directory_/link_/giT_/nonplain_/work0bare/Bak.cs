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

namespace nilnul.dev.src.sln.directory_.link_.giT_.nonplain_.work0bare
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


		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}


		private Bak4unjoint(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public Bak4unjoint(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
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

				new directory_.unjoint_.giT_.work.Bak4unjoint(cfg, innerModules) { module=this.module}.__exe(shield);

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