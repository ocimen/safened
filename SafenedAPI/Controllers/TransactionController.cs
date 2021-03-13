using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SafenedAPI.Models;
using SafenedAPI.Service;

namespace SafenedAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            this.transactionService = transactionService;
        }

        /// <summary>
        /// Action to deposit.
        /// </summary>
        /// <param name="model">Model to deposit</param>
        /// <returns>Returns the lists of bank accounts</returns>
        /// <response code="201">Returned if deposit was successful</response>
        /// <response code="400">Returned if any error occurs</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("deposit")]
        public ActionResult Deposit(TransactionModel model)
        {
            var result = transactionService.Deposit(model.SenderId, model.ReceiverId, model.Amount);
            if (result)
            {
                // If transaction table will be added to this scenario returning 201 is more suitable 
                return StatusCode(201);
            }

            return BadRequest("Not sufficent balance");
        }

        /// <summary>
        /// Action to withdraw.
        /// </summary>
        /// <param name="model">Model to withdraw</param>
        /// <returns>Returns the lists of bank accounts</returns>
        /// <response code="201">Returned if withdraw was successful</response>
        /// <response code="400">Returned if any error occurs</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("withdraw")]
        public ActionResult Withdraw(TransactionModel model)
        {
            var result = transactionService.Withdraw(model.SenderId, model.ReceiverId, model.Amount);
            if (result)
            {
                // If transaction table will be added to this scenario returning 201 is more suitable 
                return StatusCode(201);
            }

            return BadRequest("Not sufficent balance");
        }
    }
}
