using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TURK_SQL
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=AUTO-TAHIR\\NETX_SERVER_SQL;Initial Catalog=Test;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_insert_Click(object sender, EventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(textBox_ksq1.Text)) || (string.IsNullOrWhiteSpace(textBox_ksq2.Text)) || (string.IsNullOrWhiteSpace(textBox_name.Text)) || (string.IsNullOrWhiteSpace(textBox_surname.Text)))   //if one of the texbox or both of them is empty then get a message,return cycle
            {

                MessageBox.Show("Melumatlari daxil edin");


                return;

            }



            if (!(string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq2.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && (string.IsNullOrWhiteSpace(textBox_bksq.Text))) // if is textboxes is not empty then execute and insert data

            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    //variables a - ksq1 input , b - ksq2 input , c - math logic (a+b/2),z - point of the student usually have the same values(2,3,4,5) 

                    float a = float.Parse(textBox_ksq1.Text);
                    float b = float.Parse(textBox_ksq2.Text);
                    int z = 0;


                    if (a >= 101 || b >= 101)
                    {
                        MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                        return;
                    }
                    float c = (a + b) / 2;
                    c = (float)System.Math.Round(c, 3);
                    if (c <= 30)
                    {
                        z = 2;

                    }
                    if (c >= 30.5 && c <= 60)
                    {
                        z = 3;

                    }
                    if (c >= 60.5 && c <= 80)
                    {
                        z = 4;

                    }
                    if (c >= 80.5 && c <= 100)
                    {
                        z = 5;

                    }
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO School(name,surname,estimate,ksq1,ksq2,BAL) Values('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + c + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listeleme();
                    MessageBox.Show("INSERT SUCCESUFULL");

                    return;
                }
            }
            //FOR BKSQ CHECKING 2 point



            else if (baglanti.State == ConnectionState.Closed && !(string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq2.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && !(string.IsNullOrWhiteSpace(textBox_bksq.Text))) //if bksq is not null
            {
                //variables a - ksq1 input , b - ksq2 input , c - math logic (a+b/2)*0.4,res - sum of math logic (c + (bksq*0.6),z - point of the student usually have the same values(2,3,4,5) 
                float a = float.Parse(textBox_ksq1.Text);
                float b = float.Parse(textBox_ksq2.Text);
                int z = 0;
                if (a >= 101 || b >= 101)
                {
                    MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                    return;
                }
                float c = ((a + b) / 2) * 0.4f; // ortalama vurulsun 0.4
                float res = c + (float.Parse(textBox_bksq.Text) * 0.6f); // bksq + c ortalama ve netice bal
                c = (float)System.Math.Round(c, 3);
                if (res <= 30)
                {
                    z = 2;

                }
                if (res >= 30.5 && res <= 60)
                {
                    z = 3;

                }
                if (res >= 60.5 && res <= 80)
                {
                    z = 4;

                }
                if (res >= 80.5 && res <= 100)
                {
                    z = 5;

                }
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO School(name,surname,estimate,ksq1,ksq2,BAL,BKSQ) Values('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + res + "','" + float.Parse(textBox_bksq.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("INSERT SUCCESUFULL");
                return;

            }





            //END OF THE 2 POINT + BSQK 




            //IF 3 ELEMENTS + BSQK with 3 elements code beging


            // begin for 3 ksq code


            else if ((string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq2.Text)) || (string.IsNullOrWhiteSpace(textBox_ksq3.Text)))

            {

                MessageBox.Show("KSQ-leri daxil edin ");


                return;

            }

            if (!(string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && (string.IsNullOrWhiteSpace(textBox_bksq.Text))) // if is textboxes is not empty then execute and insert data
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    //variables a - ksq1 input , b - ksq2 input , c - ksq3 input,d - math logic(a+b+c)/3 , z - point of the student usually have the same values(2,3,4,5) 
                    float a = float.Parse(textBox_ksq1.Text);
                    float b = float.Parse(textBox_ksq2.Text);
                    float c = float.Parse(textBox_ksq3.Text);
                    int z = 0;

                    if (c >= 101)
                    {
                        MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                        return;
                    }

                    float d = (a + b + c) / 3;
                    d = (float)System.Math.Round(d, 3);
                    if (d <= 30)
                    {
                        z = 2;

                    }
                    if (d >= 30.5 && d <= 60)
                    {
                        z = 3;

                    }
                    if (d >= 60.5 && d <= 80)
                    {
                        z = 4;

                    }
                    if (d >= 80.5 && d <= 100)
                    {
                        z = 5;

                    }


                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO School (name,surname,estimate,ksq1,ksq2,ksq3,BAL) Values ('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + float.Parse(textBox_ksq3.Text) + "','" + d + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listeleme();
                    MessageBox.Show("Inserted ");
                    return;
                }
            }
            //BSQK 3 point chechking

            else if (baglanti.State == ConnectionState.Closed && !(string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq2.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && !(string.IsNullOrWhiteSpace(textBox_bksq.Text))) //if bksq is not null
            {
                //variables a - ksq1 input , b - ksq2 input , c - math logic (a+b/2)*0.4,res - sum of math logic (c + (bksq*0.6),z - point of the student usually have the same values(2,3,4,5) 
                float a = float.Parse(textBox_ksq1.Text);
                float b = float.Parse(textBox_ksq2.Text);
                float c = float.Parse(textBox_ksq3.Text);
                int z = 0;
                if (a >= 101 || b >= 101 || c >= 101)
                {
                    MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                    return;
                }
                float d = ((a + b + c) / 3) * 0.4f; // ortalama vurulsun 0.4
                float res = d + (float.Parse(textBox_bksq.Text) * 0.6f); // bksq + c ortalama ve netice bal
                res = (float)System.Math.Round(res, 3);
                if (res <= 30)
                {
                    z = 2;

                }
                if (res >= 30.5 && res <= 60)
                {
                    z = 3;

                }
                if (res >= 60.5 && res <= 80)
                {
                    z = 4;

                }
                if (res >= 80.5 && res <= 100)
                {
                    z = 5;

                }
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO School(name,surname,estimate,ksq1,ksq2,ksq3,BAL,BKSQ) Values('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + float.Parse(textBox_ksq3.Text) + "','" + res + "','" + float.Parse(textBox_bksq.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("INSERT SUCCESUFULL");
                return;

            }





            //END OF THE 3 points in exam
            // begin coding for 4 ksq 
            else if ((string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && (string.IsNullOrWhiteSpace(textBox_ksq2.Text)) || (string.IsNullOrWhiteSpace(textBox_ksq3.Text)) || (string.IsNullOrWhiteSpace(textBox_ksq4.Text)))

            {

                MessageBox.Show("KSQ-leri daxil edin ");


                return;

            }

            else if (!(string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && (string.IsNullOrWhiteSpace(textBox_bksq.Text))) // if is textboxes is not empty then execute and insert data
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    //variables a - ksq1 input , b - ksq2 input , c - ksq3 input,d - math logic(a+b+c)/3 , z - point of the student usually have the same values(2,3,4,5) 
                    float a = float.Parse(textBox_ksq1.Text);
                    float b = float.Parse(textBox_ksq2.Text);
                    float c = float.Parse(textBox_ksq3.Text);
                    float d = float.Parse(textBox_ksq4.Text);
                    int z = 0;

                    if (d >= 101)
                    {
                        MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                        return;
                    }

                    float t = (a + b + c + d) / 4;
                    t = (float)System.Math.Round(t, 3);
                    if (t <= 30)
                    {
                        z = 2;

                    }
                    if (t >= 30.5 && t <= 60)
                    {
                        z = 3;

                    }
                    if (t >= 60.5 && t <= 80)
                    {
                        z = 4;

                    }
                    if (t >= 80.5 && t <= 100)
                    {
                        z = 5;

                    }


                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "INSERT INTO School (name,surname,estimate,ksq1,ksq2,ksq3,ksq4,BAL) Values ('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + float.Parse(textBox_ksq3.Text) + "','" + float.Parse(textBox_ksq4.Text) + "','" + t + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listeleme();
                    MessageBox.Show("Insert");
                    return;

                }
                //bksq 4 code




                //if bksq is not null

                //variables a - ksq1 input , b - ksq2 input , c - math logic (a+b/2)*0.4,res - sum of math logic (c + (bksq*0.6),z - point of the student usually have the same values(2,3,4,5) 



                // end of bksq 4 code
            }
            // bksq + 4 values begin
            else if (baglanti.State == ConnectionState.Closed && !(string.IsNullOrWhiteSpace(textBox_ksq1.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq2.Text)) &&
                         !(string.IsNullOrWhiteSpace(textBox_ksq3.Text)) && !(string.IsNullOrWhiteSpace(textBox_ksq4.Text)) && !(string.IsNullOrWhiteSpace(textBox_bksq.Text)))
            {


                float a = float.Parse(textBox_ksq1.Text);
                float b = float.Parse(textBox_ksq2.Text);
                float c = float.Parse(textBox_ksq3.Text);
                float d = float.Parse(textBox_ksq4.Text);
                int z = 0;
                if (a >= 101 || b >= 101 || c >= 101 || d >= 100 || float.Parse(textBox_bksq.Text) >= 100)
                {
                    MessageBox.Show("Daxil edilen reqem 100 den coxdur");
                    return;
                }





                float res = ((a + b + c + d) / 4) * 0.4f;
                float l = (float.Parse(textBox_bksq.Text) * 0.6f);
                // ortalama vurulsun 0.4
                float res1 = res + l; // bksq + c ortalama ve netice bal
                res1 = (float)System.Math.Round(res1, 3);
                if (res1 <= 30)
                {
                    z = 2;

                }
                if (res1 >= 30.5 && res1 <= 60)
                {
                    z = 3;

                }
                if (res1 >= 60.5 && res1 <= 80)
                {
                    z = 4;

                }
                if (res1 >= 80.5 && res1 <= 100)
                {
                    z = 5;

                }
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO School (name,surname,estimate,ksq1,ksq2,ksq3,ksq4,BAL,BKSQ) Values ('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + z + "','" + float.Parse(textBox_ksq1.Text) + "','" + float.Parse(textBox_ksq2.Text) + "','" + float.Parse(textBox_ksq3.Text) + "','" + float.Parse(textBox_ksq4.Text) + "','" + res1 + "','" + float.Parse(textBox_bksq.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("INSERT SUCCESUFULL");
                return;
            }
            // end of the bksq + 4 values


        }












        //end of the 4 ksq 

        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;

                cmd.CommandText = "select * from School";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "School");
                dataGridView1.DataSource = ds.Tables["School"];
                dataGridView1.Columns[0].Visible = false;
                baglanti.Close();

            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter2.Fill(this.testDataSet.School);
            // TODO: This line of code loads data into the 'testDataSet3.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter1.Fill(this.testDataSet3.School);
            // TODO: This line of code loads data into the 'testDataSet1.School' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.testDataSet1.School);

        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT COUNT(*) FROM School";
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    cmd.CommandText = "delete from school where id = @numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();

                    listeleme();
                }


                if (count == 0)
                {
                    MessageBox.Show("Table is empty");
                    baglanti.Close(); // return to begin
                    return;

                }


            }


        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT COUNT(*) FROM School";
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {

                    cmd.CommandText = "update school set name ='" + textBox_name.Text + "',surname ='" + textBox_surname.Text + "',ksq1 = '" + textBox_ksq1.Text + "',ksq2='" + textBox_ksq2.Text + "',ksq3='" + textBox_ksq3.Text + "',ksq4='" + textBox_ksq4 + "',bksq='" + textBox_bksq.Text + "' where id =@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    listeleme();
                    MessageBox.Show("UPDATE SUCCESSFUL");
                }
                if (count == 0)
                {
                    MessageBox.Show("Table is Empty");
                    baglanti.Close(); // return to begin
                    return;
                }
            }
        }

        private void TextBox_ksq1_KeyPress(object sender, KeyPressEventArgs e) // insert only numbers && number length 3
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox_ksq1.MaxLength = 3;
        }

        private void TextBox_ksq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox_ksq2.MaxLength = 3;
        }

        private void TextBox_ksq3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox_ksq3.MaxLength = 3;
        }

        private void TextBox_ksq4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox_ksq4.MaxLength = 3;
        }

        private void TextBox_bksq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            textBox_bksq.MaxLength = 3;
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_surname.Clear();
            textBox_ksq1.Clear();
            textBox_ksq2.Clear();
            textBox_ksq3.Clear();
            textBox_ksq4.Clear();
            textBox_bksq.Clear();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
