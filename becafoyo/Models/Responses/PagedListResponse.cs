namespace becafoyo.Models.Responses
{
    public class PagedListResponse<T>
    {
        public PagedListResponse(List<T> items, int page, int pageSize, int totalCount)
        {
            Items = items;
            Page = page;
            PageSize = pageSize;
            TotalCount = totalCount;
        }
        public List<T> Items { get; }
        public int Page { get; }
        public int PageSize { get; }
        public int TotalCount { get; }
        public bool HasNextPage => Page * PageSize < TotalCount;
        public bool HasPreviousPage => Page > 1;

        public static PagedListResponse<T> Create(List<T> items, int page, int pageSize)
        {
            var totalCount = items.Count;
            var pagedItems = items.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new(pagedItems, page, pageSize, totalCount);
        }
    }
}
