﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ServiceFUEN.Models.EFModels
{
    public partial class ShoppingCart
    {
        public int MemberId { get; set; }
        public int ProductId { get; set; }
        public int Number { get; set; }

        public virtual Member Member { get; set; }
        public virtual Product Product { get; set; }
    }
}