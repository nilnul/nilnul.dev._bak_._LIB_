﻿#define BAK_SERIAL0
using nilnul.dev;
using nilnul.fs;
using nilnul.fs.folder.categorize_.git_.plainWorkRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_._incomplete_.container_.undone.task
{
	/// <summary>
	/// </summary>
	static public class _WaitX
	{
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>
		public static void _Void(
			string folder,
			 CancellationToken cancel //=CancellationToken.None
			,
			nilnul.win.program_.Git git = null
		)
		{
			_TaskX._Task(folder, cancel, git).Wait();
		}

		public static void _Uncancelable(
			string folder
			
			,
			nilnul.win.program_.Git git = null
		)
		{
			_TaskX._Task(folder, CancellationToken.None, git).Wait();
		}

	}
}
