using System.Collections.Generic;

namespace _08_Challenge
{
    public class InsuranceRepository
    {
        List<DriverData> _driverData = new List<DriverData>();

        public void AddDriverToList(DriverData driverInfo)
        {
            _driverData.Add(driverInfo);
        }

        public List<DriverData> GetDriverData()
        {
            return _driverData;
        }
        public decimal DriverInsruance(DriverData driverInfo)
        {
            decimal insurance = 100.00m;

            if (driverInfo.FollowTheLimit >= 100)
            {
                insurance -= 25.00m;
            }
            else if (driverInfo.OverTheLimit >= 100)
            {
                insurance += 100.00m;
            }

            if (driverInfo.FollowTooClose >= 20 && driverInfo.FollowTooClose
                <= 40)
            {
                insurance += 15.00m;
            }
            else if (driverInfo.FollowTooClose >= 41 && driverInfo.FollowTooClose <= 60)
            {
                insurance += 30.00m;
            }
            else if (driverInfo.FollowTooClose >= 61)
            {
                insurance += 60.00m;
            }

            if (driverInfo.RollThroughStop >= 20 && driverInfo.RollThroughStop <= 60)
            {
                insurance += 20.00m;
            }
            else if (driverInfo.RollThroughStop >= 61 && driverInfo.RollThroughStop <= 70)
            {
                insurance += 40.00m;
            }
            else if (driverInfo.RollThroughStop > 71)
            {
                insurance += 80.00m;
            }

            if (driverInfo.StayInLane >= 70)
            {
                insurance -= 30.00m;
            }

            return insurance;
        }
    }
}
