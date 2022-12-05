using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    /// <summary>
    /// Strings basics.
    /// </summary>
    class TypesString
    {
        string message1;
        string message2 = null;
        string message3 = string.Empty;
        static string text = "Some plain string.";
        string quotedText = "Some \"quote\"";
        static string pathSlash = "C:\\windows";
        string verbatimStr = @"C:\windows";

        string concated = String.Concat("text1; ", "text2; ", "text3; ");
        string simplyConcat = "text1; " + "text2; " + "text3; ";

        string interpolatedString = $"{text} text text {pathSlash} text text.";

        StringBuilder strBuild = new StringBuilder();

        public void exF()
        {
            strBuild.Append(text);
            strBuild.Append(pathSlash);
            strBuild.Append("text");
            strBuild.ToString();
        }

    }
}
