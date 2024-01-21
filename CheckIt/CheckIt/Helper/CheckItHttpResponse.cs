using CheckIt.Dto;

namespace CheckIt.Helper
{
    public class CheckItHttpResponse<T>
    {
       public T? expenseDtos { get; set; }

        public float totalExpenses { get; set; } = 0;

        public int Status { get; set; } = 200;

       public string StatusMessage { get; set; } = string.Empty;

    }
}
