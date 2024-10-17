using webscanner.Debugging;

namespace webscanner
{
    public class webscannerConsts
    {
        public const string LocalizationSourceName = "webscanner";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c1e2563e71c643ecbda0ef948cd783bd";
    }
}
