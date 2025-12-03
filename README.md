**HMS (Hospital Management System)**

HMS is a desktop-based Hospital Management System built with C# .NET 4.8 WinForms and SQL Server LocalDB. It allows hospital staff to efficiently manage patients, doctors, users, appointments, and billing.

**Features**

Patients, Doctors, Users, Appointments: Add, update, delete, view, and view all.

Appointments: Search by a specific day or a date range.

Bills: Create, view, and view all bills. Bills cannot be deleted.

PDF Generation: Generate PDF bills using PDFsharp/MigraDoc.

Attachments: Attach files (e.g., X-rays, reports) while updating patients, and view attached files when viewing patients.

**Technologies Used**

C# .NET Framework 4.8 (WinForms)

SQL Server LocalDB 2022

LINQ-to-SQL

PDFsharp / MigraDoc 6.2.3

**Installation**

Install SQL Server LocalDB 2022
Download and install from Microsoft’s official site if not already installed.

Setup LocalDB
Open Command Prompt and run one by one:

sqllocaldb stop MSSQLLocalDB

sqllocaldb delete MSSQLLocalDB

sqllocaldb create MSSQLLocalDB

sqllocaldb start MSSQLLocalDB


**Database Setup**
Place the HMS.sql file in the same folder as the executable:

bin/Debug/HMS.exe


or

bin/Release/HMS.exe



Run the Application
Open HMS.exe and start managing the hospital.

**Usage**

Navigate through the tabs to manage patients, doctors, users, appointments, and bills.

Attach files when updating patient records.

Generate PDFs when viewing bills.

Search appointments by specific dates or date ranges.
