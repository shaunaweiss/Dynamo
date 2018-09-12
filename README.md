# Dynamo
Workout Generator

# Dynamo Installation Guide
Please use this video to guide you in cloning, building and running Dynamo. 
https://www.youtube.com/watch?v=1uZEd9w0nXo

# Introduction
Dynamo is a  web based application that will assist users in building a weekly workout plan. Each user will fill out various fields including his/her gender, targeted body-tone area,  current and targeted weight,  height, age, and  intensity, all of which will aide Dynamo in creating a custom workout for each user. Upon submitting the user form,  the user will be redirected to a page with his/her custom workout as well as a statistics module about the user and the specified routine. 

# Installation and Build Guide Details
  Prerequisites
    Visual Studio IDE
     GIT Bash
     C# .NET Framework
     Understanding of HTML/Razor Pages

# Details
Dynamo requires Visual Studio to be run. Instructions on how to install Visual Studio can be found in section 2.3.2 below. A step by step walk through video on how to clone Dynamo and navigate through the solution can be found in 2.3.2 below. To install Dynamo, first open Visual Studio. 

# Instructions: How to Clone Project: 
Navigate to View > Team Explorer.
On the toolbar of Team Explorer, click the green button that when hovered says “Manage Connections.”
 Click “Clone” right beneath where it says “Local Git Repositories.” 
Enter this link https://github.com/weisssa2/Dynamo.git to where it says “Enter the URL…” (If you want to, you can choose the destination of the cloned repo, or use the default one)
Click clone.
Instructions: How to Run the Project
Under Solution ‘Dynamo’ (2 projects), open tab Dynamo.
Tab open the Views folder
Under the Home folder, open Index.cshtml
In the top menu, make sure you have the selected test browser to be Google Chrome (Industry Standard).
Click the green button next to Google Chrome to run the project. 

Instructions: How to View Unit Test
Navigate to the Team Explorer button at the bottom of the menu (next to Solution Explorer) If this tab is not there, Click View/Team Explorer. 
Click on branches
Under remote/origins double click on testing branch.
Click back on the Solution Explorer tab at the bottom of the menu.
Scroll down and click on either the UnitTest_ProcessClass or UnitTest_UserClass


# Important Links 
Dynamo Installation Guide Video https://youtu.be/1uZEd9w0nXo
Install Visual Studio https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio
Dynamo Github repository https://github.com/weisssa2/Dynamo
MVC Documentation https://docs.microsoft.com/en-us/aspnet/mvc/mvc4
Original Bootstrap template http://blazrobar.com/free-psd-website-templates/fitness-free-photoshop-psd-template/

# User’s Guide
Dynamo is composed of two main navigable pages:
Home Page (Home/Index.cshtml)
On the main page, there is information about Dynamo itself, references to other health/exercise focused websites, and a contact button that links you to email one of Dynamo’s developers.
Generator (Generator/Index.cshtml) (redirects to Generator/Index.cshtml)
The generator page is where the workout generation functionality is. On that page, there is a form to fill out. Once submitted, the workout is generated, and shown, along with the user’s inputted data.
Dynamo was created using ASP.NET MVC in Visual Studio. Dynamo V2 is only available on a  local machine, so a user must follow the same instructors mentioned above in the 2.2 Instructions: How to Run To the Project.

Dynamo can be closed in the same way any typical browser can be exited. To stop running the project, a user must click the red square box at the top of the Visual Studio menu.  

To view our webpage in a Mobile Format, please inspect button found via right clicking on the homepage and clicking inspect  (using chrome). Click on the phone/tablet button in blue. 




# Gallery Maintenance
All the pictures used on the website can be located at [root]\Dynamo\Content\assets\img
All the css files are located at [root]\Dynamo\Content\dist\assets\css (main.min.css)
All the javascript files are located at [root]\Dynamo\Content\assets\js

** Original Bootstrap template can be found in Section 2.3.5 above. 

# Known Issues and Vulnerabilities
Issues Resolved
Users could not select the form item “Cardio” without getting an error.
Users could not select “Flexibility” and “Lower Body” at the same time, because there was not the 6 (default number of workouts generated) exercises that fell under both categories. 
Program crashes when a field data is left blank.

# Issues that may continue to put Dynamo at Risk
If you add letter to a form element that is supposed to be numbers, it does not break the game, but it also does not tell the user they have entered incorrect data. 
The user may not know they have option to choose other type/focuses because we have it defaulting to a value for validation handling purposes. 
If a user tries to directly navigate to localhost/Generator/ViewModel without having submitted a form before, an error will be rendered: “\This resource cannot be found.”
If a user fills out the height, weight or age form fields with letters instead of numbers, an error will not be thrown and the statistics tables may give back values of 0 or NaN. 
