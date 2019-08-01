﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetValidator
{
    public static partial class SanitizationUtility
    {
        /// <summary>
        /// A Sanitizer that modifies the current Property value with a new uppercase copy
        /// <para>Supported Data Types : Strings</para>
        /// </summary>
        /// <param name="model">The validation model to add more validations or sanitization</param>
        /// <returns>A ValidationModel</returns>
        public static ValidationModel ToUpper(this ValidationModel model)
        {
            try
            {
                model.SetValue(model.GetValue().ToString().ToUpper());
            }
            catch (Exception)
            {
            }
            return model;
        }
    }
}