using System.Timers;

namespace scripts.Controller.game
{
    public class MyTimer
    {
        private DateTime now = DateTime.Now;
        private int startTime;
        private int endTime;
        public void Start()
        {
            startTime = int.Parse(now.ToString("mm"));
        }

        public void Stop()
        {
            endTime = int.Parse(now.ToString("mm"));
        }

        public int GetTime()
        {
            if (startTime == endTime)
            {
                return 0;
            }
            
            int totalTime;
            
            if (startTime > endTime)
            {
                int endToSixty = 60 - endTime;
                int startToSixty = 60 - startTime;

                totalTime = endToSixty + startToSixty;

                return totalTime;
            }

            totalTime = endTime - startTime;
            return totalTime;
        }
    }
}