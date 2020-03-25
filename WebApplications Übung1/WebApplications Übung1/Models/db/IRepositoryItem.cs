﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplications_Übung1.Models.db
{
    interface IRepositoryItem
    {
        void Open();
        void Close();
        List<Item> GetAllItem();
        List<Item> GetItemsByCategory(int kategorie_id);
    }
}
