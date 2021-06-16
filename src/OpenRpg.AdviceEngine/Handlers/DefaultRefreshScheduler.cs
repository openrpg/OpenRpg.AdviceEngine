using System;
using System.Reactive;
using System.Reactive.Linq;

namespace OpenRpg.AdviceEngine.Handlers
{
    public class DefaultRefreshScheduler : IRefreshScheduler
    {
        public IObservable<Unit> DefaultRefreshPeriod { get; } =  Observable.Timer(TimeSpan.FromSeconds(0.5)).Select(x => Unit.Default);
    }
}