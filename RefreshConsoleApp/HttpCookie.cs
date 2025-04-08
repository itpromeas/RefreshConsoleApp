using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefreshConsoleApp
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }


        public string this[string key] // getitem by key: indexer
        {
            get {return _dictionary[key];}
            set { _dictionary[key] = value;}
        
        }

        /*
         If no indexer is defined, one has to define the following
         */

        /*public void SetITem(string key, string value)
        {
            _dictionary[key] = value;
        }

        public string GetITem(string key)
        {
            return _dictionary[key];
        }*/

    }
}
