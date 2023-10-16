using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.dev_.baK
{
	/// <summary>
	/// </summary>
	static public class _VwX
	{

		public static IEnumerable<string> Name0nuls(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{


			var remotes = individualRemotes.Select(
				r => nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
					gitTop
					,
					r
					,
					git
				)
			);
			return remotes;

		}

		public static IEnumerable<string> Name0nuls(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Name0nuls(
				gitTop
				,
				individualRemotes.Select(r=> nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
							r
					)
				)
				,
				git
			);
		}
		public static IEnumerable<string> Name0nuls(
			nilnul.fs.git.Module gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Name0nuls(gitTop as ModuleI, individualRemotes, git);

		public static IEnumerable<string> Name0nuls(
			nilnul.fs.folder_.git_.Top gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Name0nuls(new nilnul.fs.git.Module(gitTop), individualRemotes, git);

		public static IEnumerable<string> Name0nuls_moduleOfAddress(
			string gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Name0nuls( nilnul.fs.git.Module.FroAddress(gitTop), individualRemotes, git);

	}
}
