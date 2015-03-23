using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IBFree.Models
{
    public enum Symptom
    {
        Bloating, Distention, Constipation, Diarrhoea, Flatulance, Other
    }
    public class UserInput
    {
        public String FoodName { get; set; }
        public Symptom Symptoms { get; set; }

    }
}