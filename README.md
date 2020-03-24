# Lab 10 Part 1 – Frontend with Bootstrap 
### Round 0: Prepare Your Environment 
- Create an ASP.NET Core Project in that folder using the dotnet new webapp command.   
### Round 1: Make a Razor Page with a Bootstrap Grid Layout 
- Create a new Razor Page (you don’t need the page model yet) in your project.   
- Add an `<h1> </h1>` tag with the text “Lab 10” inside. c. Place an `<hr />` tag underneath.   
- Build a Bootstrap Grid Layout with 2 rows. Remember the container div is already defined in _Layout.cshtml.   
- Row 1 should have 2 columns of size 4 and 8 respectively. Give each column a border with a color of your choice.   - In the first column, just put the text “Column One”.  
- Find an image online for the second column and use the <img> tag to link to it.
  - The image is a static file. Where should you put it so that you can link to it properly?   
- Row 2 should have 3 columns of all different sizes. What should the sizes add up to?   
- Give the columns a border and place whatever text you like in each column.   

### Round 2: Add a Form to your Razor Page 
- In Column One, delete the text and put HTML/Bootstrap code for a form that uses the `HTTP Post` request. The form should contain two inputs, one for first name and the other for last name with a submit button at the bottom. 

### Round 3: Make the Page Model 
- Create a Page Model (`.cshtml.cs file`) for your Razor Page. Remember the basic code to place in a page model? Refer to `Index.cshtml.cs` or Lab 8. 
  - Don’t forget the change the class name to match the name of your Razor Page. 
  - Connect the Razor Page to the Page Model.  
- Create an empty `OnPost()` method. This method will be called when you hit Submit on your form. 
### Round 4: Add Logging and Verify HTTP Post 
- Remember Logging in Lab 9? Add code to enable logging in your page model. 
- Log an information message inside your `OnPost()` method that will print out “OnPost() Called”. 
- Filter out all the Microsoft logs like you did in Lab 9 so that only your log message is displayed. 
- Run your project, fill out the form, and hit submit. Verify that the log message is displayed to the console. 
- If the message is not displayed, it’s time to debug. Otherwise, great work! 
### Round 5: Finishing Up 
- Save all your code and submit your project to WTClass. **Due Date: 3/31 by 11:00 PM CDT**