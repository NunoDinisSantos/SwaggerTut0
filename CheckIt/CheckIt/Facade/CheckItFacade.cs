using AutoMapper;
using CheckIt.Data;
using CheckIt.Dto;
using CheckIt.Helper;
using Microsoft.EntityFrameworkCore;

namespace CheckIt.Facade
{
    public class CheckItFacade : ICheckItFacade
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;

        public CheckItFacade(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CheckItHttpResponse<List<Expense>>> GetCurrentMonthExpenses()
        {
            var response = new CheckItHttpResponse<List<Expense>>();

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            var dbExpenses = await _context.Expenses.Where(x => x.Date.Month.Equals(month) && x.Date.Year.Equals(year)).ToListAsync();

            response.totalExpenses = dbExpenses.Sum(x => x.Cost);
            response.expenseDtos = dbExpenses;

            return response;
        }
        
        public async Task<CheckItHttpResponse<ExpenseDto>> AddExpense(ExpenseDto newExpence)
        {
            var response = new CheckItHttpResponse<ExpenseDto>
            {
                expenseDtos = newExpence,
                totalExpenses = newExpence.Cost
            };

            var expense = _mapper.Map<Expense>(newExpence);

            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();

            return response;
        }

        public async Task<CheckItHttpResponse<string>> DeleteExpense(int id)
        {
            var response = new CheckItHttpResponse<string>();

            var expenseToRemove = await _context.Expenses.Where(x => x.Id == id).FirstAsync();
            _context.Expenses.Remove(expenseToRemove);
            await _context.SaveChangesAsync();

            return response;
        }
    }
}
