using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplications_Übung1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string   Item_name { get; set; }
        public int Preis { get; set; }
        public string Model { get; set; }
        public string Kategorie { get; set; }
        public string Marke { get; set; }
        public string Bildpfad { get; set; }

        public Item() : this(0, "", 0, "", "", "", "") { }
        public Item(int id, string item_name, int preis, string model, string kategorie, string marke, string bildpfad)
        {
            this.Id = id;
            this.Item_name = item_name;
            this.Preis = preis;
            this.Model = model;
            this.Kategorie = kategorie;
            this.Marke = marke;
            this.Bildpfad = bildpfad;
        }
    }
}