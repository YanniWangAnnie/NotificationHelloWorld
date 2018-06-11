using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using Windows.Networking.PushNotifications;

namespace HelloNotification
{
    public class Notification
    {
        private PushNotificationChannel channel;

        public void Here()
        {
            int b = 3;
            b++;
        }

        public async void CreateChannel()
        {
            try
            {
                this.channel = await PushNotificationChannelManager.CreatePushNotificationChannelForApplicationAsync();
                int a = 3;
                a++;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
