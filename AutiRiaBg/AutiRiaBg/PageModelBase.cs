using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutiRiaBg
{
    public class PageModelBase : PageModel
    {
        private IMediator _mediator;
        /// <summary>
        /// This field provides logic for mediator pattern.
        /// </summary>
        protected IMediator Mediator => _mediator ?? (_mediator = (IMediator)HttpContext.RequestServices.GetService(typeof(IMediator)));

    }
}
