namespace Profile.API.Base.ViewModels
{
    public class BasePaginatedViewModel<T>
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
