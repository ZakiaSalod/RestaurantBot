using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Bot.Builder.FormFlow;

namespace RestraurantBot.Models
{

    public enum PizzaSizeOptions
    {
        Regular,
        Medium,
        Large
    }

    public enum AmmenitiesOptions
    {
        Banquet,
        Pool,
        Garden,
        KidsZone
    }


    [Serializable]
    public class UserOrder
    {
        //during runtime, the Bot will ask questions, based on these properties here:
        public PizzaSizeOptions? PizzaSize;
        public int? Pizzas;
        public DateTime? DeliveryDate;
        public List<AmmenitiesOptions> Ammenities;

        public static IForm<UserOrder> BuildForm()
        {
            return new FormBuilder<UserOrder>()
                .Message("Welcome to the Restaurant bot!")
                .Build();
        }
    }
}