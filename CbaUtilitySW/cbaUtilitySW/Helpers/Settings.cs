// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace cbaUtility.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
        private static ISettings AppSettings =>
          CrossSettings.Current;

        public static bool GetMangelNotifications
        {
            get => AppSettings.GetValueOrDefault(nameof(GetMangelNotifications), false);
            set => AppSettings.AddOrUpdateValue(nameof(GetMangelNotifications), value);
        }
    }
}