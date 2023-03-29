
using OnlineExam.Models;
using OnlineExam.ValidationLayer;
using System.Collections.Generic;

namespace OnlineExam.BusinessLayer
{
    public class Bal_User1
    {
      public bool IsAnyError { get; set; }
        public Dictionary<string, string> ErrorMessages { get; set; }

        internal List<ES_SETUP_ENUMERATOR> GetEnumerators()
        {
            List<ES_SETUP_ENUMERATOR> response = null;

            try
            {
                var validationLayer = new Val_User1();
                validationLayer.GetEnumerators();

                if (validationLayer.IsAnyError == false)
                {
                    var dataAccessLayer = new Dal_User1();
                    response = dataAccessLayer.GetEnumerators();

                    if (dataAccessLayer.IsAnyError == true)
                    {
                        this.IsAnyError = dataAccessLayer.IsAnyError;
                        this.ErrorMessages = dataAccessLayer.ErrorMessages;
                    }
                }
                else
                {
                    this.IsAnyError = validationLayer.IsAnyError;
                    this.ErrorMessages = validationLayer.ErrorMessages;
                }
            }
            catch
            {
                throw;
            }
            return response;
        }


        internal List<ES_OTP_LOG> User_Login(Save_OTP_Request_Model obj, string OTP)
        {
            List<ES_OTP_LOG> response = null;
            try
            {
                var validationLayer = new Val_User1();
                validationLayer.User_Login();

                if (validationLayer.IsAnyError == false)
                {
                    var dataAccessLayer = new DAL_User();
                    response = dataAccessLayer.User_Login(obj, OTP);

                    if (dataAccessLayer.IsAnyError == true)
                    {
                        this.IsAnyError = dataAccessLayer.IsAnyError;
                        this.ErrorMessages = dataAccessLayer.ErrorMessages;
                    }
                }
                else
                {
                    this.IsAnyError = validationLayer.IsAnyError;
                    this.ErrorMessages = validationLayer.ErrorMessages;
                }
            }
            catch
            {
                throw;
            }
            return response;

        }

        internal string Verify_Login(Verify_OTP obj)
        {
            List<ES_OTP_LOG> response = null;
            string data = null;
            try
            {
                var validationLayer = new Val_User1();
                validationLayer.Verify_Login();

                if (validationLayer.IsAnyError == false)
                {
                    var dataAccessLayer = new DAL_User();
                    data = dataAccessLayer.Verify_Login(obj);

                    if (dataAccessLayer.IsAnyError == true)
                    {
                        this.IsAnyError = dataAccessLayer.IsAnyError;
                        this.ErrorMessages = dataAccessLayer.ErrorMessages;
                    }
                }
                else
                {
                    this.IsAnyError = validationLayer.IsAnyError;
                    this.ErrorMessages = validationLayer.ErrorMessages;
                }
            }
            catch
            {
                throw;
            }
            return data;
        }

    }
}
