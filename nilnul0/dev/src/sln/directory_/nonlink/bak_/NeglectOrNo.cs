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
	public class NeglectOrNo
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


		private NeglectOrNo(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public NeglectOrNo(
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
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be(shield,cfg.git) )
			{
				Trace.TraceWarning(
					$"{shield} is neglected"
				);
			}
			else
			{
				new nonlink_.nonneglect.Bak(cfg, innerModules) { module=this.module}.void0(shield);
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