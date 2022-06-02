namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Lock();
            house.Amount();
            house.Equals(house);
            house.ToString();
            house.GetHashCode();

        }
    }
}
