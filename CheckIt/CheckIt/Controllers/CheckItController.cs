using CheckIt.Dto;
using CheckIt.Facade;
using CheckIt.Helper;
using Microsoft.AspNetCore.Mvc;

namespace CheckIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckItController : ControllerBase
    {
        private readonly ICheckItFacade _checkItFacade;

        public CheckItController(ICheckItFacade checkItFacade)
        {
            _checkItFacade = checkItFacade;
        }

        [HttpGet("GetMonthlyExpense")]
        public async Task<ActionResult<List<Expense>>> GetCurrentMonthExpenses()
        {
            return Ok(await _checkItFacade.GetCurrentMonthExpenses());
        }

        [HttpPost("AddExpense")]
        public async Task<ActionResult> AddExpense(ExpenseDto despesa)
        {
            return Ok(await _checkItFacade.AddExpense(despesa));
        }

        [HttpDelete("DeleteExpense")]
        public async Task<ActionResult> DeleteExpense(int id)
        {
            return Ok(await _checkItFacade.DeleteExpense(id));
        }

    }
}
