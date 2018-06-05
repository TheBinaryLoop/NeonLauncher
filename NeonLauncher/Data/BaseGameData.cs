using System;
using System.Drawing;

namespace NeonLauncher
{
    public abstract class BaseGameData
    {
        public int NeonId { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Executable { get; set; }
        public string DirectoryPath { get; set; }
        public Icon Icon { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
