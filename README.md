# DVLD - Driving & Vehicle License Department Management System

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Database](https://img.shields.io/badge/Database-SQL%20Server-CC292B?logo=microsoftsqlserver&logoColor=white)](https://www.microsoft.com/sql-server/)
[![Platform](https://img.shields.io/badge/Platform-Windows%20Forms-0078D6?logo=windows&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)

A comprehensive Windows desktop application designed to streamline and automate the operations of the **Driver and Vehicle Licensing Department (DVLD)**. The system manages citizen profiles, driving license applications, multi-stage examination pipelines, driver records, license issuance, renewals, replacements, and license detention workflows.

---

## 📋 Table of Contents
- [Features & Modules](#-features--modules)
- [System Architecture](#-system-architecture)
- [Database Overview](#-database-overview)
- [Project Structure](#-project-structure)
- [Getting Started](#-getting-started)
- [Prerequisites](#prerequisites)
- [Installation & Setup](#installation--setup)
- [License & Author](#-author)

---

## 🚀 Features & Modules

### 1. People Management
- **Centralized Profiles**: Store complete personal details (National No, Name, Gender, DOB, Address, Phone, Email, Nationality, and Photo).
- **Search & Filtering**: Search and filter citizens dynamically by ID, National No, Name, Gender, or Phone.
- **Add / Edit Person**: Modal dialog for adding new persons and updating existing records with real-time validation.

### 2. User & Security Management
- User authentication and role-based permissions for licensing officers and administrators.
- Password change and secure credential handling.

### 3. Application Lifecycle
- **Local Driving License Applications (LDL)**: Support for multiple vehicle classes (Motorcycles, Passenger Cars, Commercial, Heavy Trucks, etc.).
- **Application Status Tracking**: Real-time status tracking (`New`, `Cancelled`, `Completed`).
- **Application Fees & Types**: Dynamic fee calculations based on application type.

### 4. Examination & Test Pipeline
- Multi-tiered test process:
  1. **Vision Test**: Eye exam eligibility and appointment scheduling.
  2. **Written Test**: Theory exam administration and scoring.
  3. **Practical (Street) Driving Test**: Field examination evaluation.
- Test appointment booking, rescheduling, and retake fee handling.

### 5. Licenses & Driver Records
- **Issue Driving License**: Automated issuance upon successfully passing all tests.
- **License Operations**:
  - License Renewal
  - Replacement for Damaged License
  - Replacement for Lost License
- **Detain & Release Management**: Detain violating licenses with fine fees and handle subsequent release procedures.
- **International Licenses**: Issue and manage international driving permits linked to active local licenses.

---

## 🏛 System Architecture

The project is built on multi-tier architectural principles:
- **Presentation Layer (WinForms)**: Modern, responsive UI with customized icons and responsive dialogs.
- **Business Logic Layer (BLL)**: Encapsulates domain logic, validation rules, application state transitions, and licensing constraints.
- **Data Access Layer (DAL)**: Robust ADO.NET connectivity communicating with Microsoft SQL Server using parameterized queries and stored procedures.

---

## 🗄 Database Overview

The repository includes both a visual schema diagram and a complete SQL Server backup:
- **Diagram**: `database/DVLD Scema.svg`
- **Database Backup**: `database/DVLD.bak`

### Key Database Entities:
- `People` - Core citizen identity records.
- `Users` - Staff and administrative accounts.
- `Applications` - Master application registry.
- `ApplicationTypes` - System application categories and fee schedules.
- `LocalDrivingLicenseApplications` - Vehicle-specific license applications.
- `LicenseClasses` - Definitions, minimum age requirements, validity lengths, and fees.
- `Licenses` - Issued driver licenses.
- `Drivers` - Registered drivers linked to Person entities.
- `TestAppointments` & `Tests` - Scheduling and exam score records.
- `TestTypes` - Configured test definitions (Vision, Written, Street).
- `DetainedLicenses` - Registry for seized/detained licenses and releases.
- `InternationalLicenses` - International driving permits.

---

## 📁 Project Structure

```text
DVLD-Driving-License-Management/
├── assets/                       # UI icons and graphical assets
│   ├── icons/                    # Multi-resolution icons (16x16 to 128x128)
│   └── Pictuer/                  # Sample profile and placeholder images
├── database/                     # Database files
│   ├── DVLD Scema.svg            # Complete Entity-Relationship schema diagram
│   └── DVLD.bak                  # SQL Server database backup file
├── DVLVD Project/                # WinForms UI Presentation Project
│   ├── DVLVD Project.sln         # Visual Studio Solution
│   ├── UI-DVLVD-Project.csproj   # C# Project file (.NET 4.8)
│   ├── frmMain.cs                # Main dashboard and navigation hub
│   ├── frmManagePeople.cs        # Citizen search and management interface
│   ├── frmAddEditPerson.cs       # Add / Edit citizen details dialog
│   ├── Program.cs                # Application entry point
│   ├── Properties/               # Assembly info and project resources
│   └── Resources/                # Embedded UI resources
├── .gitignore                    # Visual Studio gitignore configuration
└── README.md                     # Project documentation
```

---

## 🛠 Getting Started

### Prerequisites
- [Visual Studio 2019 or Visual Studio 2022](https://visualstudio.microsoft.com/) (with **.NET desktop development** workload).
- [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/download/dotnet-framework/net48).
- [Microsoft SQL Server](https://www.microsoft.com/sql-server/) (2014 or later) and [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

### Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Ahmadsarayrah12/DVLD-Project-1-Driving-License-Management.git
   ```

2. **Restore the Database**:
   - Open **SQL Server Management Studio (SSMS)**.
   - Right-click on **Databases** -> Select **Restore Database...**.
   - Choose **Device**, select `database/DVLD.bak`, and click **OK**.

3. **Open the Project**:
   - Open `DVLVD Project/DVLVD Project.sln` in Visual Studio.
   - Check connection configuration in `App.config` if database credentials differ from default local server.

4. **Build & Run**:
   - Set build configuration to `Debug` or `Release` (`AnyCPU`).
   - Press <kbd>F5</kbd> or click **Start** to run the application.

---

## 👤 Author

- **Ahmad Sarayrah**
  - GitHub: [@Ahmadsarayrah12](https://github.com/Ahmadsarayrah12)
  - Email: ahmadsarayrah1122@gmail.com
