﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Cryptography;
using System.Text;

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

        public static long GenerateSaltAsLong()
        {
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);

            return BitConverter.ToInt64(salt, 0);
        }
    }
}