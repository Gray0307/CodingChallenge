1. Installation Instruction:
    Install vscode which is opensource from https://code.visualstudio.com/download
    Install .net 5.0 which is a crossplatform framwork.

2. Technology Used:
   Framework : .Net 5.0 
   Application : ASP.Net CORE MVC
   Unit Test : MsTest with MOQ and xunit

3. Implementation as per Requiement: 
   i. With a new Request to open Url ,Html is redering by taking response from Controller.
   ii. This application has two ways to show Brand Details.One is by Redirecting to New page and other is loading
       partial view on button click in the same page implemented as part of Bonus task.
   iii. Its build on .Net CORE 5 so it has inbuilt Dependency injection support , its been implemented as well.
   iv. App has static data , it can be replaced with Entity Framwork core later on.
   v. App supports crossplatform deployment and running as well as its cloud ready.
   vi. App is built using dotnet CLI ,no IDE is required to run or modify it.
   vii. App has UnitTesting functionality using MsTest with MOQ and xunit. 

4. Steps to Run App:
   i. Open the app in VsCode(Open Source).
   ii. Go to Run in Top Manu then select "Run without debugging" or "ctrl+F5"
   iii. To Execute UnitTest Go to View->Terminal.
   iv. In "Terminal" Execute as "dotnet test UnitTest/UnitTest.csproj"  