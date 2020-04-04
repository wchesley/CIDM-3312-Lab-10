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
-5 If the message is not displayed, it’s time to debug. Otherwise, great work! 
### Round 5: Finishing Up 
- Save all your code and submit your project to WTClass. **Due Date: 3/31 by 11:00 PM CDT**

# Lab 10 Part 2 – Model Binding 
### Round 0: Prepare Your Environment 
- Open Lab 10 Part 1 in Visual Studio Code.  
### Round 1: Model Binding Server-Side Part 
Model binding links data in the web page (frontend or client-side) to C# variables in your model (backend or server-side). Your goal is to connect the data that the user inputs in your form to your page model. 
- Your form has text boxes for First Name and Last Name. Create a `FirstName` property and a `LastName` property in your Page Model class (the `.cshtml.cs` file) 
- Add the `[BindProperty]` decorators to your properties. It is this line of code that sets up the model binding. Your code should look like this: 
``` csharp
[BindProperty]
public string FristName {get; set;}
```
### Round 2: Model Binding Client-Side Part 
- Open the Razor Page (the `.cshtml` file). Use tag helpers to link the `<label>` and `<input>` tags to your C# properties you created in Round 1. 
  - The tag helper you will use is `asp-for="PropertyName"`. PropertyName should match the exact name of the C# property  (e.g. `asp-for="FirstName"`). 
- Delete the text between the `<label>` opening and closing tags. The `asp-for` tag helper automates writing that text. 
- Run your project. Click view source in the web browser and see what the HTML code looks like now with the tag helpers. 
### Round 3: Verify 
- We added logging last time. Change the log message in `OnPost()` to print out the content of the `FirstName` and `LastName` properties. 
- Run your project again and confirm that those properties are being set correctly. 
### Round 4: Bring it Back Around 
- Add code to your Razor Page that will display the contents of the `FirstName` and `LastName` properties back on the webpage. Remember how to display C# variables in Razor Pages? 
- Run your project again and take a look. 
### Round 5: Data Annotations 
You may have noticed that the labels for your textboxes say “FirstName” and “LastName” now with no spaces. The `asp-for` tag helper pulls the exact variable name as the label name. Usually we don’t want that.  
- Add the following using directives to enable Data Annotations:
``` csharp  
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
```
- Add a Data Annotation to your properties on the page model right below `[BindProperty]: [Display(Name = "First Name")]` 
- Run your project again and take a look. 
### Round 6: Data Validation 
Data Validation requires two parts – data annotations on the server side that specify the validation rules and tag helpers on the client side to enforce the rules. 
- Open your razor page (`.cshtml` file) and add the following HTML after the `<input>` tag for each textbox. Change "FirstName" to match the proper variable name. `<span asp-validation-for="FirstName" class="text-danger"></span>` 
- Bring in the JS code to perform the validation. At the bottom of your razor page add the following: 
``` csharp
@section Scripts {     
  @{await Html.RenderPartialAsync("_ValidationScriptsPartial");} 
  }
```
- Add the `[Required]` and `[StringLength]` validation rules to your page model (the `.cshtml.cs` file). 
- Run your project and test it out. 
### Round 7: Data Validation Challenge 
Visit https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation for examples and other validation rules you can use. 
- On your form, add an input tag (text box) for a credit card number. 
- Review the previous rounds in this lab and write all the required code for the credit card number following the example for FirstName.  
- Give the credit card number the proper data validation rules. Follow the example from Round 6 but use credit card validation rules. 
- The website at https://www.paypalobjects.com/en_AU/vhelp/paypalmanager_help/credit_card_numbers.htm  has sample credit card numbers. Verify that your validation rules work properly. 
### Round 8: Finishing Up 
- Save and submit your project to WTClass.

# CIDM 3312 Homework 5 – Contact Us Form 
Create an ASP.NET Core application that has a Razor Page asking a user to enter their name, e-mail address, and a message. Once the user clicks Submit, confirm their submission. You DO NOT need to store the message in a database, there is no EF Core component yet. 
### Requirements: 
Create a Razor Page called `Contact.cshtml` and corresponding Page Model called `Contact.cshtml.cs` 
Match the layout of the Razor Page to the picture in Figure 1 below: 
- Use a <h1> tag with the text “Contact Us”. 
- Use a <form> tag that will perform an HTTP Post request. 
- Use the Bootstrap grid system to layout the page. 
- The <form> should be in a Bootstrap column of size 4. 
- The Message should use the `<textarea></textarea>` HTML tags. 
- Ensure that all HTML tags use the proper Bootstrap classes.  
- Add a link to your razor page in the navigation menu of the web site by adding the correct HTML code to `Pages\Shared\_Layout.cshtml`.  
Create the Page Model to read in the contents of the form when the user clicks Submit: 
- Use Model Binding to input the Name, E-Mail address, and Message. 
- Use logging to display the Name, E-Mail address, and Message to the console when the user clicks Submit. You should log at the LogWarning level. 
- Use the proper tag helpers on the `<label>` and `<input>` tags on the Razor Page. 
- Perform Data Validation: 
  - The Name field should be required. 
  - The E-Mail field should be required, display as “E-Mail”, and validated as an E-Mail address. 
  - The Message should be required and limited to maximum length of 200 characters. 
- Place the proper HTML tags, tag helpers, and code on the Razor Page to perform the validation and display errors as shown in Figure 2.  
When the user clicks Submit display a message at the bottom of the page saying “Thank you for your message {Name} ({Email}): {Message}” as shown in Figure 3. This message should NOT display until the user successfully clicks Submit.   
---
**Please remember to comment your code.**   
Homework is meant to be completed **INDIVIDUALLY**. Cheating or copying on a homework will result in a ZERO for the assignment and at the professor’s discretion, a zero for the entire course.   
**Homework 5 Due Date: Tuesday April 7, 2020 by 11:00 PM**