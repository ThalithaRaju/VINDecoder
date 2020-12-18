using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VINDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=LAPTOP-Q2N7MAED\SQLEXPRESS;Database=VehicleDB;Trusted_Connection=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Name] FROM [dbo].[Manufacture]", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmboxManufacture.Items.Add(dr["Name"]).ToString();
            }
            dr.Close();


            SqlCommand cmd1 = new SqlCommand("SELECT [Year] FROM [dbo].[ManufactureYear]", con);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cmboxYear.Items.Add(dr1["Year"]).ToString();
            }
            dr1.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT [Name] FROM [dbo].[VehicleType]", con);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmboxVehicleType.Items.Add(dr2["Name"]).ToString();
            }
            dr2.Close();

            SqlCommand cmd3 = new SqlCommand("SELECT [Place] FROM [dbo].[Place]", con);
            cmd3.CommandType = CommandType.Text;
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmboxPlant.Items.Add(dr3["Place"]).ToString();
            }
            dr3.Close();

        }

        private void txtEngineNumber_MouseLeave(object sender, EventArgs e)
        {
        }
        private void txtEngineNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            #region EngineSave
            SqlConnection con = new SqlConnection(@"Server=LAPTOP-Q2N7MAED\SQLEXPRESS;Database=VehicleDB;Trusted_Connection=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("EngineInsert", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@EngineNo", txtEngineNumber.Text);
            cmd1.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd1.ExecuteNonQuery();
            string id = cmd1.Parameters["@Id"].Value.ToString();
            #endregion

            #region LinkTable Save
            SqlCommand cmd = new SqlCommand("LinkSave", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MId", cmboxManufacture.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@YId", cmboxYear.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("VId", cmboxVehicleType.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@EId", id);
            cmd.Parameters.AddWithValue("@PId", cmboxPlant.SelectedIndex + 1);
            cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            string id1 = cmd1.Parameters["@Id"].Value.ToString();
            #endregion

            #region stringGeneration
            SqlCommand cmd3 = new SqlCommand("GetString", con);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@Id", id1);
            SqlDataReader dr = cmd3.ExecuteReader();
            while (dr.Read())
            {
                lblGetString.Text= dr["Manufacure"].ToString() + dr["Year"].ToString() + dr["VehicleType"].ToString()+dr["EngineNumber"].ToString()+dr["Place"].ToString();

            }
            dr.Close(); 
            #endregion

        }

    }
}
