using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using FNF.Utility;

namespace DiscordBouyomichan
{
    public class BouyomichanClient : IDisposable
    {
        private IpcClientChannel channel;
        private BouyomiChanRemoting remoting;

        public BouyomichanClient()
        {
            channel = new IpcClientChannel("hohoge", null);
            ChannelServices.RegisterChannel(channel, false);
            remoting = Activator.GetObject(typeof(BouyomiChanRemoting), "ipc://BouyomiChan/Remoting") as BouyomiChanRemoting;
        }

        public void Dispose()
        {
            if (channel != null)
            {
                ChannelServices.UnregisterChannel(channel);
                channel = null;
            }
        }

        public void AddTalkTask(string text)
        {
            if (remoting != null)
            {
                remoting.AddTalkTask(text);
            }
        }

        public int TalkTaskCount
        {
            
            get { return remoting.TalkTaskCount; }
        }
    }
}
