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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "List/{query}",ResponseFormat=WebMessageFormat.Json)]
        ArrayList doSelectOperation(string query);
       
        [OperationContract]
        [WebGet(UriTemplate = "ListShow/{tblName}",ResponseFormat=WebMessageFormat.Json)]
        List<TblBodyPart> doSelectOperationList(string tblName);

        [OperationContract]
        [WebGet(UriTemplate = "ListShowData/{tblName}", ResponseFormat = WebMessageFormat.Json)]
        string doSelect(string tblName);
        

        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate = "DML/{query}", ResponseFormat = WebMessageFormat.Json)]
        string doDMLOperation(string query);

        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate = "Registration/{add}/{city}/{contactno}/{dateofbirth}/{email}/{gender}/{name}/{pwd}/{qualification}", ResponseFormat = WebMessageFormat.Json)]
        string SaveReg(string add,string city,string contactno,string dateofbirth,string email,string gender,string name,string pwd,string qualification);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Update/{add}/{city}/{contactno}/{dateofbirth}/{email}/{gender}/{name}/{pwd}/{qualification}/{clientid}", ResponseFormat = WebMessageFormat.Json)]
        string UpdateReg(string add, string city, string contactno, string dateofbirth, string email, string gender, string name, string pwd, string qualification,string clientid);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Delete/{clientid}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteReg(string clientid);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   
}
