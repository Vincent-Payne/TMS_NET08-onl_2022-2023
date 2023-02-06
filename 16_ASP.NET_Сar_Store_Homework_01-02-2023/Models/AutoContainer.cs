namespace _16_ASP.NET_Practice_01_02_2023.Models
{
    public class AutoContainer
    {
        private List<Auto> autos;

        public uint GetLastElementId => autos.Count == 0 ? 0 : autos.Last().Id;
        public List<Auto> GetAutos()
        {
            return autos;
        }
        public void AddAuto(Auto auto)
        {
            autos.Add(auto);
        }

        public void Clear()
        {
            autos.Clear();
        }

        public void DeleteCar(uint id)
        {
            Auto temp = autos.Find(item => item.Id == id);
            autos.Remove(temp);
        }

        public AutoContainer()
        {
           autos = new List<Auto>();
        }
    }
}
