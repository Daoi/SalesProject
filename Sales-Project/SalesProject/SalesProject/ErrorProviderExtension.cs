using System.Collections.Generic;
using System.Windows.Forms;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace ExtensionMethods
{
    //Keep track of current errors with text entry
    public static class ErrorProviderExtensions
    {
        private static Dictionary<Control, int> errors = new Dictionary<Control, int>();

        public static void SetErrorWithCount(this ErrorProvider ep, Control c, string message)
        {
            
            if (message == "")
            {
                if (errors.ContainsKey(c) && errors[c] > 0)
                {
                    errors.TryGetValue(c, out var currentCount);
                    errors[c] = currentCount - 1;
                }
            }
            else
            {
                if (!errors.ContainsKey(c))
                {
                    errors.Add(c, 0);
                }
                
                if (errors[c] != 1)
                {
                    errors.TryGetValue(c, out var currentCount);
                    errors[c] = currentCount + 1;
                }
            }

            ep.SetError(c, message);
        }

        // Checks if errorprovider object linked to textboxes contains any errors
        // For validating textboxes
        public static bool HasErrors(this ErrorProvider ep)
        {
            int count = 0;
            foreach(KeyValuePair<Control, int> entry in errors)
            {
                count += errors[entry.Key];
            }

            return count != 0;
        }

        // Clears errors from the errorprovider
        public static void Forget(this ErrorProvider ep)
        {
            errors = new Dictionary<Control, int>();
            ep.Clear();
        }
    }
}