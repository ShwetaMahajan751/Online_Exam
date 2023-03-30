namespace Online_Exam.Models
{
    public class otp_login
    {
        public long Log_Id { get; set; }

        public byte Intimation_Type_Enum { get; set; }

        public string User_Name { get; set; }

        public string? OTP { get; set; }

        public bool? Is_Valid { get; set; }

        public bool? Is_Verified { get; set; }

        public byte? Login_Through_Enum { get; set; }

        public DateTime? Verified_Datetime { get; set; }

        public long? Login_User_Id { get; set; }

        public bool? Is_Requested_Number_Change { get; set; }

        public long? Person_Id { get; set; }

        public bool? Status_Enum { get; set; }

        public long? Created_By { get; set; }

        public DateTime? Created_Datetime { get; set; }

        public long? Modified_By { get; set; }

        public DateTime? Modified_Datetime { get; set; }

        public int? Lock_Id { get; set; }
    }
}
