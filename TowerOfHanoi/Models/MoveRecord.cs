namespace TowerOfHanoi.Models
{
    internal class MoveRecord
    {
        public Tower FromTower { get; }
        public Tower ToTower { get; }
        public Disk MovedDisk { get; }

        public MoveRecord(Tower from, Tower to, Disk disk)
        {
            FromTower = from;
            ToTower = to;
            MovedDisk = disk;
        }
    }
}