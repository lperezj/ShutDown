namespace ShutDown.Service
{
    public interface IShutDownService
    {
        /// <summary>
        /// https://stackoverflow.com/questions/46452767/how-to-shutdown-android-device-in-c-sharp-xamarin
        /// </summary>
        void ShutDown();

        /// <summary>
        /// https://stackoverflow.com/questions/22763020/how-to-shut-down-android-phone-programmatically
        /// </summary>
        void ShutDownProcess();

        /// <summary>
        /// https://stackoverflow.com/questions/10411650/how-to-shutdown-an-android-mobile-programmatically
        /// </summary>
        void ShutdownSystem();
    }
}