namespace P01_HarvestingFields
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    class HarvestingFields
    {
        private int testInt;
        public double testDouble;
        protected string testString;
        private long testLong;
        protected double aDouble;
        public string aString;
        private Calendar aCalendar;
        public StringBuilder aBuilder;
        private char testChar;
        public short testShort;
        protected byte testByte;
        public byte aByte;
        protected StringBuilder aBuffer;
        private BigInteger testBigInt;
        protected BigInteger testBigNumber;
        protected float testFloat;
        public float aFloat;
        private Thread aThread;
        public Thread testThread;
        private object aPredicate;
        protected object testPredicate;
        public object anObject;
        private object hiddenObject;
        protected object fatherMotherObject;
        private string anotherString;
        protected string moarString;
        public int anotherIntBitesTheDust;
        private Exception internalException;
        protected Exception inheritableException;
        public Exception justException;
        public Stream aStream;
        protected Stream moarStreamz;
        private Stream secretStream;

        public string Harvest(string modifier)
        {
            StringBuilder str = new StringBuilder();
            Type classType = typeof(HarvestingFields);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            Object classInstance = Activator.CreateInstance(classType);

            switch (modifier)
            {
                case "private":
                    foreach (var field in fields.Where(f => f.IsPrivate))
                    {
                        Console.WriteLine($"{modifier} {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "protected":
                    foreach (var field in fields.Where(f => f.IsFamily))
                    {
                        Console.WriteLine($"{modifier} {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "public":
                    foreach (var field in fields.Where(f => f.IsPublic))
                    {
                        Console.WriteLine($"{modifier} {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "all":
                    foreach (var field in fields)
                    {
                        var am = "";
                        if (field.IsFamily)
                            am = "protected";
                        if (field.IsPrivate)
                            am = "private";
                        if (field.IsPublic)
                            am = "public";

                        Console.WriteLine($"{am} {field.FieldType.Name} {field.Name}");
                    }
                    break;
            }

            return str.ToString().Trim();
        }

        //public string ReturnField(FieldInfo[] fields)
        //{
        //    foreach (var field in fields.Where())
        //    {

        //    }
        //}
    }
}
