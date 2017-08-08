﻿using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ngpvanapi.Models
{
    public class Signup
    {
        [JsonProperty("person")]
        public People Person;

        [JsonProperty("event")]
        public Event Event;

        [JsonProperty("status")]
        public Status Status;

        [JsonProperty("role")]
        public Role Role;

        [JsonProperty("shift")]
        public Shift Shift;

        [JsonProperty("location")]
        public Location Location;
    }

    public class SignupView
    {
        public int VanId;
        public List<SelectListItem> Events;
    }

    public class Status
    {
        [JsonProperty("statusId")]
        public int StatusId;

        [JsonProperty("name")]
        public string Name;
    }
}