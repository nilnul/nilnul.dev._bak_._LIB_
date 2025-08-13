using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder;


namespace nilnul.dev.src.sln.div_.nonneglect_.unjoint_.intent_.giT_.plain0nontop
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

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
			//, ConcurrentBag<DivI> innerModules1
		)
		{
			this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		//public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		//	:this(cfg,new ConcurrentBag<DivI>())
		//{
		//}


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
				nilnul.fs.folder_.giT_.newable.be_.Trivia.Singleton.Be_ofAddress(folderAddress)		/// todo: inner intentModule might have not been inited.
				
				)
			{
				Trace.TraceWarning($"intendGit:{folderAddress} is trivia(only {nilnul.fs.git.module.work.div.doc_.Ignore._DOC__TXT} or {nilnul.fs.folder.doc_.dev_.NilnulCfg.DOC})");
			}
			else
			{
				new plain0nontop_.nontrivia.Bak_srcsInAddresses(cfg).Exe(folderAddress);

			}
		}
	}
}