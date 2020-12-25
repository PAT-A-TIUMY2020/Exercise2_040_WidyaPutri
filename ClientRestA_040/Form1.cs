using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRestA_040
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			TampilData();
		}


		string baseUrl = "http://localhost:1907/";
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		public void TampilData()
		{
			var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

			dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			textNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			txtNIM.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
			txtProdi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
			txtAngkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
		}

		private void Creat_Click(object sender, EventArgs e)
		{
			Mahasiswa mhs = new Mahasiswa();
			mhs.nama = textNama.Text;
			mhs.nim = txtNIM.Text;
			mhs.prodi = txtProdi.Text;
			mhs.angkatan = txtAngkatan.Text;

			var data = JsonConvert.SerializeObject(mhs);
			var postdata = new WebClient();
			postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
			string response = postdata.UploadString(baseUrl + "Mahasiswa", data);
			Console.WriteLine(response);
			TampilData();
		}
		public void Clear()
		{
			txtNIM.Clear();
			textNama.Clear();
			txtProdi.Clear();
			txtAngkatan.Clear();
		}
		private void btClear_Click(object sender, EventArgs e)
		{
			Clear();
		}
		public void SearchData()
		{
			var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
			var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
			string nim = NIMSearch.Text;
			if (nim == null || nim == "")
			{
				dataGridView1.DataSource = data;
			}
			else
			{
				var item = data.Where(x => x.nim == txtNIM.Text).ToList();

				dataGridView1.DataSource = item;
			}
		}
		private void btSearch_Click(object sender, EventArgs e)
		{
			SearchData();
		}
	}
	[DataContract]
	public class Mahasiswa
	{
		private string _nama, _nim, _prodi, _angkatan;
		[DataMember]
		public string nama
		{
			get { return _nama; }
			set { _nama = value; }
		}
		[DataMember]
		public string nim
		{
			get { return _nim; }
			set { _nim = value; }
		}
		[DataMember]
		public string prodi
		{
			get { return _prodi; }
			set { _prodi = value; }
		}
		[DataMember]
		public string angkatan
		{
			get { return _angkatan; }
			set { _angkatan = value; }
		}
	}
}
