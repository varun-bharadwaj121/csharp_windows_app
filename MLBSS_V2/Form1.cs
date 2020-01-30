using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace MLBSS_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (textBoxDate.Text == "" || textBoxTime.Text == "" || textBoxTime.Text == "" || mfd_manu.Text == "" || mfd_mat.Text == "" || mfd_focus.Text == "" ||
                mfd_id_tb.Text == "" ||
                 fld_sample.Text == "" || fld_samp_source.Text == "" || fld_samp_conc.Text == "" || fld_samp_stain.Text == "" || fld_stain_conc.Text == "" ||
                 fld_sheath1.Text == "" ||
                fld_sheath2.Text == "" || fld_samp_flow_rate.Text == "" || fld_sheath1_flow_rate.Text == "" || fld_sheath2_flowrate.Text == "" || las_exci_laser.Text == "" ||
                las_las_pow.Text == "" ||
                las_exci_mode.Text == "" || las_abli_las.Text == "" || las_abli_pow.Text == "" || aq_sensor1.Text == "" || aq_sensor2.Text == "" || aq_det_mode1.Text == "" ||
                 aq_det_pos1.Text == "" || aq_det_mode2.Text == "" || aq_det_pos2.Text == "" || aq_sensor_gain1.Text == "" || aq_sensor_gain2.Text == "" ||
                 aq_filt_sensor1.Text == "" || aq_filt_sensor2.Text == "" ||
                 ele_data_aq.Text == "" || ele_samp_time.Text == "" || ele_data_aq_time.Text == "")
            {

                MessageBox.Show("There are empty fields!!");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = @"C:\";
                sfd.RestoreDirectory = true;
                sfd.FileName = "*txt";
                sfd.DefaultExt = "txt";
                sfd.Filter = "txt files (*.txt) | *.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream filestream = sfd.OpenFile();
                    StreamWriter sw = new StreamWriter(filestream);


                    sw.WriteLine("-----------------------------Experiment details-------------------------");
                    sw.WriteLine(labelID.Text + " : " + textBoxID.Text);
                    sw.WriteLine(labelDate.Text + " : " + textBoxDate.Text);
                    sw.WriteLine(labelTime.Text + " : " + textBoxTime.Text);
                    sw.WriteLine("------------------------------------------------------------------------");


                    sw.WriteLine("-----------------------------MFD----------------------------------------");
                    sw.WriteLine(label_mfd_manu.Text + " : " + mfd_manu.Text);
                    sw.WriteLine(label_mfd_mat.Text + " : " + mfd_mat.Text);
                    sw.WriteLine(label_mfd_focus.Text + " : " + mfd_focus.Text);
                    sw.WriteLine(label_mfd_id.Text + " : " + mfd_id_tb.Text);



                    sw.WriteLine("---------------------------Fluidics-------------------------------------");
                    sw.WriteLine(label_sample.Text + " : " + fld_sample.Text);
                    sw.WriteLine(label_samp_source.Text + " : " + fld_samp_source.Text);
                    sw.WriteLine(label_samp_con.Text + " : " + fld_samp_conc.Text);
                    sw.WriteLine(label_samp_stain.Text + " : " + fld_samp_stain.Text);
                    sw.WriteLine(label_stain_conc.Text + " : " + fld_stain_conc.Text);
                    sw.WriteLine(label_sheath1.Text + " : " + fld_sheath1.Text);
                    sw.WriteLine(label_sheath2.Text + " : " + fld_sheath2.Text);
                    sw.WriteLine(label_samp_flow_rate.Text + " : " + fld_samp_flow_rate.Text);
                    sw.WriteLine(labe_sheath1_flow_rate.Text + " : " + fld_sheath1_flow_rate.Text);
                    sw.WriteLine(label_sheath2_flowrate.Text + " : " + fld_sheath2_flowrate.Text);
                    sw.WriteLine(label_samp_dispn.Text + " : " + fld_samp_dispn.Text);
                    sw.WriteLine(label_sheath1_dispn.Text + " : " + fld_sheath1_dispn.Text);
                    sw.WriteLine(label_sheath2_dispn.Text + " : " + fld_sheath2_dispn.Text);


                    sw.WriteLine("-----------------------------Laser---------------------------------------");
                    sw.WriteLine(label_exci_las.Text + " : " + las_exci_laser.Text);
                    sw.WriteLine(label_las_pow.Text + " : " + las_las_pow.Text);
                    sw.WriteLine(label_exci_mode.Text + " : " + las_exci_mode.Text);
                    sw.WriteLine(label_exci_pos.Text + " : " + las_exci_pos.Text);
                    sw.WriteLine(label_abli_las.Text + " : " + las_abli_las.Text);
                    sw.WriteLine(label_abli_pow.Text + " : " + las_abli_pow);


                    sw.WriteLine("-----------------------------Acquisition----------------------------------");
                    sw.WriteLine(label_aq_sensor1.Text + " : " + aq_sensor1.Text);
                    sw.WriteLine(label_aq_sensor_2.Text + " : " + aq_sensor2.Text);
                    sw.WriteLine(label_det_mode1.Text + " : " + aq_det_mode1.Text);
                    sw.WriteLine(label_det_pos1.Text + " : " + aq_det_pos1.Text);
                    sw.WriteLine(label_det_mode2.Text + " : " + aq_det_mode2.Text);
                    sw.WriteLine(label_det_pos2.Text + " : " + aq_det_pos2.Text);
                    sw.WriteLine(label_sensor_gain1.Text + " : " + aq_sensor_gain1.Text);
                    sw.WriteLine(label_sensor_gain2.Text + " : " + aq_sensor_gain2.Text);
                    sw.WriteLine(label_filt_sensor1.Text + " : " + aq_filt_sensor1.Text);
                    sw.WriteLine(label_filt_sensor2.Text + " : " + aq_filt_sensor2.Text);


                    sw.WriteLine("-----------------------------Electronics-----------------------------------");
                    sw.WriteLine(label_ele_data_aq.Text + " : " + ele_data_aq.Text);
                    sw.WriteLine(label_ele_samp_time.Text + " : " + ele_samp_time.Text);
                    sw.WriteLine(label_ele_data_aq_time.Text + " : " + ele_data_aq_time.Text);

                    sw.Close();
                    filestream.Close();
                    MessageBox.Show("Saved as text document successfully");

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            checkDatabase();
            pictureBox1.BackgroundImage = Properties.Resources.nofiber;
            las_exci_pos.Enabled = false;
        }

        private void checkDatabase()
        {
            if (!File.Exists("mlbssdata2.db"))
            {
                SQLiteConnection.CreateFile("mlbssdata2.db");
                using (SQLiteConnection conn = new SQLiteConnection(AppSettings.ConnectionString()))
                {
                    string commandString = "CREATE TABLE mlbssgui2(ExpIndex  NVARCHAR(250),Date NVARCHAR(250),Time NVARCHAR(50) ,MFDManufacturer  NVARCHAR(50) ," +
                        "MFDMaterial NVARCHAR(50),MFDFocusing  NVARCHAR(50),MFDID  NVARCHAR(50),Sample  NVARCHAR(50),SampleSource  NVARCHAR(50),SampleConctn  NVARCHAR(50)," +
                        "SampleStaining  NVARCHAR(50),Stainingconctn  NVARCHAR(50),Sheath1  NVARCHAR(50),Sheath2  NVARCHAR(50),SampleFlowRate NVARCHAR(50)," +
                        "Sheath1FlowRate  NVARCHAR(50),Sheath2FlowRate  NVARCHAR(50),SampleDispenser  NVARCHAR(50),Sheath1Dispenser  NVARCHAR(50),Sheath2Dispenser  NVARCHAR(50)," +
                        "ExcitationLaser  NVARCHAR(50),ExcitationLaserPower  NVARCHAR(50),ExcitationMode  NVARCHAR(50), ExcitationPosition  NVARCHAR(50),AblationLaser  NVARCHAR(50)," +
                        "AblationLaserPower  NVARCHAR(50),Sensor1  NVARCHAR(50),Sensor2  NVARCHAR(50),DetectionMode1  NVARCHAR(50),DetectionPosition1  NVARCHAR(50)," +
                        "DetectionMode2  NVARCHAR(50),DetectionPosition2  NVARCHAR(50),Sensor1gain  NVARCHAR(50),Sensor2gain  NVARCHAR(50),Filterforsensor1  NVARCHAR(50)," +
                        " Filterforsensor2  NVARCHAR(50),DataAcquisitionSystem  NVARCHAR(50),SamplingTime  NVARCHAR(50),DataAcquisitionTime  NVARCHAR(50))";
                    using (SQLiteCommand com = new SQLiteCommand(commandString, conn))
                    {
                        conn.Open();
                        com.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                LoadDataIntoGrid();
            }
        }


        private void LoadDataIntoGrid()
        {
            dataGridView1.DataSource = GetDataFromDatabase();
        }

        private DataTable GetDataFromDatabase()
        {
            DataTable dtExp = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(AppSettings.ConnectionString()))
            {
                string commandString = "SELECT * FROM mlbssgui2";
                using (SQLiteCommand com = new SQLiteCommand(commandString, conn))
                {
                    conn.Open();
                    SQLiteDataReader reader = com.ExecuteReader();
                    dtExp.Load(reader);
                }
            }
            return dtExp;
        }

        private void DT_Click(object sender, EventArgs e)
        {
            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   if(textBoxID.Text=="")
            {
                MessageBox.Show("Please Enter the ID");
            }
            else if (textBoxDate.Text == "" || textBoxTime.Text == "" || textBoxTime.Text == "" || mfd_manu.Text == "" || mfd_mat.Text == "" || mfd_focus.Text == "" || mfd_id_tb.Text == "" ||
                 fld_sample.Text == "" || fld_samp_source.Text == "" || fld_samp_conc.Text == "" || fld_samp_stain.Text == "" || fld_stain_conc.Text == "" || fld_sheath1.Text == "" ||
                fld_sheath2.Text == "" || fld_samp_flow_rate.Text == "" || fld_sheath1_flow_rate.Text == "" || fld_sheath2_flowrate.Text == "" || las_exci_laser.Text == "" || las_las_pow.Text == "" ||
                las_exci_mode.Text == "" || las_abli_las.Text == "" || las_abli_pow.Text == "" || aq_sensor1.Text == "" || aq_sensor2.Text == "" || aq_det_mode1.Text == "" ||
                 aq_det_pos1.Text == "" || aq_det_mode2.Text == "" || aq_det_pos2.Text == "" || aq_sensor_gain1.Text == "" || aq_sensor_gain2.Text == "" || aq_filt_sensor1.Text == "" || aq_filt_sensor2.Text == "" ||
                 ele_data_aq.Text == "" || ele_samp_time.Text == "" || ele_data_aq_time.Text == "")
            {
                MessageBox.Show("Please fill the empty fields");
            }

            else
            {
                DialogResult myresult2;
                myresult2 = MessageBox.Show("Is everything correct?", "Save Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (myresult2 == DialogResult.OK)
                {
                    try
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(AppSettings.ConnectionString()))
                        {
                            string commandString = "INSERT INTO mlbssgui2([ExpIndex],[Date],[Time],[MFDManufacturer],[MFDMaterial],[MFDFocusing],[MFDID],[Sample],[SampleSource]," +
                                "[SampleConctn],[SampleStaining],[Stainingconctn],[Sheath1],[Sheath2],[SampleFlowRate],[Sheath1FlowRate] ,[Sheath2FlowRate],[SampleDispenser]," +
                                "[Sheath1Dispenser],[Sheath2Dispenser],[ExcitationLaser],[ExcitationLaserPower],[ExcitationMode] , [ExcitationPosition] ,[AblationLaser]," +
                                "[AblationLaserPower],[Sensor1],[Sensor2],[DetectionMode1],[DetectionPosition1],[DetectionMode2] ,[DetectionPosition2],[Sensor1gain],[Sensor2gain]," +
                                "[Filterforsensor1],[Filterforsensor2],[DataAcquisitionSystem],[SamplingTime],[DataAcquisitionTime]) VALUES (@ExpIndex,@Date,@Time,@MFDManufacturer," +
                                "@MFDMaterial,@MFDFocusing,@MFDID,@Sample,@SampleSource,@SampleConctn,@SampleStaining ,@Stainingconctn ,@Sheath1,@Sheath2,@SampleFlowRate," +
                                "@Sheath1FlowRate,@Sheath2FlowRate,@SampleDispenser,@Sheath1Dispenser,@Sheath2Dispenser,@ExcitationLaser,@ExcitationLaserPower,@ExcitationMode," +
                                " @ExcitationPosition,@AblationLaser,@AblationLaserPower,@Sensor1,@Sensor2,@DetectionMode1,@DetectionPosition1,@DetectionMode2,@DetectionPosition2," +
                                "@Sensor1gain,@Sensor2gain,@Filterforsensor1,@Filterforsensor2,@DataAcquisitionSystem,@SamplingTime,@DataAcquisitionTime)";
                            using (SQLiteCommand com = new SQLiteCommand(commandString, conn))
                            {
                                conn.Open();

                                com.Parameters.AddWithValue("@ExpIndex", textBoxID.Text);
                                com.Parameters.AddWithValue("@Date", textBoxDate.Text);
                                com.Parameters.AddWithValue("@Time", textBoxTime.Text);

                                com.Parameters.AddWithValue("@MFDManufacturer", mfd_manu.Text);
                                com.Parameters.AddWithValue("@MFDMaterial", mfd_mat.Text);
                                com.Parameters.AddWithValue("@MFDFocusing", mfd_focus.Text);
                                com.Parameters.AddWithValue("@MFDID", mfd_id_tb.Text);
                                com.Parameters.AddWithValue("@Sample", fld_sample.Text);
                                com.Parameters.AddWithValue("@SampleSource", fld_samp_source.Text);
                                com.Parameters.AddWithValue("@SampleConctn", fld_samp_conc.Text);
                                com.Parameters.AddWithValue("@SampleStaining", fld_samp_stain.Text);
                                com.Parameters.AddWithValue("@Stainingconctn", fld_stain_conc.Text);
                                com.Parameters.AddWithValue("@Sheath1", fld_sheath1.Text);
                                com.Parameters.AddWithValue("@Sheath2", fld_sheath2.Text);
                                com.Parameters.AddWithValue("@SampleFlowRate", fld_samp_flow_rate.Text);
                                com.Parameters.AddWithValue("@Sheath1FlowRate", fld_sheath1_flow_rate.Text);
                                com.Parameters.AddWithValue("@Sheath2FlowRate", fld_sheath2_flowrate.Text);
                                com.Parameters.AddWithValue("@SampleDispenser", fld_samp_dispn.Text);
                                com.Parameters.AddWithValue("@Sheath1Dispenser", fld_sheath1_dispn.Text);
                                com.Parameters.AddWithValue("@Sheath2Dispenser", fld_sheath2_dispn.Text);

                                com.Parameters.AddWithValue("@ExcitationLaser", las_exci_laser.Text);
                                com.Parameters.AddWithValue("@ExcitationLaserPower", las_las_pow.Text);
                                com.Parameters.AddWithValue("@ExcitationMode", las_exci_mode.Text);
                                com.Parameters.AddWithValue("@ExcitationPosition", las_exci_pos.Text);
                                com.Parameters.AddWithValue("@AblationLaser", las_abli_las.Text);
                                com.Parameters.AddWithValue("@AblationLaserPower", las_abli_pow.Text);

                                com.Parameters.AddWithValue("@Sensor1", aq_sensor1.Text);
                                com.Parameters.AddWithValue("@Sensor2", aq_sensor2.Text);
                                com.Parameters.AddWithValue("@DetectionMode1", aq_det_mode1.Text);
                                com.Parameters.AddWithValue("@DetectionPosition1", aq_det_pos1.Text);
                                com.Parameters.AddWithValue("@DetectionMode2", aq_det_mode2.Text);
                                com.Parameters.AddWithValue("@DetectionPosition2", aq_det_pos2.Text);
                                com.Parameters.AddWithValue("@Sensor1gain", aq_sensor_gain1.Text);
                                com.Parameters.AddWithValue("@Sensor2gain", aq_sensor_gain2.Text);
                                com.Parameters.AddWithValue("@Filterforsensor1", aq_filt_sensor1.Text);
                                com.Parameters.AddWithValue("@Filterforsensor2", aq_filt_sensor2.Text);

                                com.Parameters.AddWithValue("@DataAcquisitionSystem", ele_data_aq.Text);
                                com.Parameters.AddWithValue("@SamplingTime", ele_samp_time.Text);
                                com.Parameters.AddWithValue("@DataAcquisitionTime", ele_data_aq_time.Text);

                                com.ExecuteNonQuery();

                            }
                        }

                        LoadDataIntoGrid();
                        MessageBox.Show("saved to database successfully ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("something went wrong!!!!!!!!" + ex);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.nofiber;
            mfd_id_tb.Text = "LF_B1_D1";
            fld_samp_conc.Text = "20";
            fld_stain_conc.Text = "10";
            fld_samp_flow_rate.Text = "1.66";
            fld_sheath1_flow_rate.Text = "26.6";
            fld_sheath2_flowrate.Text = "179";
            las_las_pow.Text = "30";
            las_abli_pow.Text = "0";
            aq_sensor_gain1.Text = "0.410";
            aq_sensor_gain2.Text = "0.410";
            aq_filt_sensor1.Text = "4OO long pass";
            aq_filt_sensor2.Text = "4OO long pass";
            ele_samp_time.Text = "10";
            ele_data_aq_time.Text = "5";

            mfd_manu.Text = "";
            mfd_mat.Text = "";
            mfd_focus.Text = "";

            fld_sample.Text = "";
            fld_samp_source.Text = "";
            fld_samp_stain.Text = "";
            fld_sheath1.Text = "";
            fld_sheath2.Text = "";
            fld_samp_dispn.Text = "";
            fld_sheath1_dispn.Text = "";
            fld_sheath2_dispn.Text = "";

            las_exci_laser.Text = "";
            las_exci_pos.Text = "";
            las_abli_las.Text = "";

            aq_sensor1.Text = "";
            aq_sensor2.Text = "";
            aq_det_mode1.Text = "";
            aq_det_pos1.Text = "";
            aq_det_mode2.Text = "";
            aq_det_pos2.Text = "";
            ele_data_aq.Text = "";

            textBoxID.Text = "";

            textBoxDate.Text = DateTime.Now.ToLongDateString();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();

            las_exci_mode.Text = "";
            las_exci_pos.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please enter an ID to delete");
            }
            else
            {
                DialogResult myresult;
                myresult = MessageBox.Show("Really want to delete??", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myresult == DialogResult.OK)
                {


                    try
                    {

                        using (SQLiteConnection conn = new SQLiteConnection(AppSettings.ConnectionString()))
                        {
                            string commandString = "DELETE FROM mlbssgui2 WHERE ExpIndex ='" + textBoxID.Text + "'";
                            using (SQLiteCommand com = new SQLiteCommand(commandString, conn))
                            {

                                conn.Open();
                                com.ExecuteNonQuery();
                            }

                        }
                        LoadDataIntoGrid();
                        MessageBox.Show(" Deleted from database successfully");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("something went wrong!!!!!!!!" + ex);
                    }

                }
            }
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBoxID.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBoxDate.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBoxTime.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();

            //MFD      
            mfd_manu.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            mfd_mat.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            mfd_focus.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
            mfd_id_tb.Text = dataGridView1.Rows[n].Cells[6].Value.ToString();

            //FLUIDICS
            fld_sample.Text = dataGridView1.Rows[n].Cells[7].Value.ToString();
            fld_samp_source.Text = dataGridView1.Rows[n].Cells[8].Value.ToString();
            fld_samp_conc.Text = dataGridView1.Rows[n].Cells[9].Value.ToString();
            fld_samp_stain.Text = dataGridView1.Rows[n].Cells[10].Value.ToString();
            fld_stain_conc.Text = dataGridView1.Rows[n].Cells[11].Value.ToString();
            fld_sheath1.Text = dataGridView1.Rows[n].Cells[12].Value.ToString();
            fld_sheath2.Text = dataGridView1.Rows[n].Cells[13].Value.ToString();
            fld_samp_flow_rate.Text = dataGridView1.Rows[n].Cells[14].Value.ToString();
            fld_sheath1_flow_rate.Text = dataGridView1.Rows[n].Cells[15].Value.ToString();
            fld_sheath2_flowrate.Text = dataGridView1.Rows[n].Cells[16].Value.ToString();
            fld_samp_dispn.Text = dataGridView1.Rows[n].Cells[17].Value.ToString();
            fld_sheath1_dispn.Text = dataGridView1.Rows[n].Cells[18].Value.ToString();
            fld_sheath2_dispn.Text = dataGridView1.Rows[n].Cells[19].Value.ToString();

            //LASER
            las_exci_laser.Text = dataGridView1.Rows[n].Cells[20].Value.ToString();
            las_las_pow.Text = dataGridView1.Rows[n].Cells[21].Value.ToString();
            las_exci_mode.Text = dataGridView1.Rows[n].Cells[22].Value.ToString();
            las_exci_pos.Text = dataGridView1.Rows[n].Cells[23].Value.ToString();
            las_abli_las.Text = dataGridView1.Rows[n].Cells[24].Value.ToString();
            las_abli_pow.Text = dataGridView1.Rows[n].Cells[25].Value.ToString();


            //ACQUISITION
            aq_sensor1.Text = dataGridView1.Rows[n].Cells[26].Value.ToString();
            aq_sensor2.Text = dataGridView1.Rows[n].Cells[27].Value.ToString();
            aq_det_mode1.Text = dataGridView1.Rows[n].Cells[28].Value.ToString();
            aq_det_pos1.Text = dataGridView1.Rows[n].Cells[29].Value.ToString();
            aq_det_mode2.Text = dataGridView1.Rows[n].Cells[30].Value.ToString();
            aq_det_pos2.Text = dataGridView1.Rows[n].Cells[31].Value.ToString();
            aq_sensor_gain1.Text = dataGridView1.Rows[n].Cells[32].Value.ToString();
            aq_sensor_gain2.Text = dataGridView1.Rows[n].Cells[33].Value.ToString();
            aq_filt_sensor1.Text = dataGridView1.Rows[n].Cells[34].Value.ToString();
            aq_filt_sensor2.Text = dataGridView1.Rows[n].Cells[35].Value.ToString();

            //ELECTRONICS
            ele_data_aq.Text = dataGridView1.Rows[n].Cells[36].Value.ToString();
            ele_samp_time.Text = dataGridView1.Rows[n].Cells[37].Value.ToString();
            ele_data_aq_time.Text = dataGridView1.Rows[n].Cells[38].Value.ToString();
        }

        private void las_exci_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (las_exci_mode.Text == "Fiber")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber_select;
                las_exci_pos.Enabled = true;
            } 
            else if (las_exci_mode.Text == "Objective")
            {
                pictureBox1.BackgroundImage = Properties.Resources.Picture6;
                las_exci_pos.Text = "";

                las_exci_pos.Enabled = false;
            }
        }

        private void las_exci_pos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (las_exci_pos.Text == "")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber_select;
            }
            else if (las_exci_pos.Text == "Position 1")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber1;
            }
            else if (las_exci_pos.Text == "Position 2")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber2;
            }
            else if (las_exci_pos.Text == "Position 3")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber3;
            }
            else if (las_exci_pos.Text == "Position 4")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber4;
            }
            else if (las_exci_pos.Text == "Position 5")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber5;
            }
            else if (las_exci_pos.Text == "Position 6")
            {
                pictureBox1.BackgroundImage = Properties.Resources.fiber6;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text == "")
            {
                MessageBox.Show("please enter id to update!");
            }
            else if (textBoxDate.Text == "" || textBoxTime.Text == "" || textBoxTime.Text == "" || mfd_manu.Text == "" || mfd_mat.Text == "" || mfd_focus.Text == "" || mfd_id_tb.Text == "" ||
                 fld_sample.Text == "" || fld_samp_source.Text == "" || fld_samp_conc.Text == "" || fld_samp_stain.Text == "" || fld_stain_conc.Text == "" || fld_sheath1.Text == "" ||
                fld_sheath2.Text == "" || fld_samp_flow_rate.Text == "" || fld_sheath1_flow_rate.Text == "" || fld_sheath2_flowrate.Text == "" || las_exci_laser.Text == "" || las_las_pow.Text == "" ||
                las_exci_mode.Text == "" || las_abli_las.Text == "" || las_abli_pow.Text == "" || aq_sensor1.Text == "" || aq_sensor2.Text == "" || aq_det_mode1.Text == "" ||
                 aq_det_pos1.Text == "" || aq_det_mode2.Text == "" || aq_det_pos2.Text == "" || aq_sensor_gain1.Text == "" || aq_sensor_gain2.Text == "" || aq_filt_sensor1.Text == "" || aq_filt_sensor2.Text == "" ||
                 ele_data_aq.Text == "" || ele_samp_time.Text == "" || ele_data_aq_time.Text == "")
            {
                MessageBox.Show("Please enter the empty fields!");
            }
            else
            {
                DialogResult myresult;
                myresult = MessageBox.Show("Proceed  update?", "Update Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (myresult == DialogResult.OK)
                {
                    try
                    {
                        using (SQLiteConnection conn = new SQLiteConnection(AppSettings.ConnectionString()))
                        {
                            string commandString = " UPDATE `mlbssgui2` SET `Date`='" + textBoxDate.Text + "',`Time`='" + textBoxTime.Text + "'," +
                            "`MFDManufacturer`='" + mfd_manu.Text + "',`MFDMaterial`='" + mfd_mat.Text + "',`MFDFocusing`='" + mfd_focus.Text + "'," +
                            "`MFDID`='" + mfd_id_tb.Text + "',`Sample`='" + fld_sample.Text + "',`SampleSource`='" + fld_samp_source.Text + "'," +
                            "`SampleConctn`='" + fld_samp_conc.Text + "',`SampleStaining`='" + fld_samp_stain.Text + "',`Stainingconctn`='" + fld_stain_conc.Text + "'," +
                            "`Sheath1`='" + fld_sheath1.Text + "',`Sheath2`='" + fld_sheath2.Text + "',`SampleFlowRate`='" + fld_samp_flow_rate.Text + "'," +
                            "`Sheath1FlowRate`='" + fld_sheath1_flow_rate.Text + "',`Sheath2FlowRate`='" + fld_sheath2_flowrate.Text + "'," +
                            "`SampleDispenser`='" + fld_samp_dispn.Text + "',`Sheath1Dispenser`='" + fld_sheath1_dispn.Text + "',`Sheath2Dispenser`='" + fld_sheath2_dispn.Text + "'" +
                            ",`ExcitationLaser`='" + las_exci_laser.Text + "',`ExcitationLaserPower`='" + las_las_pow.Text + "',`ExcitationMode`='" + las_exci_mode.Text + "',`ExcitationPosition`='" + las_exci_pos.Text + "'," +
                            "`AblationLaser`='" + las_abli_las.Text + "',`AblationLaserPower`='" + las_abli_pow.Text + "',`Sensor1`='" + aq_sensor1.Text + "',`Sensor2`='" + aq_sensor2.Text + "',`DetectionMode1`='" + aq_det_mode1.Text + "'" +
                            ",`DetectionPosition1`='" + aq_det_pos1.Text + "',`DetectionMode2`='" + aq_det_mode2.Text + "',`DetectionPosition2`='" + aq_det_pos2.Text + "',`Sensor1gain`='" + aq_sensor_gain1.Text + "'," +
                            "`Sensor2gain`='" + aq_sensor_gain2.Text + "',`Filterforsensor1`='" + aq_filt_sensor1.Text + "',`Filterforsensor2`='" + aq_filt_sensor2.Text + "',`DataAcquisitionSystem`='" + ele_data_aq.Text + "'," +
                            "`SamplingTime`='" + ele_samp_time.Text + "',`DataAcquisitionTime`='" + ele_data_aq_time.Text + "' WHERE ExpIndex= " + textBoxID.Text + "";
                            using (SQLiteCommand com = new SQLiteCommand(commandString, conn))
                            {

                                conn.Open();
                                com.ExecuteNonQuery();
                            }

                        }
                        LoadDataIntoGrid();
                        MessageBox.Show("updated successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong!!!!!" + ex);
                    }
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
