using System.Text.Json.Serialization;

namespace CheckIt.Dto
{
    public class ExpenseDto
    {
        public string Description { get; set; } = string.Empty;
     
        public DateTime Date { get; set; } = DateTime.Now;

        public float Cost { get; set; } = 0;
    }
}
