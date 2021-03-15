using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafenedAPI.Domain;
using SafenedAPI.Models;
using SafenedAPI.Service;
using SafenedAPI.Service.Models;

namespace SafenedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            this.bankAccountService = bankAccountService;
        }

        /// <summary>
        /// Action to create new bank account.
        /// </summary>
        /// <param name="model">Model to create bank account</param>
        /// <returns>Returns created bank account</returns>
        /// <response code="201">Returned if bank account was created</response>
        /// <response code="404">Returned if bank account was not created</response>
        [HttpPost]
        public async Task<ActionResult> Post(CreateBankAccountModel model)
        {
            var bankAccount = await bankAccountService.CreateAccount(model.UserId, model.BankId, model.Balance);
            if (bankAccount)
            {
                // TODO: return created entity id
                return StatusCode(201);
            }

            return BadRequest();
        }

        /// <summary>
        /// Action to get bank accounts list of specific user.
        /// </summary>
        /// <param name="id">Model to user id</param>
        /// <returns>Returns the lists of bank accounts</returns>
        /// <response code="200">Returned if there is any bank account of user</response>
        /// <response code="404">Returned if there is no bank account</response>
        [HttpGet("user/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<BankAccountModel> GetAccountList(Guid id)
        {
            var accounts = bankAccountService.GetBankAccountListByUser(id);
            if (accounts != null && accounts.Count > 0)
            {
                return Ok(accounts);
            }

            return NotFound();
        }

        /// <summary>
        /// Action to delete bank account.
        /// </summary>
        /// <param name="id">Model to bank account id </param>
        /// <returns>Returns the boolean result of login</returns>
        /// <response code="204">Returned if the delete was successful</response>
        /// <response code="400">Returned if there is no bank account with that id</response>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete(Guid id)
        {
            var result = bankAccountService.Delete(id);
            if (result)
            {
                return StatusCode(204);
            }

            return NotFound();
        }
    }
}
