using System;

namespace MyConsoleApp
{
    public class Scope
    {
        public static void Run()
        {
            Console.WriteLine("=== SCOPE with Fields.Person ===\n");

            // LOCAL SCOPE — person only exists inside Run()
            Fields.Person person = new Fields.Person("Brian", 22);
            Console.WriteLine("1. Local scope (method)");
            Console.WriteLine("   Variable 'person' only lives inside Run().");
            Console.WriteLine($"   {person.ReturnDetails()}\n");

            // FIELD SCOPE — Name and Age are private fields on the object
            Console.WriteLine("2. Field scope (class / instance)");
            Console.WriteLine("   Fields Person has private Name and Age.");
            Console.WriteLine("   Fields belong to the object and stay alive across method calls.\n");

            person.SetName("Mwas");
            person.SetAge(23);
            Console.WriteLine($"   After SetName + SetAge:\n   {person.ReturnDetails()}\n");

            // PARAMETER SCOPE — name/age in setters are NOT the same as Name/Age fields
            Console.WriteLine("3. Parameter scope vs field scope");
            Console.WriteLine("   SetName(string name)  →  'name'  = parameter (method scope only)");
            Console.WriteLine("   private string Name   →  'Name'  = field (object scope)");
            Console.WriteLine("   Inside SetName, the parameter copies into the field: Name = name;\n");

            ShowParameterScope(person);

            // BLOCK SCOPE
            Console.WriteLine("4. Block scope");
            if (person.GetAge() >= 18)
            {
                string greeting = $"Hello, {person.GetName()}!";
                Console.WriteLine($"   Inside if block: {greeting}");
            }
            // Console.WriteLine(greeting);  // ERROR — greeting does not exist here
            Console.WriteLine("   'greeting' only existed inside the if { } block.\n");

            // SHADOWING — parameter hides nothing here, but same idea as Fields setters
            Console.WriteLine("5. Why scope matters in Fields.cs");
            Console.WriteLine("   If you wrote Name = Name in SetName, you'd assign the field to itself.");
            Console.WriteLine("   You need Name = name  (field = parameter) because they are different variables.");
        }

        static void ShowParameterScope(Fields.Person person)
        {
            // 'person' is a parameter — only exists inside this method
            // We cannot see the local 'person' from Run(); this is a different variable
            person.SetName("Alex");
            Console.WriteLine($"   Updated from ShowParameterScope: {person.GetName()}\n");
        }
    }
}
