using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string operation = "";
        double result = 0;
        bool isoperatorperfomed = false;

        public Form1()
        {
            InitializeComponent();
        }


        string sonuc = "";
        private void button_click(object sender, EventArgs e) // button içinde ki text sender a geliyor biz de button tipinde bir örnek alıp onun içinde senderı gödeerdikten sonra
                                                              // result box içerisindeki değerlere butona ne basılır ise orada ki txt sayıyı yazdırıyoruz tüm sayıların click
                                                              // eventini aynı yaparak tek tek yazmaktan kurtulmuş olduk
        {
            if (resultbox.Text == "0" || isoperatorperfomed)
            {
                resultbox.Clear();
            }
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();

            button = (System.Windows.Forms.Button)sender;
            if (button.Text == ".")
            {
                if (!resultbox.Text.Contains("."))
                {
                    resultbox.Text = resultbox.Text + button.Text;
                }
            }
            else
            {
                resultbox.Text = resultbox.Text + button.Text;  
            }

            
            isoperatorperfomed = false; // burada operasyon tuşuna basıldı mı bool koşulu her operasyon tuşuna bastığımızda true her sayı butonunda ise false olsun istedik böylece satıra yazılan her sayı eiştlendiğinde bize birleşik sayı yerine direkt sonucu gösterir
        }

        private void operator_click(object sender, EventArgs e)
        {
          
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();

            button = (System.Windows.Forms.Button)sender;
            if (result !=0)
            {
                btn_equal.PerformClick(); //ikinci sayı girdiğimizi anlayıp aşağıdaki işlemleri tekrar yapması için btn click eventine yollamış olduk kodu
                operation = button.Text;
             
                isoperatorperfomed = true;
               
            }
            else
            {
                operation = button.Text;
                result = double.Parse(resultbox.Text);
                isoperatorperfomed = true;

            }



        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resultbox.Clear();
            resultbox.Text= "0";
            result = 0;
        }

        private void equal_click(object sender, EventArgs e)
        {

            string sayi = resultbox.Text;
            switch (operation)
            {

                case "+":
                    sonuc = (result + double.Parse(resultbox.Text)).ToString(); // result 0 dı resultbox içinde ki veriyi sayı yapıp işlemden sonra to string ile result box içine yine yazdırmış olduk                 
                   
                    break;
                case "-":
                    sonuc = (result - double.Parse(resultbox.Text)).ToString();
                
                    break;
                case "*":
                    sonuc = (result * double.Parse(resultbox.Text)).ToString();
               
                    break;
                case "/":
                    sonuc = (result / double.Parse(resultbox.Text)).ToString();
                  
                    break;


            }
            
            resultbox.Text= sonuc;
            lbl_islem.Text = result + "" + operation + sayi + "=" + sonuc;

        }
    }    
       
}
