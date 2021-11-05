using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace PRG252_Project_Joshua_Simanga_Mieke
{
    class Data_Handler
    {

		public Data_Handler() { }

		string connect = "Data Source=.; Initial Catalog=StudentDB; Integrated Security = SSPI";
		SqlConnection sqlConnect;
		SqlDataAdapter adapt;
		SqlCommand cmd;
		DataTable dt;


		Student objStudent = new Student();

	

		public void SearchData(string search)
		{

			sqlConnect.Open();
			string query = "select * from tblStudent where stdNumber like '%' + search + '%' or stdName like '%' + search + '%' or stdSurname like '%' + search + '%'";
			adapt = new SqlDataAdapter(query, sqlConnect);
			dt = new DataTable();
			adapt.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnect.Close();
		}

		private void txtSearchBox_TextChanged(object sender, EventArgs e)
		{
			try
			{

				SearchData(txtStdNumber.Text);
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error!!!" + ex.Message);

			}

		}


		private void ClearData()
		{

			int ID = 0;
			txtStdNumber.Text = "";
			txt_StdName.Text = "";
			txt_StdSurname.Text = "";
			txt_StdImg.Text = "";
			txt_dob.Text = "";
			txt_gender.Text = "";
			txt_phone.Text = "";
			txt_address.Text = "";
			txt_ModuleCodes.Text = "";
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0], Value.ToString());
			txt_StdNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_StdName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txt_StdSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txt_StdImg.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txt_dob.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txt_gender.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			txt_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			txt_address.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			txt_ModuleCodes.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

		}

		private void DisplayData()
		{
			try
			{
				sqlConnect.Open();
				dt = new DataTable();
				adapt = new SqlDataAdapter("select * from tblStudent", sqlConnect);
				adapt.Fill(dt);
				dataGridView1.DataSource = dt;
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error!!!" + ex.Message);

			}

			finally
			{
				sqlConnect.Close();
			}

		}


		private void DeleteStudent()
		{
			try
			{
				if (StdNumber != 0)
				{
					string query = @"DELETE FROM tblStudent WHERE  = (" + stdNumber ")";
					sqlConnect = new SqlConnection(connect);
					sqlConnect.Open();
					cmd = new SqlCommand(query, sqlConnect);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Deleted the details of student with student number :{0}, Successfully", stdNumber);
					DisplayData();
					ClearData();
				}
				else
				{
					MessageBox.Show("Please Select Record To Delete!");
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error!!!" + ex.Message);
			}

			finally
			{
				sqlConnect.Close();
			}
		}




		private void Insert()
		{
			try
			{
				if (text_stdNumber.Text != "")
				{

					cmd = new SqlCommand("insert into tblStudent(stdNumber,stdName,stdSurname,stdImg,DOB,gender,phone,address,ModuleCode_FK) values(@stdNumber,@stdName,@stdSurname,@stdImg,@dob,@gender,@phone,@address,@modulecode_FK)", sqlConnect);
					sqlConnect.Open();
					cmd.Parameters.AddWithValue("@stdNumber", txt_stdNumber.Text);
					cmd.Parameters.AddWithValue("@stdName", txt_stdName.Text);
					cmd.Parameters.AddWithValue("@stdSurname", txt_stdSurname.Text);
					cmd.Parameters.AddWithValue("@stdImg", txt_stdImage.Text);
					cmd.Parameters.AddWithValue("@std@dob", txt_dob.Text);
					cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
					cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
					cmd.Parameters.AddWithValue("@address", txt_address.Text);
					cmd.Parameters.AddWithValue("@modulecode_FK", txt_moduleCodes.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Record Inserted Successfully");
					DisplayData();
					ClearData();
				}
				else
				{
					MessageBox.Show("Please Provide Student Details!");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Details could not be saved, Please Contact Support Team!");

			}
			finally
			{
				sqlConnect.Close();
			}
		}

		private void Update()
		{
			try
			{
				if (text_stdNumber.Text != "")
				{

					cmd = new SqlCommand("update into tblStudent set stdNumber=@stdName, stdName=@stdName,stdSurname=@stdSurname,stdImage=@stdImg,DOB@=dob,gender=@gender,phone=@phone,address=@phone,ModuleCode_FK=@modulecodes) values(@stdNumber,@stdName,@stdSurname,@stdImg,@dob,@gender,@phone,@address,@modulecode_FK)", sqlConnect);
					sqlConnect.Open();
					cmd.Parameters.AddWithValue("@stdNumber", txt_stdNumber.Text);
					cmd.Parameters.AddWithValue("@stdName", txt_stdName.Text);
					cmd.Parameters.AddWithValue("@stdSurname", txt_stdSurname.Text);
					cmd.Parameters.AddWithValue("@stdImg", txt_stdImage.Text);
					cmd.Parameters.AddWithValue("@std@dob", txt_dob.Text);
					cmd.Parameters.AddWithValue("@gender", txt_gender.Text);
					cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
					cmd.Parameters.AddWithValue("@address", txt_address.Text);
					cmd.Parameters.AddWithValue("@modulecode_FK", txt_moduleCodes.Text);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Record Updated Successfully!");
					DisplayData();
					ClearData();
				}
				else
				{
					MessageBox.Show("Please Select Record To Update!");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Details could not be saved, Please Contact Support Team!");

			}
			finally
			{
				sqlConnect.Close();
			}
		}
	}
}
