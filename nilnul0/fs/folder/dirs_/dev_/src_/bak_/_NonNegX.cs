using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using nilnul.fs.address_.spear;
using nilnul.obj.str;

namespace nilnul.fs.folder.dirs_.dev_.src_.bak_
{
	/// <summary>
	/// list all the dirs that are not baked till after the given time
	/// </summary>
	public class _NonNegX
	{
		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			var cfgFile =new nilnul.fs.address_.spear_.ParentDoc(s.address.en, ".nilnulIgnore");

			string[] lines;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(cfgFile)
			)
			{
			//read the settings

				lines = System.IO.File.ReadAllLines(
					cfgFile.ToString()
				).Select(x=>x.Trim()).ToArray();
			}
			else
			{
				lines = new string[0];
			}
			

			return nilnul.fs.folder._DirsX.Dirs(s).Where(
				d =>nilnul.obj.str.be_._NoneX.None(
					lines, 
					l => d.denote.en==l
					//(l => Regex.IsMatch(d.denote.en,l))
				)
			);

		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Dirs(new nilnul.fs.Folder(s), git);
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Dirs(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}
	}
}
