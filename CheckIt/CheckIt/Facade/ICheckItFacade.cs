using CheckIt.Dto;
using CheckIt.Helper;

namespace CheckIt.Facade
{
    public interface ICheckItFacade
    {
        Task<CheckItHttpResponse<List<Expense>>> GetCurrentMonthExpenses();
        Task<CheckItHttpResponse<ExpenseDto>> AddExpense(ExpenseDto newExpence);
        Task<CheckItHttpResponse<string>> DeleteExpense(int id);
    }
}
