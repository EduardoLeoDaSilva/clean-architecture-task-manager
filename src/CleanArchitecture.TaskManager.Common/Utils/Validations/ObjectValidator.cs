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
    public class ObjectValidator<T>
    {
        private Dictionary<string, (dynamic @object, Func<T ,bool> expression, string msg, Exception exception)> Validations;


        public static ObjectValidator<T> CreateValidator()
        {
            return new ObjectValidator<T>();
        }

        private ObjectValidator()
        {
            Validations = new Dictionary<string, (dynamic @object, Func<T, bool> expression, string msg, Exception exception)>();
        }

        public ObjectValidator<T> RuleFor<E>(dynamic @object, Func<T, bool> expression, string message) where E : Exception
        {

            E Exception = new Exception(message) as E;
            Validations.Add(expression.Target.ToString(), (@object, expression, message, Exception));

            return this;
        }


        public ObjectValidator<T> RuleFor(dynamic @object, Func<T,bool> expression, string message)
        {

            Validations.Add(expression.Target.ToString(), (@object, expression, message, null));

            return this;
        }

        public List<string> Validate()
        {
            var errors = new List<string>();


            foreach (var validator in Validations)
            {
                var isValid = validator.Value.expression.Invoke(validator.Value.@object);
                if (!isValid && validator.Value.exception == null)
                    errors.Add(validator.Value.msg);

                if(!isValid && validator.Value.exception != null)
                    throw validator.Value.exception;

            }

            return errors;
        }
    }
}
