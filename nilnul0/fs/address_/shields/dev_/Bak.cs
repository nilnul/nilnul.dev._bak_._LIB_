﻿using System.Collections.Generic;
using System.Threading;

namespace nilnul.fs.address_.shields.dev_
{
	/// <summary>
	/// </summary>
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public Bak(CancellationToken cancel, nilnul.win.prog_.Git git = null) : this(
	nilnul.fs.address_.shields.dev_._bak.io_._CfgX.Create_bakedNone(cancel, git)
)
		{

		}





		public void Exe(
			IEnumerable<string> _addressesDisjoint

		)
		{
			new nilnul.fs.address_.shields_.disjoint.Bak(cfg)._Bak(
			   nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(_addressesDisjoint)
		   );
		}






	}
}