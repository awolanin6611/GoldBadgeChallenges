using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class DriverData
    {
        public int OverTheLimit { get; set; }
        public int FollowTheLimit { get; set; }
        public int StayInLane { get; set; }
        public int RollThroughStop { get; set; }
        public int FollowTooClose { get; set; }

        public DriverData(){}

        public DriverData(int overTheLimit, int followTheLimit, int stayInLane, int rollThroughStop, int followTooClose)
        {
            OverTheLimit = overTheLimit;
            FollowTooClose = followTheLimit;
            StayInLane = stayInLane;
            RollThroughStop = rollThroughStop;
            FollowTooClose = followTheLimit;
        }

    }

}
