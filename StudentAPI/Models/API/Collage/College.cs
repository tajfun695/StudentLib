﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace StudentAPI.Models.API.Collage
{
    public class College : Utilities.ViewModelBase
    {
        //Variable
        private int _id { get; set; }
        private string _name { get; set; }
        private string _description { get; set; }
        private string _photo { get; set; }
        private string _cover { get; set; }
        private DateTime? _endDate { get; set; }
        private DateTime? _createDate { get; set; }

        //Property
        public int ID
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("ID"); }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }
        public string Cover
        {
            get { return _cover; }
            set { _cover = value; OnPropertyChanged("Cover");}
        }
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged("EndDate"); }
        }
        public DateTime? CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; OnPropertyChanged("CreateDate"); }
        }

        //Ctor
        public College(JToken json)
        {
            int id;
            double endDate, createDate;

            if (int.TryParse(json.SelectToken("id")?.ToString(), out id)) ID = id;
            if (double.TryParse(json.SelectToken("endDate")?.ToString(), out endDate))
                EndDate = Libs.DataConverter.UnixTimeStampToDateTime(endDate);
            else
                EndDate = null;
            if (double.TryParse(json.SelectToken("createDate")?.ToString(), out createDate))
                CreateDate = Libs.DataConverter.UnixTimeStampToDateTime(createDate);
            else
                EndDate = null;

            Name = json.SelectToken("name")?.ToString();
            Description = json.SelectToken("description")?.ToString();
            Photo = json.SelectToken("photo")?.ToString();
            Cover = json.SelectToken("cover")?.ToString();
        }

        public override string ToString()
        {
            return $"{ID}, {Name} || {CreateDate}";
        }
    }
}
