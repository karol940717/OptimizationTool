namespace IWshRuntimeLibrary
{
    internal interface IWshShortcut
    {
        string TargetPath { get; set; }
        string IconLocation { get; set; }

        void Save();
    }
}