using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommonService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataAccess db = new DataAccess();
      

        public string doDMLOperation(string query)
        { 
            return db.doDMLOperation(query).ToString();
        }

       public string SaveReg(string add, string city, string contactno, string dateofbirth, string email, string gender, string name, string pwd, string qualification)
        {
            try
            {
                tblclientreg reg = new tblclientreg();
                reg.city = city;
                reg.caddress = add;
                reg.contactno = contactno;
                reg.dateofbirth = dateofbirth;
                reg.emailid = email;
                reg.gender = gender;
                reg.name = name;
                reg.pwd = pwd;
                reg.qualification = qualification;
                DataClasses1DataContext db = new DataClasses1DataContext();
                db.tblclientregs.InsertOnSubmit(reg);
                db.SubmitChanges();
                return "Success";
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }

      public string DeleteReg(string clientid)
       {
           try
           {

               DataClasses1DataContext db = new DataClasses1DataContext();
               List<tblclientreg> l = (from c in db.tblclientregs where c.clientid.Equals(clientid) select c).ToList<tblclientreg>();
               tblclientreg reg = l[0];
               db.tblclientregs.DeleteOnSubmit(reg);
               db.SubmitChanges();
               return "Success";
           }
           catch (Exception ex)
           {
               return "Error";
           }
       }
       public string UpdateReg(string add, string city, string contactno, string dateofbirth, string email, string gender, string name, string pwd, string qualification, string clientid)
       {
           try
           {
               DataClasses1DataContext db = new DataClasses1DataContext();
               List<tblclientreg> l = (from c in db.tblclientregs where c.clientid.Equals(clientid) select c).ToList<tblclientreg>();

               tblclientreg reg = l[0];
               reg.city = city;
               reg.caddress = add;
               reg.contactno = contactno;
               reg.dateofbirth = dateofbirth;
               reg.emailid = email;
               reg.gender = gender;
               reg.name = name;
               reg.pwd = pwd;
               reg.qualification = qualification;
               
               //db.tblclientregs.InsertOnSubmit(reg);
               db.SubmitChanges();
               return "Success";
           }
           catch (Exception ex)
           {
               return "Error";
           }
       }

       public ArrayList doSelectOperation(string query)
        {
           // DataTable 
            return db.doSelectOperation(query);
        }
        public string doSelect(string tblName)
        {
            return tblName;
        }
        public List<TblBodyPart> doSelectOperationList(string tblName)
        {
            DataClasses1DataContext db=new DataClasses1DataContext ();
            List<TblBodyPart> l = (from r in db.TblBodyParts select r).ToList<TblBodyPart>();
            
            return l;
           // DataTable dt=db.doSelectOperation("select * from "+tblName);
            //salesdata.RemotingFormat = SerializationFormat.Binary;         
           ///string xyz =GetJson(dt);
          // return xyz;
        }
        private string GetJson(DataTable dt)
        {
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new

            System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows =
              new List<Dictionary<string, object>>();
            Dictionary<string, object> row = null;

            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName.Trim(), dr[col]);
                }
                rows.Add(row);
            }
            
            return serializer.Serialize(rows);
        }
    }
}
