using System;
using System.Collections.Concurrent;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink
{
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
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
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg):this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			//_cfg = cfg;
		}

		public Bak(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
			,         
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
		}


		public void Exe(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{

			new bak_.Git0(cfg, innerModules) {module=this.module }.exe(_shield);

		}

		public void Exe(string child)
		{
			Exe(nilnul.fs.address_.shield_._AddressX1.Create(child));
			//throw new NotImplementedException();
		}
	}
}
