using System;
using Windows.ApplicationModel;
using Windows.Foundation.Metadata;


namespace MainApp.Connector
{
    public delegate void NotifyAppHandler(string str);
    [AllowForWeb]
    public sealed class HtmlCommunicator
    {
        public event NotifyAppHandler OnNotifyApp;
        public void getHtmlSpecificEvent(string str)
        {
            OnNotifyApp?.Invoke(str);
            // do something else
        }

        public string getAppVersion()
        {
            PackageVersion version = Package.Current.Id.Version;
            return String.Format("{0}.{1}.{2}.{3}",
                                 version.Major, version.Minor, version.Build, version.Revision);
        }

    } 

}
