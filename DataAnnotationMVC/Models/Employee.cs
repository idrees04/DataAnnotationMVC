﻿using System;
using System.Collections.Generic;
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


        [Required(ErrorMessage = "Name is mandatory")]
        [StringLength(20,MinimumLength =5,ErrorMessage ="Name should be in beteen 5 and 20")]
        public string EmployeeName{ get; set; }
        [Required(ErrorMessage = "Age is mandatory")]
        public int? EmployeeAge { get; set; }
        [Required(ErrorMessage = "Gender is mandatory")]
        public string EmployeeGender { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]
        [RegularExpression("^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$",ErrorMessage ="Invalid Email")]
        public string EmployeeEmail { get; set; }

        //This Regular expression of password is minmum 8 chaeracter Required and  Capital and samal cheracter must be in this field
        //(@) sign is fot avoid escap sequence

        [Required(ErrorMessage ="Employee Password is Mondatory")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage = "UpperCase, LowerCase,Numbers,Symbols,8 Characters")]
        public string EmployeePasswoerd { get; set; }
    }
}