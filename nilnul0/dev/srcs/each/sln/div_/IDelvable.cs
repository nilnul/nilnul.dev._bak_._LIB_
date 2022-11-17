using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_
{
	/// <summary>
	/// the context/backgound has been checked and cleared, as:
	///		- it's unjoint
	///		- it's not neglected by its ancestors; note here we will check later after this that the dnts in this folder might be neglected by the folder itself, effectly neglect its all content.
	///		-- its cognomen is valid
	///			- the div is wordsable, be it emtpy or dwelt.
	///		- its parent is git nonrepo; but itself might be work, or repo ( a bare one), or plain
	///		
	/// </summary>
	internal interface IDelvable
		:each.div_.IDelvable
	{
	}
}
