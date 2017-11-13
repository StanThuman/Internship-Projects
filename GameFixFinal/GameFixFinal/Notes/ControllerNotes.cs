//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace GameFix.Notes
//{
//    public class ControllerNotes
//    {
//    }
//}
/*
 * model state is a byproduct of model binding. For every value the model binder moves into a model, it records an entry in model state.
 * you can check model state any time after model binding occurs to see whether model binding succeeded. even if the user information input is invalid, the model state is still recorded.
 * 
 * 
 * action parameter(id) is automotic
 * 
 * 
 * 
 * .net mvc framework executes validation logic during model binding. The model binder run implicitly when you ahve parameters to an action method
 * you can explicitly request model binding using UpdateModel() and TryUpdateModel() methods in a controller.
 * after the model binder is finished updating, the model properties, the model binder uses current model metadata and obtains all teh validators for
 * the model. THe MVC runtime provides a validator to work with data annotations. It finds all the validations attributes and catches the failed ones and places them inside ModelState
 *
 * you can implement your own validation 1 of 2 ways:
 * You can make your own annotations by sublclassing ValidationAttribute and overriding the IsValid Method
 * Or you can sublass IValidatableObject
 * 
 * use [Authorize] to only allow logged in users in your controller action
 * //it executes before the associated controller action
 * //if authorization fails, it prduces a 401 status code(unathuthorized request)
 * //In a default mvc application, mvc uses cookie-based authentication with individual user accoutns
 * //mvc handles the reponse conversion from 401 to a 302 redirect to login.
 * 
*/