using System.Collections.Generic;

namespace MqttClient
{
    public interface IToastMessage
    {
        void ShowText(IList<string> lines);
        void ShowImage(IList<string> lines, string imageUrl);
    }
}