namespace Assignment_8_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) a)
            //What is Abstraction in Object-Oriented Programming?

            /*
             * Abstraction: hiding complex implementation details and showing only the essential features of an object.
             * Showing only what's necessary and hiding how it's done.
             * Focusing on what an object does, not how it does it
             */
            #endregion

            #region Q1) b)
            //Why is abstraction considered one of the four pillars of OOP?

            /*
             * Because it simplifies complexity by focusing on what the object does (what the object does), not the complex how it does.
             * Also provides a blueprint for other pillars. Enables encapsulation (defines "what" and encapsulation defines "how"), polymorphism (provides the common interface for different implementations), and inheritance (provides the blueprint for class hierarchies).
             * It is the starting point for all OOP design.
             */
            #endregion

            #region Q2) a)
            // What is the difference between an Abstract Class and an Interface?

            /*
             * Abstract class: can have fields, can have constructors, can use public, private, and protected access modifiers, class can inherite one class only.
             * Serves as a base for other classes and can not be instantiated.
             * Use abstract class when classes are related and share code.
             * 
             * Inferface: can not have fields, can not have constructors, can only use public access modifier, class can implement mutiple interfaces.
             * A contract that classes must follow. It contains only method signatures (without implementation).
             */
            #endregion

            #region Q2) b)
            //When would you choose an Interface instead of an Abstract Class?

            /*
             *Use interface when unrelated classses need to implement the same behavior. Also, if a multiple behaviors is need to be implemented.
             */
            #endregion

            #region Q2) c)
            //Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            /*
             * No, a class can not inherit from multiple abstract classes. Yes, can implement multiple interface, because interface supports multiple implementation.
             */
            #endregion
        }
    }
}
