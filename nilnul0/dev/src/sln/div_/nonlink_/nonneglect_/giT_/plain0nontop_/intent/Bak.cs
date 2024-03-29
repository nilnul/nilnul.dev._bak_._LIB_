﻿using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder;


namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.intent_.git_.plain0Nontop
{
	/// <summary>
	/// 
	/// </summary>
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules ;


		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
		{
			_cfg = cfg;
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
				new plain0Nontop_.nonempty.Bak(cfg).Exe(folderAddress);

			}
		}
	}
}