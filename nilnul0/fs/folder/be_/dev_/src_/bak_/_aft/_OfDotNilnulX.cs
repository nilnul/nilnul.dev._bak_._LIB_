using System;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._aft
{
	/// <summary>
	/// after (not until) the given date to bak. baking will not be carried out before/lt() this date.
	/// </summary>
	public class _OfDotNilnulX
	{
		public static bool? Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{

			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnul");
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				win.prog._run.Result r = nilnul.win.prog_.git_.cfg.read_._ResultX.Result
					   (spear,
					   "bak.aft", git);
				if (r.beErr)
				{
					return null;
				}

				DateTimeOffset benchmark;// = new DateTime();
				bool parsed = DateTimeOffset.TryParse(r.msg.Trim(), out benchmark);
				if (parsed)
				{
					return DateTimeOffset.UtcNow>= benchmark;
				}
				else
				{
					return null;
				}

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
