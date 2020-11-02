using System;

namespace Checkers
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            GameSettingsForm gameSettings = new GameSettingsForm();
            gameSettings.ShowDialog();
        }
    }
}