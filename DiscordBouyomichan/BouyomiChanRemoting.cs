using System;

namespace FNF.Utility
{
    public class BouyomiChanRemoting : MarshalByRefObject
    {
        public void AddTalkTask(string sTalkText) { }
        public void AddTalkTask(string sTalkText, int iSpeed, int iVolume, int vType) { }
        public void AddTalkTask(string sTalkText, int iSpeed, int iTone, int iVolume, int vType) { }
        public int AddTalkTask2(string sTalkText) { throw null; }
        public int AddTalkTask2(string sTalkText, int iSpeed, int iTone, int iVolume, int vType) { throw null; }
        public void ClearTalkTasks() { }
        public void SkipTalkTask() { }

        public int TalkTaskCount { get { throw null; } }
        public int NowTaskId { get { throw null; } }
        public bool NowPlaying { get { throw null; } }
        public bool Pause { get { throw null; } set { } }
    }
}
