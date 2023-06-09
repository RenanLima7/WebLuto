﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.Reflection;

namespace WebLuto.Utils
{
    public static class UtilityMethods
    {
        public static KeyValuePair<string, HashSet<string>>[] GetFieldsErrors(ModelStateDictionary ModelState)
        {
            Dictionary<string, HashSet<string>> fieldsErrors = new Dictionary<string, HashSet<string>>();
            foreach (string key in ModelState.Keys)
            {
                if (ModelState[key].Errors.Count > 0)
                {
                    HashSet<string> errors = new HashSet<string>();
                    foreach (var error in ModelState[key].Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                    fieldsErrors.Add(key, errors);
                }
                else
                {
                    fieldsErrors.Add(key, new HashSet<string>());
                }
            }
            return fieldsErrors.ToArray();
        }

        public static int GenerateSalt()
        {
            return new Random().Next(111111, 999999);
        }

        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            return field.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }

        public static string GenerateRandomFileName()
        {
            return Guid.NewGuid().ToString() + ".jpg";
        }
    }
}
