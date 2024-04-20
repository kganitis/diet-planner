﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlanner.View
{
    internal class FoodCategory : DietaryEntity
    {
        private FoodCategory parentCategory = null;
        private List<FoodCategory> subCategories = new List<FoodCategory>();

        public FoodCategory() { }

        public FoodCategory(string id, string name)
        {
            ID = id;
            Name = name;
        }

        public FoodCategory(string id, string name, FoodCategory parentCategory, List<FoodCategory> subCategories)
        {
            ID = id;
            Name = name;
            ParentCategory = parentCategory;
            SubCategories = subCategories;
        }

        internal FoodCategory ParentCategory { get => parentCategory; set => parentCategory = value; }
        internal List<FoodCategory> SubCategories { get => subCategories; set => subCategories = value; }
    }
}
