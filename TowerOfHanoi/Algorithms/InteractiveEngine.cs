using System;
using TowerOfHanoi.DataStructures;
using TowerOfHanoi.Models;

namespace TowerOfHanoi.Algorithms
{
    internal class InteractiveEngine
    {
        public Tower TowerA { get; private set; }
        public Tower TowerB { get; private set; }
        public Tower TowerC { get; private set; }

        private MyStack moveHistory;

        public int MoveCount { get; private set; }
        // Store the total disks to check for the win condition
        public int TotalDisks { get; private set; }

        public Action<string> OnLogUpdated;

        public InteractiveEngine()
        {
            TowerA = new Tower("Rod A");
            TowerB = new Tower("Rod B");
            TowerC = new Tower("Rod C");
            moveHistory = new MyStack();
        }

        public void InitializeGame(int diskCount)
        {
            TotalDisks = diskCount; // Save the starting count
            TowerA.GetStack().Clear();
            TowerB.GetStack().Clear();
            TowerC.GetStack().Clear();
            moveHistory.Clear();
            MoveCount = 0;

            for (int i = diskCount; i >= 1; i--)
            {
                TowerA.GetStack().Push(new Disk(i));
            }
            OnLogUpdated?.Invoke("Interactive mode initialized. Click a rod to select, then click another to move!\n");
        }

        public bool TryMoveDisk(Tower source, Tower destination)
        {
            if (source.GetStack().IsEmpty())
            {
                OnLogUpdated?.Invoke($"Invalid: {source.GetName()} is empty.\n");
                return false;
            }

            Disk movingDisk = (Disk)source.GetStack().Peek();

            if (!destination.GetStack().IsEmpty())
            {
                Disk destTopDisk = (Disk)destination.GetStack().Peek();
                if (movingDisk.GetSize() > destTopDisk.GetSize())
                {
                    OnLogUpdated?.Invoke($"Invalid: Cannot place Disk {movingDisk.GetSize()} on Disk {destTopDisk.GetSize()}.\n");
                    return false;
                }
            }

            source.GetStack().Pop();
            destination.GetStack().Push(movingDisk);

            moveHistory.Push(new MoveRecord(source, destination, movingDisk));
            MoveCount++;

            OnLogUpdated?.Invoke($"Moved Disk {movingDisk.GetSize()} from {source.GetName()} to {destination.GetName()}.\n");
            return true;
        }

        public bool UndoLastMove()
        {
            if (moveHistory.IsEmpty())
            {
                OnLogUpdated?.Invoke("No moves left to undo.\n");
                return false;
            }

            MoveRecord lastMove = (MoveRecord)moveHistory.Pop();
            Disk diskToUndo = (Disk)lastMove.ToTower.GetStack().Pop();
            lastMove.FromTower.GetStack().Push(diskToUndo);

            MoveCount--;
            OnLogUpdated?.Invoke($"Undo: Reversed Disk {diskToUndo.GetSize()} back to {lastMove.FromTower.GetName()}.\n");
            return true;
        }

        // Check if all disks have been successfully moved to Tower C
        public bool IsSolved()
        {
            return TowerC.GetStack().GetSize() == TotalDisks;
        }
    }
}