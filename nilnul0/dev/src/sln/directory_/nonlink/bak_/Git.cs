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

namespace nilnul.dev.sln_.nonlink.directory_.nonlink.bak_
{
	/// <summary>
	/// 
	/// </summary>
	public class Git0
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
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


		private Git0(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public Git0(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
			,   
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
		}


		internal void exe(
			ShieldI shield
		)
		{
			cfg.cancel.ThrowIfCancellationRequested();

			string shieldTxt = shield.ToString();
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(shieldTxt)
			)
			{
				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					new sln_.nonlink.directory_.nonlink_.git_.plain.Bak(cfg) { }._Exe(shieldTxt);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

					new sln_.nonlink.directory_.nonlink_.git_.work.Bak(cfg, innerModules) { module = this.module }._Exe(
					   nilnul.fs.folder_.git_.Work.FroAddress(shieldTxt)
				   );
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return;
					break;

				default:
					Trace.TraceError($"sln {shieldTxt}:unknown git.folder.Category");
					return;
			}
			
		}

		public  void Exe(
			string folderAddress
		)
		{
			exe(
				nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
			);
		}
	}
}