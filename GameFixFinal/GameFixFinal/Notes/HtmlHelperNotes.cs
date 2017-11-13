//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace GameFix.Notes
//{
//    public class HtmlHelperNotes
//    {
//    }
//}


/*
 * Html helpers are html encoded, meaning that they automatically protect against cross-site scripting attacks(XSS).
 * 
 * html.beginform() uses POST by default
 * ValidationSummary() displays an unordered list of all validation errrors in the ModelState Dictionary.
 * if ValidationSummary(true),  you are ecluding property-level errors and only displaying errors in ModelState associated with the model itself, and
 * excluding errors associated with a specific model property
 * 
 * annotation [ChildActionOnly] prevents the runtime from invoking the action directly with a URL, only a an Action or RenderAction can invoke a child action.

*there are a couple of different sets of html helpers that do the same thing.
 *one set uses string literals
 *another uses lambda expression(these have a "for" suffix on the end of function name).  to specify the model property for rendering. you jsut need to reference yoru model a the top, for example
 * @model GameFix.Models.DBname
*/