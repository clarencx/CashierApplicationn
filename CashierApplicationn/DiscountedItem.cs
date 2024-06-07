﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplicationn
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;


        public DiscountedItem(string name, double price, int quantity, double discount)
          : base(name, price, quantity)
        {
            this.item_discount = discount * 0.01;
            this.discounted_price = 00.00;
            this.payment_amount = 00.00;
            this.change = 00.00;
        }
        public override double getTotalPrice()
        {
            discounted_price = item_price * (1 - item_discount);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public override void setPayment(double amount)
        {
            this.payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - total_price;
            return change;
        }
    }

}

