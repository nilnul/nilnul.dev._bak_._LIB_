#define BAK_SERIAL0
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

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.content.bak_
{
	/// <summary>
	/// </summary>
	public class KeepInnerModules
	{
		private nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete.bak_.KeepInnerModules
 _top;
		public  nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete.bak_.KeepInnerModules
 top
		{
			get { return _top; }
			set { _top = value; }
		}



		public KeepInnerModules(
			nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete.bak_.KeepInnerModules
 top)
		{
			_top = top;
		}

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

		public void _Exe(
			string folder
		)
		{
			var cfg = top.cfg;

			Trace.TraceInformation($@"baking {typeof(KeepInnerModules).FullName}:{folder}...");
			
			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cfg.cancel.ThrowIfCancellationRequested();
				return;// false;
			}

			Trace.Indent();
			var git = cfg.git;
			try
			{
				foreach (var child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(folder))
				{

					if (cfg.cancel.IsCancellationRequested)
					{
						Trace.TraceWarning($"cancelling {folder}");
						cfg.cancel.ThrowIfCancellationRequested();
						return;
						break;
					}

					if (nilnul.fs.folder.be_.dev_.srcs_.bak_._NeglectX.Be_ofAddress(child,cfg.git) )
					{
						Trace.TraceWarning( $"{child} is neglected");
						continue;
					}

					if (nilnul.fs.git.module.dir.be_._WorkX.Be(child, git))
					{
						if (
							nilnul.fs.git.module.dir_.work.be_._TopX._Be(child, git)
						)
						{
							top.innerModules.Add(
								nilnul.fs.address_.shield.duo_.sup._DifX1._ofSupSub(
									folder
									,
									child
								)
							);
							new div_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._Exe(
								child
							);


						}
						else
						{
							new sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.nontop.Bak(cfg)._exe(child);
						}
					}
				}
				Trace.TraceInformation($@"baked {typeof(KeepInnerModules).FullName}:{folder}");

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when enumerating directories of gitModuleUndone {folder}:{e}");
				throw;
			}
			finally
			{
				Trace.Unindent();

			}


		}
	}
}
