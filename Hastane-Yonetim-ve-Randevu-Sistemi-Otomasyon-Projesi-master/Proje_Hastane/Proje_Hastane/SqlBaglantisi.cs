﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti(){

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SFF93HI\\SQLEXPRESS\r\n;Initial Catalog=HastaneProje;Integrated Security=True");

            baglan.Open();
            return baglan;
        }
    }
}
