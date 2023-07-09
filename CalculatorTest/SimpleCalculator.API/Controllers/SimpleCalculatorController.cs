// Author: Chris Knowles
// Date: Jul 2023
// File: SimpleCalculatorController.cs
// Version: 1.0.0

using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculator.API.Controllers
{
    /// <summary>
    /// Controller class for actions associated with the utilisation of an injected concrete implementation
    /// of the <see cref="ISimpleCalculator"/> interface
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleCalculatorController : ControllerBase
    {
        /// <summary>
        /// Property <c>simpleCalculator</c>: Injected concrete instance of <see cref="ISimpleCalculator"/> 
        /// </summary>
        private readonly ISimpleCalculator simpleCalculator;

        public SimpleCalculatorController(ISimpleCalculator simpleCalculator)
        {
            this.simpleCalculator = simpleCalculator;
        }

        /// <summary>
        /// Web API GET action when requesting the <see cref="ISimpleCalculator"/> <c>Add</c> method 
        /// </summary>
        /// <param name="start"> Value to be added to the <c>amount</c> value </param>
        /// <param name="amount"> Value to be added to the <c>start</c> value </param>
        /// <returns> Response as <see cref="IActionResult"/> with included resulk from addition operation
        /// as provided by the injected <see cref="ISimpleCalculator"/> implementation
        /// </returns>
        /// <exception></exception>
        /// <example>Request URL of form http://localhost:5269/api/Add?start=10&amount=5 will return
        /// response of <c>15</c>
        /// </example>
        /// <code></code>
        /// <remarks></remarks>
        [HttpGet]
        [Route("[action]")]
        public IActionResult Add([FromQuery] int start, [FromQuery] int amount)
        {
            return Ok(simpleCalculator.Add(start, amount));
        }

        /// <summary>
        /// Web API GET action when requesting the <see cref="ISimpleCalculator"/> <c>Subtract</c> method 
        /// </summary>
        /// <param name="start"> Value to be subtracted from by the <c>amount</c> value </param>
        /// <param name="amount"> Value to be subtracted from the <c>start</c> value </param>
        /// <returns> Response as <see cref="IActionResult"/> with included result from subtraction operation
        /// as provided by the injected <see cref="ISimpleCalculator"/> implementation
        /// </returns>
        /// <exception></exception>
        /// <example>Request URL of form http://localhost:5269/api/Subtract?start=10&amount=5 will return
        /// response of <c>5</c>
        /// </example>
        /// <code></code>
        /// <remarks></remarks>
        [HttpGet]
        [Route("[action]")]
        public IActionResult Subtract([FromQuery] int start, [FromQuery] int amount)
        {
            return Ok(simpleCalculator.Subtract(start, amount));
        }
    }
}
