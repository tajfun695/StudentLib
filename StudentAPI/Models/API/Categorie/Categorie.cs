﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace StudentAPI.Models.API.Categorie
{
    public class Categorie
    {
        //Variable
        private int _id;
        private string _name;
        private List<string> _groupList = new List<string>();

        //Propety
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<string> GroupList
        {
            get { return _groupList; }
            set { _groupList = value; }
        }

        public Categorie(JObject json)
        {
            int id;
            
            if (int.TryParse(json.SelectToken("id").ToString(), out id)) ID = id;

            Name = json.SelectToken("name").ToString();
            GroupList = JsonConvert.DeserializeObject<List<string>>(json.SelectToken("dependencies").ToString());
        }

        private string MakeString()
        {
            string result = string.Empty;
            foreach(var item in GroupList)
            {
                result += $" {item}";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ID}, {Name}, Group: {MakeString()}";
        }
    }
}
