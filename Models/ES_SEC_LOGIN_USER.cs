using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESOauth.Models
{
    // SE_SEC_LOGIN_USER model
    [Dapper.Contrib.Extensions.Table("ES_SEC_LOGIN_USER")]
    public partial class ES_SEC_LOGIN_USER
    {
        [Dapper.Contrib.Extensions.KeyAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Login User ID is required")]
        public long Login_User_Id { get; set; }
        public long Person_Id { get; set; }
        public int Role_Id { get; set; }
        public DateTime? Last_Access_Date { get; set; }
        public int? Login_Failure_Count { get; set; }

        public string User_Name { get; set; }

        public int? Login_Through_Enum { get; set; }

        public long? Log_Id { get; set; }

        public bool? Status_Enum { get; set; }

        public long? Created_By{get;set;}

        public DateTime? Created_Datetime { get; set; }

        public long? Modified_By { get; set; }

        public DateTime? Modified_Datetime { get; set; }

        public int? Lock_Id { get; set; }

        public short? System_Default_Enum { get; set; }
    }
}
