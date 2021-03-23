using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_Core_API.Helper
{
    public static class CustomValidator
    {
        public static List<string> getErrorsByModel(ModelStateDictionary model)
        {
            var errors = new List<string>();

            var errorCollection = model.Where(t => t.Value.Errors.Count > 0)
                .ToDictionary(
                    v => v.Key,
                    v => v.Value.Errors.Select(e => e.ErrorMessage).ToArray()[0]
                );

            foreach(var item in errorCollection)
            {
                errors.Add(item.Value);
            }

            return errors;
        }
    }
}
