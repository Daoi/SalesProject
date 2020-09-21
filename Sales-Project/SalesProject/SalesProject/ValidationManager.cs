using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// Christopher Harms, Kevin Lynch
// CIS 3309 - 001
// May 3rd, 2020
// Project 4 - Sales Project

namespace SalesProject
{
    //Handle validation for text fields. Use Tag field of Tex``tBox to set type of validation to use
    public class ValidationManager
    {
        //Dictionary where a key is a number that is assigned to textboxes "Tag" property. The key returns a Regex anonymous function or string.IsNullOrEmpty
        //The string passed to the validate method is validated using this dictionary
        Dictionary<string, Func<string, bool>> regexDict = new Dictionary<string, Func<string, bool>>()
        {
            {"1", s => Regex.IsMatch(s, @"^((?!(0))[0-9]{5})$")},//UPC
            {"2", s => Regex.IsMatch(s, @"^[$]?(0|[1-9]\d*)(\.\d+)?$")},//Positive decimals(price)
            {"3", s => Regex.IsMatch(s, @"^(0|[1-9]\d*)$")},//Positive integers
            {"4", s => Regex.IsMatch(s, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")},//Name, Author, Actor, etc
            {"5", s => Regex.IsMatch(s, @"^\d{3}(?:-\d{3})$")}, //ISBN
            {"6", s => Regex.IsMatch(s, "^([^,]+,)*[^,]+[^,]$")}, //Instrument List
            {"7", s => !string.IsNullOrEmpty(s)} //Not empty
        };


        public bool Validate(string text, string type)
        {
            Func<string, bool> test = regexDict[type];
            return test(text);
        }

    }
}