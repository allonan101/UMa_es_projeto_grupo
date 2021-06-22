﻿using MySql.Data.MySqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public class PersonService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public PersonService()
        {
            _conn = new MySqlConnection(_connectionString);
        }
        public void InsertPerson(Person person)
        {
            string sql = $"INSERT INTO person(name, age, address) VALUES ('{person.name}', {person.age}, '{person.address}')";
            this._conn.Execute(sql);
        }
    }
}