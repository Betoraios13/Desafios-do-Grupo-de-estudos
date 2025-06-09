using System.Timers;

namespace scripts.Controller.game
{
    public class MyTimer
    {
        private DateTime theNow = DateTime.Now;
        private int startTime;
        private int endTime;
        public void Start()
        {
            startTime = int.Parse(theNow.ToString("mm"));
        }

        public void Stop()
        {
            endTime = int.Parse(theNow.ToString("mm"));
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

                return Math.Abs(totalTime);
            }

            totalTime = endTime - startTime;
            return totalTime;
        }
    }
}