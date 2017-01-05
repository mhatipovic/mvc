using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Script.Serialization;
using System.Data;


namespace WebApiDemo
{
    public partial class jsonCsharp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            Response.Write(Server.MapPath(".") + "<br/>");
            Response.Write(Server.MapPath("~") + "<br/>");
            DataSet ds = new DataSet();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string myFile = Server.MapPath("~/App_Data/person.json");
            String jsonStr = File.ReadAllText(myFile);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(jsonStr);
            TextBox1.Text = p1.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string myFile = Server.MapPath("~/App_Data/person.json");
            Person p2 = new Person(); p2.name = "Bubba";p2.age = 21;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJson = ser.Serialize(p2);
           // File.AppendAllText(myFile, outputJson);
        }
    }

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0} \nAge: {1}",name,age);

        }
    }
}