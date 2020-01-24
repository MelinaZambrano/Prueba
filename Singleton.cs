using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaSP
{
    class Singleton
    {

        public string Name { get; set; }
        
            private Singleton()
            {

            }

            private static Singleton _singleton;

            public static Singleton GetInstance()
            {

                if (_singleton == null)
                {

                    _singleton = new Singleton();

                }

                return _singleton;

            }

    }
    
}
