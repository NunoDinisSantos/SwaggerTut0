using AutoMapper;
using CheckIt.Dto;
using CheckIt.Helper;

namespace CheckIt.Mapper
{
    public class ConvertToExpenseDto : Profile
    {
        public ConvertToExpenseDto()
        {
            CreateMap<Expense, ExpenseDto>();
            CreateMap<ExpenseDto, Expense>();
        }
    }
}
