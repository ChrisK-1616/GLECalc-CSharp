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


Design and Implementation Notes
===============================

<h3>Note:-</h3> please refer to the code comments provided in the various solution <b>*.cs</b> files to get more insight into the operation and
design of the overall solution, in particular the files:-

- <b>ISimpleCalculator.cs</b> located in project <b>SimpleCalculator</b>
- <b>SimpleCalculatorByApi.cs</b> located in project <b>SimpleCalculator</b>
- <b>SimpleCalculatorByApiTestFixture.cs</b> located in project <b>SimpleCalculatorLibraryTests</b>
- <b>Program.cs</b> located in project <b>SimpleCalculator.API</b>
- <b>Controllers/SimpleCalculatorController.cs</b> located in project <b>SimpleCalculator.API</b>

The SimpleCalculator class library and associated unit tests, the ASPNET Core Web API and the relevant elements of the Angular UI app has been
built using .Net Core 7.0. This will need to be installed in order to run the solution.

<h3>API Testing:-</h3> The API element of the solution (found in project <b>SimpleCalculator.API</b>) utilises the Swagger middleware to allow
testing of the API project through Visual Studio and a suitable browser, please use either the "Https" or "Http" run configurations for this.


<h3>API Constraints</h3> The API does not implement authentication/authorisation, logging or versioning since this is a small API that would
not currently benefit from these. They can be introduced in the future but will increase the complexity of the solution greatly for currently
very little advantage.

The package "Microsoft.AspNetCore.Cors" (v2.2.0) has been used to get over issues of CORS protection when connecting to
the API through the Angular app. This requires the Angular app to be served using port 12864 so the CORS protection can be circumvented when
testing the development version of the applications.

To deploy the API ensure it is listening on <code>localhost:5000</code> as this is the host address for the endpoints which are coded in the
Angular app service. This can quickly be achieved by running the <code>SimpleCalculator.API.exe</code> executable that is built by Visual
Studio and is located in the "bin/Debug/net7.0" folder of the "SimpleCalculator.API" project. This should result in the API listening on the 
correct host and port.


<h3>SimpleCalculator UI - Angular App</h3> The web-based front end is implemented using:-

<p><br>Angular CLI: 15.2.5<br>
Node: 18.16.1<br>
Package Manager: npm 9.7.2<br>
Angular: 15.2.6<br>
rxjs: 7.8.0<br>
typescript: 4.9.5<br><br></p>

Make sure that the API is being served on <code>localhost:5000</code> and then you can use the <code>ng serve --port 12864</code> command to
run the Angular app. Use a suitable browser and navigate to URL <code>http://localhost:12864</code> to access the UI for the Simple Calculator.
Once you have access to the web page you can enter required values into the input fields and use the "Add" and the "Subtract" buttons to display
the result of the selected calculation (shown to the right of the "Result:" text). There are also a pair of radio buttons to allow the
background colour of the calculator element of the UI to be swapped between an orange and a salmon colour.

The author makes apologies for the rather "rough and ready" style for the UI - with further time and effort this could be enhanced.

Overall considering the tasks set in the challenge the author feels the majority have been achieved, however the last two tasks are of a rather
low quality and the overall UI web page is not "pop-up" styled.

Regards,

Chris Knowles





