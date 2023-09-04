using FactoryMethodAPI.Implements;
using FactoryMethodAPI.Interfaces;

namespace FactoryMethodAPI.Factories
{
    public class PatientFactory
    {
        switch case
        public static IinPatient GetPatientInfo(bool Surgery)
        {
            IinPatient inptnt = null;

            inptnt = new InPatients();
            inptnt.NeedSurgery(Surgery);

            return inptnt;
        }

        public static IoutPatient GetOutPatientInfo(bool Casuality)
        {
            IoutPatient Outptnt = null;

            Outptnt = new OutPatients();
            Outptnt.HasCasuality(Casuality);

            return Outptnt;
        }
    }
}
