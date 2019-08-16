using System;
using System.Collections.Generic;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace MqttClient
{
    public static class ToastMessage
    {
        public static void ShowText(IList<string> lines)
        {
            var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText04);

            var stringElements = toastXml.GetElementsByTagName("text");
            for (int i = 0; i < stringElements.Length; i++)
                stringElements[i].AppendChild(toastXml.CreateTextNode(lines[i]));

            var toast = new ToastNotification(toastXml);
            toast.Activated += ToastActivated;
            toast.Dismissed += ToastDismissed;
            toast.Failed += ToastFailed;

            ToastNotificationManager.CreateToastNotifier(Utils.AppId).Show(toast);
        }

        public static void ShowImage(IList<string> lines, string imageUrl)
        {
            var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            var stringElements = toastXml.GetElementsByTagName("text");
            for (int i = 0; i < stringElements.Length; i++)
                stringElements[i].AppendChild(toastXml.CreateTextNode(lines[i]));

            var imagePath = "file:///" + imageUrl;

            var toastImageAttributes = toastXml.GetElementsByTagName("image");
            ((XmlElement)toastImageAttributes[0]).SetAttribute("src", imagePath);
            ((XmlElement)toastImageAttributes[0]).SetAttribute("alt", "alt text");

            var toast = new ToastNotification(toastXml);
            toast.Activated += ToastActivated;
            toast.Dismissed += ToastDismissed;
            toast.Failed += ToastFailed;

            ToastNotificationManager.CreateToastNotifier(Utils.AppId).Show(toast);
        }

        private static void ToastFailed(ToastNotification sender, ToastFailedEventArgs args) => throw new NotImplementedException();
        private static void ToastDismissed(ToastNotification sender, ToastDismissedEventArgs args) => throw new NotImplementedException();
        private static void ToastActivated(ToastNotification sender, object args) => throw new NotImplementedException();
    }
}
