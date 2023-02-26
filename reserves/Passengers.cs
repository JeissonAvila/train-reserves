namespace TrainReserves.reserves
{
    public class Passengers : Reserves
    {
        public string? FullName { get; set; }
        public int Identification { get; set; }

        private static List<Passengers> passengersList = new List<Passengers>();
        
        public void AddPassenger(Passengers passenger)
        {
            passengersList.Add(passenger);
        }

        public bool RemovePassenger(int Identification)
        {
            var findUser = GetPassenger(Identification);
            var result = false;
            if (findUser!=null){
                result = passengersList.Remove(findUser);
                RemoveReserveSpace(findUser.SelectedClassChair, findUser.SelectedPreferenceChair);
            }
            return result;
        }
        public Passengers GetPassenger(int Identification)
        {
            var searchResult = passengersList.Find(passenger => passenger.Identification.Equals(Identification));
            return searchResult;
        }
    }
}