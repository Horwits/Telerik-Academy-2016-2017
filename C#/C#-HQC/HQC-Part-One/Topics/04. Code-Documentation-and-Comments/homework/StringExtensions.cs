﻿namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;  
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary> 
    /// Extends the string class.
    /// </summary> 
    public static class StringExtensions
    {
        /// <summary> 
        /// Converts a string to it's hexadecimal representation. 
        /// </summary> 
        /// <param name="input"> The execution string. </param> 
        /// <returns> Hexadecimal representation of a string. </returns> 
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary> 
        /// Checks if a string has true value.
        /// </summary> 
        /// <param name="input"> Input string.  </param> 
        /// <returns>  Boolean result of the check.  </returns> 
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary> 
        /// Attempt to convert a string to short.
        /// </summary> 
        /// <param name="input"> The input String. </param> 
        /// <returns> The Input string converted to short type. </returns> 
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary> 
        /// Attempt to convert a string to integer.
        /// </summary> 
        /// <param name="input"> The String to be converted. </param> 
        /// <returns> Returns the string value to integer. </returns> 
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary> 
        /// Attempt to convert a string to Long.
        /// </summary> 
        /// <param name="input"> The String to be converted. </param> 
        /// <returns> Returns the string value to long. </returns> 
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary> 
        /// Attempt to converts a string to DateTime.
        /// </summary> 
        /// <param name="input"> Input String. </param> 
        /// <returns> Returns the string value to DateTime. </returns> 
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary> 
        /// Capitalizes the first letter of a string.
        /// </summary> 
        /// <param name="input"> Input String. </param> 
        /// <returns> A string with capitalized first letter. </returns> 
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary> 
        /// Gets a string between start string and end string.
        /// </summary> 
        /// <param name="input"> The Input string. </param> 
        /// <param name="startString"> Extracts the string starting at the first occurrence of startString. </param> 
        /// <param name="endString"> Extracts the string ending at the first occurrence of endString. </param> 
        /// <param name="startFrom"> The starting position. </param> 
        /// <returns> A string between start string and end string. </returns> 
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary> 
        /// Converts Cyrillic characters to Latin.
        /// </summary> 
        /// <param name="input"> Input string. </param> 
        /// <returns> String with converted cyrillic keyboard symbols. </returns> 
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary> 
        /// Converts Latin to Cyrillic Keyboard.
        /// </summary> 
        /// <param name="input"> String with converted keyboard symbols. </param> 
        /// <returns> Returns the converted value to string. </returns> 
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary> 
        /// Validates a user name by a regex <code> @"[^a-zA-z0-9_\.]+" </code>.
        /// </summary> 
        /// <param name="input"> The user name. </param> 
        /// <returns> Converted string with latin representation of cyrillic characters. </returns> 
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary> 
        /// Validating the Latin name of the File.
        /// </summary> 
        /// <param name="input"> Input string. </param> 
        /// <returns> A string with replaced cyrillic characters to their latin representation. </returns> 
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary> 
        /// Gets the first n amount of characters of a string.
        /// </summary> 
        /// <param name="input"> The input string. </param> 
        /// <param name="charsCount"> The number of chars to get. </param> 
        /// <returns> A string with the first n characters. </returns> 
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary> 
        /// Getting the extension of a file.
        /// </summary> 
        /// <param name="fileName"> String representing the file name. </param> 
        /// <returns> The file extension into string. </returns> 
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary> 
        /// Returns the matched file extension.
        /// </summary> 
        /// <param name="fileExtension"> File extension. </param> 
        /// <returns> String representing the matched content type. </returns> 
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };

            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary> 
        /// Converts a string into byte array.
        /// </summary> 
        /// <param name="input"> The string to be converted. </param> 
        /// <returns> Byte array. </returns> 
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}