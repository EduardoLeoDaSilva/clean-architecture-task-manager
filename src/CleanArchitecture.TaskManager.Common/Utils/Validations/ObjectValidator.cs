using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Common.Utils.Validators
{
    /// <summary>
    /// Simple object validator based on builder pattern
    /// </summary>
    public class ObjectValidator
    {
        private Dictionary<string, (Func<bool> expression, string msg, Exception exception)> Validations;


        public static ObjectValidator CreateValidator()
        {
            return new ObjectValidator();
        }

        private ObjectValidator()
        {
            Validations = new Dictionary<string, (Func<bool> expression, string msg, Exception exception)>();
        }

        public ObjectValidator RuleFor<E>(Func<bool> expression, string message) where E : Exception
        {

            E Exception = new Exception(message) as E;
            Validations.Add(expression.Target.ToString(), (expression, message, Exception));

            return this;
        }


        public ObjectValidator RuleFor(Func<bool> expression, string message)
        {

            Validations.Add(expression.Target.ToString(), (expression, message, null));

            return this;
        }

        public List<string> Validate()
        {
            var errors = new List<string>();


            foreach (var validator in Validations)
            {
                var isValid = validator.Value.expression.Invoke();
                if (!isValid && validator.Value.exception == null)
                    errors.Add(validator.Value.msg);

                if(!isValid && validator.Value.exception != null)
                    throw validator.Value.exception;

            }

            return errors;
        }
    }
}
