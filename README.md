# FinAppDemo
 # Overview
   FinAppDemo is a prototype financial application built using .NET MAUI. It serves as a proof of concept for a digital financial service application enabling secure transactions through mobile devices using mobile numbers. <br>
   The app allows users to perform essential financial operations such as money transfers, QR code transactions (both online and offline), and USSD-based services for users without reliable internet access.<br>
   The project uses Azure SQL as the database backend and incorporates various project management practices to simulate a real-world development environment.<br>
 # Technology used
   - Framework: .NET MAUI <br>
   - Language: C# <br>
   - Database: Azure SQL <br>
   - Project Management: Ms Project, Ms excel. <br>
   - Version Control: Git <br>
   - Development Environment: Visual Studio 2022 <br>
 # Project Artifacts
   1. **Application Source Code**: The src folder contains the full source code for the FinAppDemo app, which can be used to build  and run the app locally using Visual Studio. <br>
   2. **Project Management Documents**:Located in the PM docs folder, these artifacts document the planning and progress of the project: <br>
         - Gantt Chart: Tracks development timelines and milestones. <br>
         - Project Burndown Chart: Visualizes sprint progress and remaining work. <br>
         - Current Prototype Demo (Video): A walkthrough of the app's current functionality (Keep in mind I am still working on the app, so the video just showcases the current completed state). <br>
   3. **Database Scripts**: The scripts folder contains the script for recreating the structure of the database for users who want to recreate the database on their own azure instance or for users with limmited internet connection that want to recreate the database loacally on SQl server express. <br>
         - FinAppDemoSQLQuery.sql: A SQL script for stakeholders to recreate the database structure on their own Azure SQL instance or sql server express.<br>
# Getting started
 # Prerequisites
   1. Visual Studio 2022 with the .NET MAUI workload installed.<br>
   2. NuGet Packages: Ensure the following packages are installed in your project (these can be managed via the NuGet Package Manager in Visual Studio): <br>
            - Microsoft.Data.SqlClient <br>
            - Microsoft.Extensions.Logging.Debug <br>
            - Microsoft.Maui.Controls <br>
            - Microsoft.Maui.Controls.Compatibility <br>
            - Microsoft.NET.ILLink.Tasks <br>
            - QRCoder <br>
            - ZXing.Net.Maui <br>
            - ZXing.Net.Maui.Controls <br>
 # Steps to run locally
  1. Clone the repository: https://github.com/Celiakamana/FinAppDemo.git <br>
  2. Open the FinAppDemo.sln file (path:...\FinAppDemo\src) in Visual Studio.<br>
  3. (Optional) If you choose to recreate the database structure, update the database connection string in the code (DatabaseConfig.cs) to connect to your new database. <br>
  4. Build and run the app for your preferred platform (Android, iOS, Windows). <br>
 # Dummy Data
 To test the application, use the following dummy account:<br>
   Phone Number: 1234567890 <br>
   First Name: Joe <br>
   Last Name: Doe <br>
   Email: jd@gmail.com <br>
   Password: 123 <br>
   Note: <br>
   You are welcome to create your own dummy data. However, please note that all newly created dummy data will be deleted after one month for database maintenance purposes.<br>
# Future plans
  Migrate to a Blazor Hybrid Web App for broader deployment on web platforms.<br>
  Integrate real-world payment gateways for actual financial transactions. <br>
  Deploy on app stores for iOS and Android once the prototype matures. <br>
# License
  This project is licensed under the Apache -2.0 License.
# Contact
  For questions, suggestions, collaborations or issues, reach out via the GitHub Issues page or shoot me an email at kamanacelia@gmail.com.
