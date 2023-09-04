using FactoryMethodAPI.Interfaces;

namespace FactoryMethodAPI.Implements
{
    public class OutPatients : IoutPatient
    {
        public bool HasCasuality(bool check)
        {
            if (check == null)
            { throw new ArgumentNullException(nameof(check)); }
            else if (check == true)
            {
                //Diagnose Tetatnus injection
                return true;
            }
            return false;
        }

        public string PrescribeMedicines()
        {
            return "Medicines List";
        }
    }
}
