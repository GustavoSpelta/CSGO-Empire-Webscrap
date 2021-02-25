using System;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace empirevisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region "Navegador"
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://csgoempire.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            #endregion
            #region "Login"
            driver.FindElement(By.XPath(("//div[contains(@class, 'layout')]/div[3]/div[2]/div[3]/a"))).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(("//*[@id= 'steamAccountName']"))).SendKeys("leonardoafkr1");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(("//*[@id= 'steamPassword']"))).SendKeys("S4kl5zxr2cz*b2");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(("//*[@id='imageLogin']"))).Click();
            Thread.Sleep(15000);
            #endregion
            /*
            #region "Valores"
            IWebElement ct = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[3]"));
            IWebElement tr = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[7]"));
            IWebElement dado = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[5]"));
            IWebElement cronometro = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[3]/div/div[2]"));
            IWebElement dinheiro = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div/div[3]/div[2]/div[3]/div/div/span/span"));
            IWebElement nome = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div/div[3]/div[2]/div[4]/button/span"));
            string auxct = ct.Text;
            string auxtr = tr.Text;
            string auxdado = dado.Text;
            string auxcronometro = cronometro.Text;
            string auxnome = nome.Text;
            string auxdinheiro = dinheiro.Text;
            #endregion
            #region Interface
            label2.Text = auxct;
            label3.Text = auxtr;
            label4.Text = auxdado;
            label5.Text = auxdinheiro;
            label6.Text = auxnome;
            #endregio
            */
            do
            {
                IWebElement dinheiro2 = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div/div[3]/div[2]/div[3]/div/div/span/span"));
                string auxdinheiro2 = dinheiro2.Text;
                float auxdinheiro3 = Convert.ToInt32(auxdinheiro2);
                if (auxdinheiro3 > 0)
                {
                    #region "Valores"
                    IWebElement ct = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[3]"));
                    IWebElement tr = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[7]"));
                    IWebElement dado = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[3]/div/div[2]/div[5]"));
                    IWebElement cronometro = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div/div/div[1]/div/div/div[2]/div[3]/div/div[2]"));
                    IWebElement dinheiro = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div/div[3]/div[2]/div[3]/div/div/span/span"));
                    IWebElement nome = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div[1]/div/div[3]/div[2]/div[4]/button/span"));
                    string auxct = ct.Text;
                    string auxtr = tr.Text;
                    string auxdado = dado.Text;
                    string auxcronometro = cronometro.Text;
                    string auxnome = nome.Text;
                    string auxdinheiro = dinheiro.Text;
                    #endregion
                    #region Interface
                    label2.Text = auxct;
                    label3.Text = auxtr;
                    label4.Text = auxdado;
                    label5.Text = auxdinheiro;
                    label6.Text = auxnome;
                    #endregion
                }
                else
                {
                    break;
                }
                break;
            } while (true);
        }
    }
}