using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.div_
{
	/// <summary>
	/// the context/backgound has been checked and cleared, as:
	///		- it's unjoint
	///		- it's not neglected by its ancestors; note here the dnts in this folder might be neglected by the folder itself, effectly neglect its all content.
	///		- the div is wordsable, be it emtpy or dwelt.
	///		- its parent is git nonrepo; but itself might be work, or repo (), or plain
	///		-- its cognomen is valid, be it empty or dwelt;
	///		
	/// </summary>
	/// <see cref="nilnul.dev.src.div_.IWordsable"/>
	/// <see cref="nilnul.dev.src.sln.div_.IDelvable"/>
	internal interface IDelvable:nilnul.dev.src.sln.div_.IDelvable
	{
	}
}
