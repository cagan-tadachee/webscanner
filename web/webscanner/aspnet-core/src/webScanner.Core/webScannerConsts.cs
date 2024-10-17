using webScanner.Debugging;

namespace webScanner
{
    public class webScannerConsts
    {
        public const string LocalizationSourceName = "webScanner";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "09cba1959e72411794fde78851b978f7";
    }
}
