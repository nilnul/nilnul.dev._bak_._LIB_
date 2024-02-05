using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo._cfg_.remote_.deV_.baK_.all_.last.nulable
{
	static public class _VwX
	{

		static public NameVer _Vered_0depo(string module, nilnul.win.prog_.Git git=null) {

			foreach (var item in fs.git.module.repo._cfg_.remote_.dev_.baK_._all.key._VwX.GetKeys().Reverse())
			{
				var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX._Seq_0depo(module).Select(x => nilnul.txt_.NameVer.Parse(x)).Where(
								y =>
									 y.name.en == item

				);
				var lastest = nilnul.txt_.nameVer.SetX.GetLatestOrDefault(remotes);
				if (lastest != null)
				{
					return lastest;
				}

			}
			return null;
		}

		static public NameVer Vered(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git=null) {

			return _Vered_0depo( module.top1.ToString(),git);
		}

	}
}
