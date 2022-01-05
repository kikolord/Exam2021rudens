using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        IWebDriver WebDriver;

        public Form1()
        {

            InitializeComponent();

            var options = new ChromeOptions();

            options.AddExcludedArgument("enable-loggin");

            WebDriver = new ChromeDriver(@"C:\Users\Štarks\Desktop\WebDrivers", options);

            WebDriver.Url = "https://www.ebay.com/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebDriver.FindElement(By.Id("gh-ac")).SendKeys(textBox1.Text);

            WebDriver.FindElement(By.Id("gh-btn")).Click();

            textBox2.Text = WebDriver.Url;

            richTextBox1.AppendText(textBox2.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebDriver.Navigate().GoToUrl("https://www.ebay.com/");

            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebDriver.Quit();
        }
    }
}
// testesanu nepaspeju jo laika trukums. un ir neskaidribas par testesanu ka jau runajam ! 