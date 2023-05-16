﻿using AkedemiPlusObserverPattern.DAL;
using System;

namespace AkedemiPlusObserverPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "SALE20",
                DiscountAmount = 20,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}