﻿namespace JackBraun_EasyNotesProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage(new LocalDBService()));

        }
    }
}
