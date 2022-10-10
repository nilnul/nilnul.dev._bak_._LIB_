using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.depo_.rt_
{
	/// <summary>
	/// user might experience problem: we don't recommend make the rt of the raw folder as a depo top, or subwork.
	/// if the user insists, we recommend:
	///		-) make a directory with an empty <see cref="nilnul.dev.src.div.ICognome"/>. eg:	   (abc) , or (abc)/(def)
	///	whether user leave it a subwork of a depo in the rt, or in the abovementioned directory of empty cognom, the cognome will be empty.
	///	if it's a depo root, the user can sync that to custom made module without the assisiting of our tool.
	///	if it's a depo nonroot, the depo rt is above the raw. the suer can sync that to custom made module without the assisting of our toolset.
	/// </summary>
	class IUxp
		:
		IRt
		,
		nilnul.obj_.IXpn /// to be reivsed to <see cref="nilnul.obj_.IUxp"/>
	{

	}
}
