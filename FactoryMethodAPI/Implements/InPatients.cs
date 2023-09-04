using FactoryMethodAPI.Interfaces;

namespace FactoryMethodAPI.Implements
{
    public class InPatients : IinPatient
    {
        public string AssignBed()
        {
            string bednum = "A1";
            return bednum;
        }

        public bool NeedSurgery(bool check)
        {
            //update surgery available date if yes
            return check;
        }
    }
}
