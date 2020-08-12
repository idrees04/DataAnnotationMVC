using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotationMVC.Models
{
    public class Employee
    {
        //       DATA ANNOTATIONS IN ASP.NET MVC
        //The MVC Framework provides several data annotations that you can apply as attributes to a model.
        //These data annotations implement tasks that are commonly required across applications.
        //      REQUIRED DATA ANNOTATION
        //The Required data annotation specifies that the property, with which this annotation is associated, is a required property.
        //This attribute raises a validation error if the property value is null or empty.
        //Following is the syntax of the Required data annotation:
        //      Syntex:
        //[Required]
        // string<property_name>
        // in one property we can add multyple annotation as we are goint to add on EmployeeId

//               DISPLAY NAME DATA ANNOTATION IN MVC
//         When you use the @Html.LabelFor() helper method in a strongly typed view, the method displays a label with a text whose value is the corresponding property name.
//         You can also explicitly state the text that the @Html.LabelFor() method should display using the DisplayName annotation on the model property.

        [DisplayName("ID")]
        [Required(ErrorMessage ="Id is mandatory")]
        public int EmployeeId { get; set; }
        //        STRING LENGTH DATA ANNOTATION IN MVC
        //•	You can use the StringLength annotation to specify the minimum and maximum lengths of a string field.
        //•	Whenever a user specified values for these fields are out of this specified range a validation error message is displayed
        //Following is the syntax for StringLength annotation:
        //[StringLength(<max_length>, MinimumLength= <min_length>)]
        //fowllowing line is for default errorMassage 
        //[StringLength(20,MinimumLength =5)]
        // now i want to show custom errormassage
        //

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name should be in beteen 5 and 20")]
        public string EmployeeName{ get; set; }

        //        RANGE DATA ANNOTATION IN MVC
        //You can use the Range annotation to specify the minimum and maximum constraints for a numeric value.
        //Following is the syntax of the Range annotation:
        //[Range(< minimum_range >, < maximum_range >)]
        //        where,
        //minimum_range: Is a numeric value that specifies the minimum value for the range.
        //maximum_range: Is a numeric value that specifies the maximum value for the range.
        // string lenght used for cherecters and
        //range used for numberc cheracters
        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is mandatory")]
        [Range(20,60,ErrorMessage ="Age should be in teh range of 20 and 60")]
        public int? EmployeeAge { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender is mandatory")]
        public string EmployeeGender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$",ErrorMessage ="Invalid Email")]
        public string EmployeeEmail { get; set; }

        //This Regular expression of password is minmum 8 chaeracter Required and  Capital and samal cheracter must be in this field
        //(@) sign is fot avoid escap sequence
        //        You can use the RegularExpression annotation to accept user input in a specific format.
        //This annotation allows you to match a text string with a search pattern that contains one or more character literals, operators, or constructs.
        //Following is the syntax for RegularExpression annotation:
        //[RegularExpression(< pattern >)]
        [DisplayName("Password")]
        [Required(ErrorMessage ="Employee Password is Mondatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage = "UpperCase, LowerCase,Numbers,Symbols,8 Characters")]
        public string EmployeePasswoerd { get; set; }

        //        COMPARE DATA ANNOTATION IN MVC
        //•	You can use the Compare annotation to compare values in two fields.
        //•	The Compare annotation ensures that the two properties on a model object have the same value.

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Employee Confirm Password is Mondatory")]
        [Compare("EmployeePasswoerd",ErrorMessage ="Password dose not match ")]
        public string EmployeeConfirmPasswoerd { get; set; }

    }
}