using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CommonService
{
   

    public class DataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public DataAccess()
        {
            con = new SqlConnection("Server=e42f408a-96b8-4160-8424-a3260098156c.sqlserver.sequelizer.com;Database=dbe42f408a96b841608424a3260098156c;User ID=bijothhtumkjiceq;Password=EPKXfxQKCq8gYRd4KqgcpvSFjGhnx2Pn5S7W2qYLKUeDsk3eyDTe8ixj5dNEpCmK;");
        }
        public int doDMLOperation(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                con.Close();
                return res;
            }
            catch (Exception ex)
            {
                return -1;
            }
            
        }
        public ArrayList doSelectOperation(string query)
        {
            ArrayList l = new ArrayList();
            dt = new DataTable();
            try
            {
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                
                adapter.Fill(dt);

                con.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    ArrayList o = new ArrayList();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {

                        o.Add(dr[i]);
                    }

                    l.Add(o);
                }

                return l;
            }
            catch (Exception ex)
            {
                return l;
            }
        }
    }
}