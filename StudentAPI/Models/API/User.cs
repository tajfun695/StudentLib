﻿using Newtonsoft.Json.Linq;
using System;
using Utilities;

namespace StudentAPI.Models.API
{
    public class User
    {
        //Variable
        private int _userID;
        private string _email;
        private string _name;
        private DateTime? _registerTime;
        private string _gender;
        private DateTime? _birthday;
        private string _photo;
        private string _cover;
        private string _lastName;
        private string _middleName;
        private string _firstName;

        //Property
        public int UserID
        {
            get { return _userID; }
            set
            {
                _userID = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public DateTime? RegisterTime
        {
            get { return _registerTime; }
            set
            {
                _registerTime = value;
            }
        }
        public string Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }
        }
        public DateTime? Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
            }
        }
        public string Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
            }
        }
        public string Cover
        {
            get { return _cover; }
            set
            {
                _cover = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
            }
        }

        //ctor
        public User(JToken json)
        {
            if (int.TryParse(json.SelectToken("userId")?.ToString(), out int userid)) UserID = userid;

            if (double.TryParse(json.SelectToken("userRegisterTime").ToString(), out double registerTime))
                RegisterTime = Libs.DataConverter.UnixTimeStampToDateTime(registerTime);
            else
                RegisterTime = null;

            if (double.TryParse(json.SelectToken("userBirthdayTime").ToString(), out double birthday))
                Birthday = Libs.DataConverter.UnixTimeStampToDateTime(birthday);
            else
                Birthday = null;


            Email = json.SelectToken("userEmailAddress")?.ToString();
            Name = json.SelectToken("userName")?.ToString();
            Gender = json.SelectToken("userGender")?.ToString();
            Photo = json.SelectToken("userPhoto")?.ToString();
            Cover = json.SelectToken("userCover")?.ToString();
            LastName = json.SelectToken("userLastName")?.ToString();
            MiddleName = json.SelectToken("userMiddleName")?.ToString();
            FirstName = json.SelectToken("userFirstName")?.ToString();
        }

        public override string ToString()
        {
            return $"NICKNAME: {Name}";
        }
    }
}