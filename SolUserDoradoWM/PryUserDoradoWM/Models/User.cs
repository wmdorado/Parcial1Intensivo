namespace PryUserDoradoWM.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class EmailAdress
    {
    }
    public enum SuiteType
    {
    }
    public class CityName
    {
    }

    public class Location
    {
    }

    public class Direction
    {
    }
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(100,ErrorMessage ="El nombre debe contener de 5 a 100 caracteres", MinimumLength =5)]
        public String Name { get; set; }
        public EmailAdress  Email { get; set; }
        public Direction Street { get; set; }
        [Range (1,1000,ErrorMessage ="Las habitaciones son entre 1 y 1000")]
        public SuiteType Suite { get; set; }
        public CityName City { get; set; }
        [Range (-90,90,ErrorMessage ="La latitud es entre -90 y 90")]
        [Range (-180,180,ErrorMessage ="La longitud es estre -180 y 180")]
        public double Geo { get; set; }
        public PhoneAttribute Phone { get; set; }

    }
}