using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.crop_
{
	/// <summary>
	/// when in project Bak, as we are bakking the srcs, for each linked folder, we check whether it's already in our processed list lest we fall into a cycle.
	/// By labeling unlisted as unjoint, we de facto face a forest, with each link as a tree root (we don't allow link pointing back into any tree in our forest).
	/// </summary>
	class IUnjoint
	{
	}
}
