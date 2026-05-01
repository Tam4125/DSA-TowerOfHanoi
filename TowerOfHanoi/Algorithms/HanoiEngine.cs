using System;
using System.Threading;
using System.Threading.Tasks;
using TowerOfHanoi.Models;

namespace TowerOfHanoi.Algorithms
{
    internal class HanoiEngine
    {
        public Tower TowerA { get; private set; }
        public Tower TowerB { get; private set; }
        public Tower TowerC { get; private set; }
        public int StepCount { get; private set; }

        // Events to notify Form1 when things happen
        public Action<string> OnMoveCompleted;
        public Action OnStateChanged;

        public HanoiEngine()
        {
            TowerA = new Tower("Rod A");
            TowerB = new Tower("Rod B");
            TowerC = new Tower("Rod C");
        }

        public void InitializeGame(int diskCount)
        {
            TowerA.GetStack().Clear();
            TowerB.GetStack().Clear();
            TowerC.GetStack().Clear();
            StepCount = 0;

            for (int i = diskCount; i >= 1; i--)
            {
                TowerA.GetStack().Push(new Disk(i));
            }
        }

        public async Task SolveAsync(int n, CancellationToken token)
        {
            await MoveDisks(n, TowerA, TowerC, TowerB, token);
        }

        private async Task MoveDisks(int n, Tower source, Tower destination, Tower auxiliary, CancellationToken token)
        {
            if (n == 0) return;

            token.ThrowIfCancellationRequested();

            await MoveDisks(n - 1, source, auxiliary, destination, token);

            // Move data
            Disk movingDisk = (Disk)source.GetStack().Pop();
            destination.GetStack().Push(movingDisk);
            StepCount++;

            // Tell the UI to update the log and redraw
            string logMsg = $"Moved Disk {movingDisk.GetSize()} from {source.GetName()} to {destination.GetName()}\n";
            OnMoveCompleted?.Invoke(logMsg);
            OnStateChanged?.Invoke();

            await Task.Delay(800, token);

            await MoveDisks(n - 1, auxiliary, destination, source, token);
        }
    }
}