﻿using System;
using System.Data;

namespace AddressBookUsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book Using Linq!");

            //Creating DataTable for addressbook problem UC1
            DataTable addressBookTable = new DataTable();

            //adding columns into address book table UC2
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;

            //Creating rows and adding data into rows - UC3
            addressBookTable.Rows.Add("Kim", "Kardashian", "Street 1", "Lakers", "Los Angeles", 444556, 6785674567, "lb@gmail.com");
            addressBookTable.Rows.Add("Kylie", "Jenner", "Street 3", "Celtics", "Boston", 345267, 2345678987, "kylie@gmail.com");
            addressBookTable.Rows.Add("Kris", "Jenner", "Block 4", "Warriors", "Golden State", 987654, 3456787654, "kris@gmail.com");
            addressBookTable.Rows.Add("Khloe", "Lamar", "Street 5", "Rockets", "Houston", 234566, 6543456789, "khloe@gmail.com");
            addressBookTable.Rows.Add("Kourtney", "Scott", "Block 2", "Hornets ", "Charlotte ", 444556, 3456787654, "ks@gmail.com");

            //UC4
            //reference for address book management class
            //AddressBookManagement addressBookManagement = new AddressBookManagement();
            //addressBookTable = addressBookManagement.UpdatedContactDetails(addressBookTable);

            //Console.WriteLine("\n*******************DATA*****************\n");
            //foreach (var data in addressBookTable.AsEnumerable())
            //{
            //    Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
            //    Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
            //    Console.WriteLine("Address:- " + data.Field<string>("address"));
            //    Console.WriteLine("City:- " + data.Field<string>("city"));
            //    Console.WriteLine("State:- " + data.Field<string>("state"));
            //    Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
            //    Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
            //    Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
            //    Console.WriteLine("\n***************\n");
            //}

            // UC5
            //reference for address book management class
            //AddressBookManagement addressBookManagement1 = new AddressBookManagement();
            //deleting contacts from address book table UC5
            //addressBookTable = addressBookManagement1.DeletingContactFromTable(addressBookTable);

            //UC6
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            addressBookManagement.RetrievingContactDetailsByStateOrCity(addressBookTable);
        }
    }
}
