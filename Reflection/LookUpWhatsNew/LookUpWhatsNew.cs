using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WhatsNewAttributes;


namespace LookUpWhatsNew
{
    internal class WhatsNewChecker
    {
        private static readonly StringBuilder outputText = new StringBuilder(1000);
        private static DateTime backDateTo = new DateTime(2010, 2, 1);

        private static void Main()
        {
            Assembly theAssembly = Assembly.Load("VectorClass");
            string name = theAssembly.FullName;

            AddToMessage("Assembly: " + name);

            //Check if assemble supports WhatsNewAttribute...
            //...
            Type t = typeof(int);
            Assembly supportsAttribute = Assembly.GetAssembly(t);
            if (supportsAttribute == null)
            {
                AddToMessage(
                    "This assembly does not support WhatsNew attributes");
                return;
            }
            else
            {
                AddToMessage("Defined Types:");
            }

            Type[] types = theAssembly.GetTypes();
            foreach (Type definedType in types)
                DisplayTypeInfo(definedType);

            MessageBox.Show(outputText.ToString(),
                            "What\'s New since " + backDateTo.ToLongDateString());
            Console.ReadLine();
        }

        private static void DisplayTypeInfo(Type type)
        {
            // make sure we only pick out classes, if not return...
            //...

            AddToMessage("\nclass " + type.Name);

            //Get cuatom attributes array for input type here
            //...
            object[] attribs = type.GetCustomAttributes(true);
            if (attribs.Length == 0)
                AddToMessage("No changes to this class");
            else
                foreach (Attribute attrib in attribs)
                    WriteAttributeInfo(attrib);

            //Get public methods of input type (class) here
            //...
            //MemberInfo[] methods = type.GetMembers();
            //AddToMessage("CHANGES TO METHODS OF THIS CLASS:");
            //foreach (MethodInfo nextMethod in methods)
            //{
            //    //Get custom attributes attached to each method here
            //    //...
            //    //MethodInfo methodInfo = type.GetMethod(nextMethod.Name);
            //    object[] attribs2 = type.GetCustomAttributes(true);
            //    if (attribs2 != null && attribs2.Length != 0)
            //    {
            //        AddToMessage(
            //            nextMethod.ReturnType + " " + nextMethod.Name + "()");
            //        foreach (Attribute nextAttrib in attribs2)
            //            WriteAttributeInfo(nextAttrib);
            //    }
            //}
        }

        private static void WriteAttributeInfo(Attribute attrib)
        {
            LastModifiedAttribute lastModifiedAttrib =
                attrib as LastModifiedAttribute;
            if (lastModifiedAttrib == null)
                return;

            // check that date is in range
            DateTime modifiedDate = lastModifiedAttrib.DateModified;
            if (modifiedDate < backDateTo)
                return;

            AddToMessage("  MODIFIED: " +
                         modifiedDate.ToLongDateString() + ":");
            AddToMessage("    " + lastModifiedAttrib.Changes);
            if (lastModifiedAttrib.Issues != null)
                AddToMessage("    Outstanding issues:" +
                             lastModifiedAttrib.Issues);
        }

        private static void AddToMessage(string message)
        {
            outputText.Append("\n" + message);
        }
    }
}