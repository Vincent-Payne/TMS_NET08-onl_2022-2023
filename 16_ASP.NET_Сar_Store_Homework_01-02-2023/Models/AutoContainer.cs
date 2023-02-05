namespace _16_ASP.NET_Practice_01_02_2023.Models
{
    [Serializable]
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

        public AutoContainer()
        {
           autos = new List<Auto>();
        }
    }
}
