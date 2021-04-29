static void Selenum1() {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "https://www.uaz.edu.mx";
            //Pausa();
            var nav = driver.Navigate();
            nav.GoToUrl("https://google.com");
            driver.Manage().Window.Maximize();
            //Pausa();
            var elemento = driver.FindElement(By.Name("q"));
            elemento.Click();
            elemento.SendKeys("gorditas doña julia"+Keys.Return);
            Pausa();
            var captura = driver.GetScreenshot();
            captura.SaveAsFile("capturagoogle.png");
            nav.Back();
            nav.Back();
            Pausa();
            var html = driver.PageSource;
            Console.WriteLine(html);
            File.WriteAllText("codigofuente.html",html);
            Pausa();
            nav.Forward();
            nav.Refresh();
            Pausa();
            driver.Close();
        }
