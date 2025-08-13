using nilnul.dev;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work_.nontop_.intent
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}




		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<nilnul.fs._address.DivI>();

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, nilnul.fs.address_.ShieldI module)
		{
			_cfg = cfg;
			this._module = module;
		}

		//private Bak(Io cfg, ConcurrentBag<DivI> innerModules1)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules1;
		//}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void exe(
			//string folderAddress
		)
		{
			try
			{
				if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be(this._module))
				{
					Trace.TraceWarning(
						$"{this._module} is neglected"
					);


				}
				else
				{
					new delvable_.partic_.giT_.work_.nontop_.intent.Bak_srcsInAddresses(cfg, this._module).exe();


				}



			}
			catch (OperationCanceledException ex)
			{
				Trace.TraceWarning($"in {this.GetType().FullName} for {this._module}, exception:{ex}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {this._module} :" + e.Message
				);
				return;
			}
		}

		internal static void Bak(fs.addresses_.disjoint.deV_._bak.Io cfg, ShieldI module, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, string folder)
		{
			if (module is not null)
			{

				innerModules.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						module
						,
						folder
					)
				);
			}

			new Bak_srcsInAddresses(
				cfg,
				
				nilnul.fs.address_.Shield.FroAddress(
					folder
				)
			).exe();
		}
	}
}