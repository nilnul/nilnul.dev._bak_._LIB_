using nilnul.fs;
using nilnul.fs._address;
using nilnul.obj.str.to_.scalar_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace nilnul.dev.srcs.each.sln_.delvable_.nonneglect._bak
{
	/// <summary>
	/// order the sln2bak according visited time;
	/// after this, we can schedule the task
	/// </summary>
	public  class Triage
	{

		ConcurrentDictionary<string, DateTime?> _slns=new ConcurrentDictionary<string, DateTime?>();

		BlockingCollection<(string, DateTime?)> blc = new BlockingCollection<(string, DateTime?)>(
			new ConcurrentBag<(string, DateTime?)>()
		);




		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}


		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Triage(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Triage(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		public Triage(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Triage(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

	

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public  void _StartTask(string folder)
		{
			var time = nilnul.fs.folder.cfg.bak.visited._VwX._Time0nul_addressAssumeFolder(folder);

			blc.Add(
				(folder,time)
			);

			_slns.TryAdd(folder, time);

			var actionBlock = new ActionBlock<(string, DateTime?)>(
				t=> _slns.TryAdd(t.Item1,t.Item2)
			);

			var buffer = new BufferBlock<(string, DateTime?)>();

			buffer.Post(
				(folder,time)
			);


			actionBlock.Post(
				(folder,time)
			);

			buffer.LinkTo(actionBlock);




		}
		bool _complete=false;

		async Task WorkerProc(CancellationToken token)
		{
			while (!token.IsCancellationRequested)
			{

				Func<Task> action;
				//find the oldest one
				var min=nilnul.obj.str.to_.scalar_._MinOrDefaultX.Min(
					_slns
					,
					t=>t.Value
					,
					new nilnul.obj.nulable.comp_.NulMinOvStruc<DateTime>()
				);
				if (min.Key is null)
				{
					if (_complete)
					{
						return;
					}
					
					await Task.Yield();
					continue;
				}


				_slns.Aggregate((null,null),(a,c)=> );

				if (_highPriorityQueue.TryDequeue(out action))
				{
					await action();
					continue;
				}
				if (_lowPriorityQueue.TryDequeue(out action))
				{
					await action();
					continue;
				}
				await Task.Yield();
			}
		}


		public  void _StartTask(FolderI folder)
		{
			_StartTask(folder.ToString());
		}


	}


}