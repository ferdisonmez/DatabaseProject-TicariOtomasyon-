﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-FIRC3VJ\SQLEXPRESS;Initial Catalog=Ticari Otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}