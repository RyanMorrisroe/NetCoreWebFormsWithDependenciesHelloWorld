using log4net;
using ProtoBuf;
using HelloWorld.Library1;

namespace HelloWorld.Library2
{
    public class Class2
    {
        public LogManager logger;
        public ProtoWriter writer;

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int SubtractThenAdd(int a, int b, int c)
        {
            return Class1.Addition(Subtraction(a, b), c);
        }
    }
}
