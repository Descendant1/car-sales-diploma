namespace AutoRiaBg.Application.Models
{
    using System.Collections.Generic;
    using System.Linq;
    public class ActionResult
    {
        internal ActionResult(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static ActionResult Success()
        {
            return new ActionResult(true, new string[] { });
        }

        public static ActionResult Failure(IEnumerable<string> errors)
        {
            return new ActionResult(false, errors);
        }
    }
}
