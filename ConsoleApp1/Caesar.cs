using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Caesar
    {
        static string Library = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static string Pass(string key, int n) 
        {
            while (key.Length<n)
            { key += key; }
            return key.Substring(0, n);     
        }

        public static string Encrypt(string text,string key) 
        {
            var pass = Pass(key, text.Length);
            string intext = "";
            int country = 0;        
            for (int i = 0; i < text.Length; i++)
            {
                var LibrarIndex = Library.IndexOf(text[i]);
                var codeIndex = Library.IndexOf(key[(i - country) % key.Length]);
                if (LibrarIndex<0)
                {
                    intext += text[i];
                    country++;
                }
                else 
                {
                    intext += Library[(LibrarIndex + codeIndex) % Library.Length];         
                }            
            }
            return intext;
            
        }
        public static string Dencrypt(string intext, string key) 
        {
            var pass = Pass(key, intext.Length);
            string text = "";
            int country = 0;
            for (int i = 0; i < intext.Length; i++)
            {
                var LibrarIndex = Library.IndexOf(intext[i]);
                var codeIndex = Library.IndexOf(key[(i - country) % key.Length]);
                if (LibrarIndex < 0)
                {
                    text += intext[i];
                    country++;
                }
                else
                {
                    text += Library[(LibrarIndex - codeIndex+Library.Length) % Library.Length];
                }
            }
            return text;
        }
    }   
}
