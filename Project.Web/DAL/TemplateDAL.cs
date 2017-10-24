using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Web.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Project.Web.DAL
{
    public class TemplateDAL : ITemplateDAL
    {
        private string aName = ConfigurationManager.ConnectionStrings["card"].ConnectionString;
        private string SQL_GetAllTemplates = "select * from card_templates;";
        private string SQL_GetATemplate = "Select * from card_templates where id = @productId;";
        private string SQL_GetRandomMeme = "Select * from random_card where random_id = @memeId;";

        public List<Templates> GetAllTemplates()
        {
            List<Templates> output = new List<Templates>();

            try
            {
                using(SqlConnection conn = new SqlConnection(aName))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllTemplates, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Templates t = new Templates();
                        t.Id = Convert.ToInt32(reader["id"]);
                        t.Name = Convert.ToString(reader["name"]);                       
                        t.ImageName = Convert.ToString(reader["imageName"]);
                        

                        output.Add(t);
                    }


                }
            }
            catch(SqlException)
            {
                throw;
            }

            return output;
        }

        public Templates GetATemplate(int id)
        {
            Templates output = new Templates();

            try
            {
                using (SqlConnection conn = new SqlConnection(aName))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetATemplate, conn);
                    cmd.Parameters.AddWithValue("@productId", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Templates t = new Templates();
                        t.Id = Convert.ToInt32(reader["id"]);
                        t.Name = Convert.ToString(reader["name"]);
                        t.ImageName = Convert.ToString(reader["imageName"]);
                        
                        return t;
                    }


                }
            }
            catch (SqlException)
            {
                throw;
            }

            return output;
        }

        public Card GetARandomMeme(int id)
        {
            Card output = new Card();

            try
            {
                using (SqlConnection conn = new SqlConnection(aName))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetRandomMeme, conn);
                    cmd.Parameters.AddWithValue("@memeId", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        output.TemplateId = Convert.ToInt32(reader["template_id"]);
                        output.MessageLineOne = Convert.ToString(reader["message_one"]);
                        output.MessageLineTwo = Convert.ToString(reader["message_two"]);
                    }


                }
            }
            catch (SqlException)
            {
                throw;
            }

            return output;
        }

    }
}