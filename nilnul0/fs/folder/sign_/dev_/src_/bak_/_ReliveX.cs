using System;

namespace nilnul.fs.folder.sign_.dev_.src_.bak_
{
	/// <summary>
	/// </summary>
	public class _AftX
	{
		public static bool? Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			address_.spear_.ParentDoc spear = new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg");
			if (nilnul.fs.address_.spear.be_.file.Anto.Singleton.be(spear))
			{
				return null;

			}
			win.prog._run.Result r = nilnul.win.prog_.git_.cfg.read_._ResultX.Result(
				spear,
			   "bak.aft", git
			);

			if (r.beErr)
			{
				return null;
			}

			DateTimeOffset benchmark;// = new DateTime();
			bool parsed = DateTimeOffset.TryParse(r.msg.Trim(), out benchmark);
			if (parsed)
			{
				return DateTimeOffset.UtcNow >= benchmark;
			}
			else
			{
				return null;
			}
		}

		public static bool? Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}

		public static bool? Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}
	}
}
