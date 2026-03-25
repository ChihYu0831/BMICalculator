using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            bool isHeightVaild = double.TryParse(this.txtHeight.Text, out double height);
            bool isWeightVaild = double.TryParse(this.txtWeight.Text, out double weight);

            height = height / 100;//將身高轉換為公尺

            double bmi = weight / (height * height);

            string strResult = "";

            if(bmi < 18.5)
            {
                strResult = "過輕";
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                strResult = "正常";
            }
            else if (bmi >= 24 && bmi < 27)
            {
                strResult = "過重";
            }
            else if (bmi >= 27 && bmi < 30)
            {
                strResult = "輕度肥胖";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                strResult = "中度肥胖";
            }
            else
            {
                strResult = "重度肥胖";
            }




        }
    }
}
