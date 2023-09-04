namespace FactoryMethodAPI.Interfaces
{
    public interface IinPatient
    {
        public bool NeedSurgery(bool check);
        public string AssignBed();
    }
}
