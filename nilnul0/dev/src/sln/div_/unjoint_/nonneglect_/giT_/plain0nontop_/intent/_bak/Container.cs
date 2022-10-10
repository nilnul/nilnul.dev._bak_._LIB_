using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder;


namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.plain0nontop_.intent._bak
{
	/// <summary>
	/// 
	/// </summary>
	public class Container
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

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Container(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}
		public Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe(
			string folderAddress
		)
		{



			///if the folder is trivia, then it might be a module that is archived remotely and cleaned locally.

			if (
				nilnul.fs.folder_.giT_.newable.be_.Trivia.Singleton.Be_ofAddress(folderAddress)     ///  inner intentModule might have not been inited, but those are all having chore inside.

				)
			{
				Trace.TraceWarning($"intendGit:{folderAddress} is trivia(only {nilnul.fs.git.module.work.div.doc_.Ignore._DOC__TXT} or {nilnul.fs.folder.doc_.dev_.NilnulCfg.DOC})");
			}
			else
			{
				new plain0nontop_.intent_.wrought._bak.Container(cfg, innerModules, innerModules2reinclude,module)/* { module=this.module}*/.Exe(folderAddress);

			}

		}
	}
}