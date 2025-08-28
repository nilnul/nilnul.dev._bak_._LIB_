using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.bak
{
	/// <summary>
	/// we can automatically restore the bakked src to another computer, by:
	///		1) allowing user to configure what projects to restore (when unfound, an error would be logged, in .xec format), what projects to ignore, in regex pattern.
	///			1.1) the order is honored. those in whitelist would be restored first.
	///		2) a special tag such as "w2508131607" denoting werk at time precised in minutes, to denote the designated revision that shall be synchronized with old computer.
	///			,or we don't need the tag, but just switch to the newest chain as how longest chain is chosen in bitcoin.
	///			, the intension of this is to get the latest work which is represented by the branch (in the old computer, newest work shall be committed to a branch, either manually to "master", or automatically to "bak2508131629" or something like that ). To use another branch, you can still switch to that branch, while moving some of the newest work there.
	///		3) a subrepo would be named with a suffix "(Git" in order to avoid confliction with the subfolder of a suprepo.
	///		4) the checkout branch is the one pointing to the newest revision.
	///		5) subrepo such as "abc.def.hij" is put in a multiple layered director: "abc/def/hij(Git" or a dir under sln, as "abc.def.hij(Git"; the benefits of the latter is that when cloning manually, we just need to do that in the SLN folder, and dotnot need to create all the dirs following the hierarchy;
	///		
	///	; as git is distributive, hence we can run this more than once if the previous run is not up to date or ended prematurely.
	/// </summary>
	/// alias:
	///		reconstruct
	///		restore, confusing with gitRestore
	internal class IReconstruct
	{
	}
}
