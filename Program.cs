namespace supermarket_mangement_system
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and show the splash screen
            Form1 splash = new  Form1();
            splash.Show();

            // Simulate some loading time (e.g., load resources, perform initialization)
            System.Threading.Thread.Sleep(3000); // Simulate a 3-second load time

            // Close the splash screen
            splash.CloseSplash();

            // Start the main form
            Application.Run(new Form1());
        } };

            // Run the main form (Login)
          
        }
    
