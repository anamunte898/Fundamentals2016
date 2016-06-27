//Putting it inside the namespaces makes the declarations local to that 
//    namespace for the file(in case you have multiple namespaces in the file) 
//    but if you only have one namespace per file then it doesn't 
//    make much of a difference whether they go outside or inside the namespace.

using System;

namespace Fundamentals2016.TestNamespaceInsideUsingUsing
{
    //using System;

    public class Test1
    {
        public DateTime DataNasterii { get; set; }
    }
}

namespace Fundamentals2016.TestNamespaceInsideUsingUsing2
{
    //using System;

    public class Test1
    {
        public DateTime DataNasterii { get; set; }
    }
}