﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace StudentAPI.Models.API.PostComent
{
    public class Post : Utilities.ViewModelBase
    {
        private int _id;
        private string _content;
        private int _userid;
        private DateTime? _createDate;
        private DateTime? _modifyDate;
        public List<Comment> _comments;

        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }
        public int UserID
        {
            get { return _userid; }
            set { _userid = value; OnPropertyChanged("UserID"); }
        }
        public DateTime? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreateDate"); }
        }
        public DateTime? ModifyDate
        {
            get { return _modifyDate; }
            set { _modifyDate = value; OnPropertyChanged("ModifyDate"); }
        }
        public List<Comment> Comments
        {
            get { return _comments; }
            set { _comments = value; OnPropertyChanged("Comments"); }
        }

        public Post(JToken json)
        {
            int id, userid;
            double createDate, modifyDate;
            Comments = new List<Comment>();

            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;
            if (int.TryParse(json.SelectToken("userID").ToString(), out userid)) UserID = userid;

            if (double.TryParse(json.SelectToken("createDate").ToString(), out createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                CreateDate = null;

            if (double.TryParse(json.SelectToken("modifyDate").ToString(), out modifyDate))
                ModifyDate = Libs.DataConverter.UnixTimeStampToDateTime(modifyDate);
            else
                ModifyDate = null;

            Content = json.SelectToken("content").ToString();
            if (json.SelectToken("lastComments") != null)
                foreach (var item in json.SelectToken("lastComments"))
                    Comments.Add(new Comment(item));
        }

        public override string ToString()
        {
            string data =  $"{ID}, {Content} {UserID} {CreateDate} ||";
            if (Comments != null)
                foreach (var item in Comments)
                    data += $"{item.ToString()}";
            return data;
        }
    }
}
