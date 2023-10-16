using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vered.be_
{
	/// <summary>
	/// aws:amazon web service-code commit
	/// </summary>
	static public class _AnyX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="remoteNom">the nom part of the remote name. excluding the version</param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			txt_._vered_.Name remoteNom	
			,
			nilnul.win.prog_.Git git = null
			)
		{
			return  nilnul.fs.git.module.repo._cfg_.remote_.vered_.name.be_._AnyX.Be(
				module
				,
				remoteNom
				,
				git
			);
		}

		static public bool Be_remoteOfNom(
			nilnul.fs.git.ModuleI module
			,
			string remoteNom	
			,
			nilnul.win.prog_.Git git = null
			)
		{
			return Be(
					module
					,
				new txt_._vered_.Name(
					remoteNom
				)
					,
					git
			);
			
		}


		static public bool Be(
			nilnul.fs.git.Module module
						,
			txt_._vered_.Name remoteNom

			,
			nilnul.win.prog_.Git git = null
			)
		{
			return Be(
				(fs.git.ModuleI)(module),
				remoteNom
				,git
			);
		}

		static public bool Be(
			nilnul.fs.folder_.git_.Top module
						,
			txt_._vered_.Name remoteNom

			,
			nilnul.win.prog_.Git git = null
			)
		{
			return Be(
				new nilnul.fs.git.Module(module),
				remoteNom
				,git
			);
		}

		static public bool Be(
			nilnul.fs.FolderI module
						,
			txt_._vered_.Name remoteNom

			,
			win.prog_.Git git = null)
		{
			return Be(
				new fs.folder_.git_.Top(module)
				,
				remoteNom
				,
				git
			);
		}



	}
}
