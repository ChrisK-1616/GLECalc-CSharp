# GL Programming Challenge

This challenge is designed to exercise a number of programming skills which are relevant to the technology used at GL.

Challenge Tasks
===============
 
Visual Studio
-------------
1.	Create an empty solution called CalculatorTest.
2.	Create a class library containing the provided interface:-

   	<p><code>public interface ISimpleCalculator<br>
    {<br>
        public int Add(int start,  int amount);<br>
        public int Subtract(int start, int amount);<br>
    }<br></code></p>

4.	Create a C# class to realize the interface as a C# class and implement the methods.

C#
--
4.	Create unit tests to confirm the functionality performs as expected

Web
---
5.	Create a simple web service that provides access to the calculator implementation 
6.	Create a Web App using Angular or a suitable alternative to provide a user friendly interface to invoke the Calculator operations
7.	Ensure the Calculator operations are performed in a modal popup which has a header and a footer
8.	Add functionality on the main web app page to be able to restyle the look and feel of the modal popup
9.	Ensure the web app can work on a variety of screen sizes and devices


Design and Implementation Rationale
===================================

<h3>Note:-</h3> please refer to the code comments provided in the various solution <b>*.cs</b> files to get more insight into the operation and
design of the overall solution, in particular the files:-

- <b>ISimpleCalculator.cs</b> located in project <b>SimpleCalculator</b>
- <b>SimpleCalculatorByApi.cs</b> located in project <b>SimpleCalculator</b>
- <b>SimpleCalculatorByApiTestFixture.cs</b> located in project <b>SimpleCalculatorLibraryTests</b>
- <b>Program.cs</b> located in project <b>SimpleCalculator.API</b>
- <b>Controllers/SimpleCalculatorController.cs</b> located in project <b>SimpleCalculator.API</b>

<h3>API Testing:-</h3> The API element of the solution (found in project <b>SimpleCalculator.API</b>) utilises the Swagger middleware to allow
testing of the API project through Visual Studio and a suitable browser, please use the "Http" run configuration for this.





