using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;


using MySql.Data.MySqlClient;

namespace WebApplications_Übung1.Models.db
{
    public class RepositoryItemDB : IRepositoryItem
    {
        private string _connectionString = "Server=localhost;Database=db_shop;Uid=root;Pwd=Sonic222;";
        private MySqlConnection _connection = null;
        public void Open()
        {
            if (this._connection == null)
            {
                this._connection = new MySqlConnection(this._connectionString);
            }
            if (this._connection.State != ConnectionState.Open)
            {
                this._connection.Open();
            }
        }

        public void Close()
        {
            if (this._connection != null && this._connection.State != ConnectionState.Closed)
            {
                this._connection.Close();
            }
        }

        public List<Item> GetAllItem()
        {
            List<Item> items = new List<Item>();

            DbCommand cmdSelect = this._connection.CreateCommand();
            cmdSelect.CommandText = "SELECT * FROM item";

            //ExecuteReader() wird immer bei Select-Abfragen benötigt
            //          mit ihm kann man sich zeilenweise durch das erhalten Ergebnis bewegen
            using (DbDataReader reader = cmdSelect.ExecuteReader())
            {
                //mit read() wird der nächste Datensatz (Item) gelesen
                while (reader.Read())
                {
                    items.Add(
                        new Item
                        {
                            //Id...so lautet das Feld in der Klasse User
                            //"id"...sol lautet der Spaltenname in der Datenbanktabelle users
                            Id = Convert.ToInt32(reader["id"]),
                            Item_name = Convert.ToString(reader["item_name"]),
                            Preis = Convert.ToInt32(reader["preis"]),
                            Model = Convert.ToString(reader["model"]),
                            Kategorie_ID = Convert.ToInt32(reader["kategorie_id"]),
                            Kategorie = Convert.ToString(reader["kategorie"]),
                            Marke = Convert.ToString(reader["marke"]),
                            Bildpfad = Convert.ToString(reader["bildpfad"])
                        });
                }
            }
            return items;
        }

        public List<Item> GetItemsByCategory(int kategorie_id)
        {
            List<Item> items = new List<Item>();

            DbCommand cmdGetKategorie = this._connection.CreateCommand();
            cmdGetKategorie.CommandText = "Select * From item Where kategorie_id=@ikategorie_id";

            DbParameter paramKategorie = cmdGetKategorie.CreateParameter();
            paramKategorie.ParameterName = "ikategorie_id";
            paramKategorie.Value = kategorie_id;
            paramKategorie.DbType = DbType.Int32;

            cmdGetKategorie.Parameters.Add(paramKategorie);

            using(DbDataReader reader = cmdGetKategorie.ExecuteReader())
            {
                if (!reader.HasRows) { return null; }
                while (reader.Read())
                {
                    items.Add( new Item
                    {
                        Item_name = Convert.ToString(reader["item_name"]),
                        Preis = Convert.ToInt32(reader["preis"]),
                        Model = Convert.ToString(reader["model"]),
                        Kategorie = Convert.ToString(reader["kategorie"]),
                        Marke = Convert.ToString(reader["marke"]),
                        Bildpfad = Convert.ToString(reader["bildpfad"])
                    });
                }
                
            }
            return items;
        }
    }
}