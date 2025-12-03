-- ========================
-- Tables
-- ========================

CREATE TABLE patients(
    patientID INT IDENTITY(1,1) PRIMARY KEY,
    [name] VARCHAR(50) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    dateOfBirth DATE NOT NULL,
    phone VARCHAR(15) NOT NULL,
    email VARCHAR(50),
    [address] VARCHAR(50),
    bloodGroup VARCHAR(5),
    medicalHistory NVARCHAR(MAX),
    allergies VARCHAR(255),
    emergemcyContactName VARCHAR(50),
    emergemcyContactNumber VARCHAR(15),
    dateOfRegistration DATETIME DEFAULT GETDATE(),
    cb1 BIT DEFAULT 0,
    cb2 BIT DEFAULT 0,
    cb3 BIT DEFAULT 0,
    cb4 BIT DEFAULT 0,
    cb5 BIT DEFAULT 0,
    cb6 BIT DEFAULT 0,
    cb7 BIT DEFAULT 0,
    cb8 BIT DEFAULT 0,
    cb9 BIT DEFAULT 0,
    cb10 BIT DEFAULT 0
);

CREATE TABLE PatientFiles (
    fileID INT IDENTITY(1,1) PRIMARY KEY,
    patientID INT NOT NULL FOREIGN KEY REFERENCES patients(patientID),
    fileName VARCHAR(255) NOT NULL,
    filePath VARCHAR(500) NOT NULL,
    uploadedOn DATETIME DEFAULT GETDATE()
);

CREATE TABLE bills(
    billID INT IDENTITY(1,1) PRIMARY KEY,
    billDate DATETIME DEFAULT GETDATE(),
    patientID INT NOT NULL FOREIGN KEY REFERENCES patients(patientID),
    amount DECIMAL(18,2) NOT NULL,
    paymentMethod VARCHAR(20),
    status VARCHAR(20),
    remaining DECIMAL(18,2),
    paid DECIMAL(18,2)
);


create table installments(
instID int primary key identity(1,1),
billID int foreign key references bills(billID),
amount decimal(18,2) not null,
instDate datetime default getdate()
);

CREATE TABLE users(
    userID INT IDENTITY(1,1) PRIMARY KEY,
    [name] VARCHAR(50) NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    [password] VARCHAR(50) NOT NULL,
    [role] VARCHAR(20) NOT NULL,
    email VARCHAR(50),
    phone VARCHAR(15),
    [status] VARCHAR(10),
    createdON DATETIME DEFAULT GETDATE()
);

insert into users (name, username, password, role, status) values ('Test User', 'test', 'Test@123', 'admin', 'active');

CREATE TABLE doctors(
    doctorID INT IDENTITY(1,1) PRIMARY KEY,
    [name] VARCHAR(50) NOT NULL,
    gender VARCHAR(10) NOT NULL,
    dateOfBirth DATE NOT NULL,
    phone VARCHAR(15) NOT NULL,
    email VARCHAR(50),
    [address] VARCHAR(50),
    specialization VARCHAR(50) NOT NULL,
    qualification VARCHAR(50) NOT NULL,
    yearsOfExperience INT,
    shiftTime VARCHAR(20) NOT NULL,
    licenseNo VARCHAR(50),
    joiningDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE appointments(
    appointmentID INT IDENTITY(1,1) PRIMARY KEY,
    patient_ID INT NOT NULL FOREIGN KEY REFERENCES patients(patientID),
    doctor_ID INT NOT NULL FOREIGN KEY REFERENCES doctors(doctorID),
    appointmentDate DATE NOT NULL,
    appointmentTime TIME NOT NULL,
    reason NVARCHAR(MAX),
    createdOn DATETIME DEFAULT GETDATE()
);

CREATE TABLE license(
    id INT IDENTITY PRIMARY KEY,
    updated DATE NOT NULL
);

create table [services](
serviceID int primary key identity(1,1),
serviceName varchar(50) not null,
serviceAmount decimal(18,2) not null
);

create table detailedBill(
detailID int primary key identity(1,1),
billID int foreign key references bills(billID) not null,
serviceID int not null,
serviceName varchar(50) not null,
cost decimal(18,2) not null,
qty int default 1,
totalCost decimal(18,2)
);


GO

-- ========================
-- Stored Procedures
-- ========================

-- ------------- Patient Procedures -------------

CREATE PROCEDURE insertIntoPatient
    @name VARCHAR(50),
    @gender VARCHAR(10),
    @dateOfBirth DATE,
    @phone VARCHAR(15),
    @email VARCHAR(50) = NULL,
    @address VARCHAR(50) = NULL,
    @bloodGroup VARCHAR(5) = NULL,
    @medicalHistory NVARCHAR(MAX) = NULL,
    @allergies VARCHAR(255) = NULL,
    @emergemcyContactName VARCHAR(50) = NULL,
    @emergemcyContactNumber VARCHAR(15) = NULL,
    @cb1 BIT = 0,
    @cb2 BIT = 0,
    @cb3 BIT = 0,
    @cb4 BIT = 0,
    @cb5 BIT = 0,
    @cb6 BIT = 0,
    @cb7 BIT = 0,
    @cb8 BIT = 0,
    @cb9 BIT = 0,
    @cb10 BIT = 0
    
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO patients (name, gender, dateOfBirth, phone, email, address, bloodGroup, medicalHistory, allergies, emergemcyContactName, emergemcyContactNumber, cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10)
    VALUES (@name, @gender, @dateOfBirth, @phone, @email, @address, @bloodGroup, @medicalHistory, @allergies, @emergemcyContactName, @emergemcyContactNumber, @cb1, @cb2, @cb3, @cb4, @cb5, @cb6, @cb7, @cb8, @cb9, @cb10);
    return SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE updatePatients
    @patientID INT,
    @name VARCHAR(50),
    @gender VARCHAR(10),
    @dateOfBirth DATE,
    @phone VARCHAR(15),
    @email VARCHAR(50) = NULL,
    @address VARCHAR(50) = NULL,
    @bloodGroup VARCHAR(5) = NULL,
    @medicalHistory NVARCHAR(MAX) = NULL,
    @allergies VARCHAR(255) = NULL,
    @emergemcyContactName VARCHAR(50) = NULL,
    @emergemcyContactNumber VARCHAR(15) = NULL,
    @cb1 BIT = 0,
    @cb2 BIT = 0,
    @cb3 BIT = 0,
    @cb4 BIT = 0,
    @cb5 BIT = 0,
    @cb6 BIT = 0,
    @cb7 BIT = 0,
    @cb8 BIT = 0,
    @cb9 BIT = 0,
    @cb10 BIT = 0

AS
BEGIN
    SET NOCOUNT ON;
    UPDATE patients
    SET
        [name] = @name,
        gender = @gender,
        dateOfBirth = @dateOfBirth,
        phone = @phone,
        email = @email,
        [address] = @address,
        bloodGroup = @bloodGroup,
        medicalHistory = @medicalHistory,
        allergies = @allergies,
        emergemcyContactName = @emergemcyContactName,
        emergemcyContactNumber = @emergemcyContactNumber,
        cb1 = @cb1,
        cb2 = @cb2,
        cb3 = @cb3,
        cb4 = @cb4,
        cb5 = @cb5,
        cb6 = @cb6,
        cb7 = @cb7,
        cb8 = @cb8,
        cb9 = @cb9,
        cb10 = @cb10

    WHERE patientID = @patientID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE deletePatient
    @patientID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM patients WHERE patientID = @patientID;
        RETURN @@ROWCOUNT;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END;
GO

CREATE PROCEDURE viewPatient
    @patientID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM patients WHERE patientID = @patientID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE viewAllPatients
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 500 * FROM patients ORDER BY patientID desc;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE insertPatientFilePath
    @patientID INT,
    @fileName VARCHAR(255),
    @filePath VARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO PatientFiles (patientID, fileName, filePath)
    VALUES (@patientID, @fileName, @filePath);
    RETURN SCOPE_IDENTITY();
END;
GO


-- ------------- Doctor Procedures -------------

CREATE PROCEDURE insertIntoDoctor
    @name VARCHAR(50),
    @gender VARCHAR(10),
    @dateOfBirth DATE,
    @phone VARCHAR(15),
    @email VARCHAR(50) = NULL,
    @address VARCHAR(50) = NULL,
    @specialization VARCHAR(50),
    @qualification VARCHAR(50),
    @yearsOfExperience INT = NULL,
    @shiftTime VARCHAR(20),
    @licenseNo VARCHAR(50) = NULL
    
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO doctors ([name], gender, dateOfBirth, phone, email, [address], specialization, qualification, yearsOfExperience, shiftTime, licenseNo)
    VALUES (@name, @gender, @dateOfBirth, @phone, @email, @address, @specialization, @qualification, @yearsOfExperience, @shiftTime, @licenseNo);
    return SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE updateDoctor
    @doctorID INT,
    @name VARCHAR(50),
    @gender VARCHAR(10),
    @dateOfBirth DATE,
    @phone VARCHAR(15),
    @email VARCHAR(50) = NULL,
    @address VARCHAR(50) = NULL,
    @specialization VARCHAR(50),
    @qualification VARCHAR(50),
    @yearsOfExperience INT = NULL,
    @shiftTime VARCHAR(20),
    @licenseNo VARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE doctors
    SET
        [name] = @name,
        gender = @gender,
        dateOfBirth = @dateOfBirth,
        phone = @phone,
        email = @email,
        [address] = @address,
        specialization = @specialization,
        qualification = @qualification,
        yearsOfExperience = @yearsOfExperience,
        shiftTime = @shiftTime,
        licenseNo = @licenseNo
    WHERE doctorID = @doctorID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE deleteDoctor
    @doctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM doctors WHERE doctorID = @doctorID;
        RETURN @@ROWCOUNT;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END;
GO

CREATE PROCEDURE viewDoctor
    @doctorID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM doctors WHERE doctorID = @doctorID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE viewAllDoctors
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 500 * FROM doctors ORDER BY doctorID desc;
    RETURN @@ROWCOUNT;
END;
GO

-- ------------- Appointment Procedures -------------

CREATE PROCEDURE insertIntoAppointment
    @patient_ID INT,
    @doctor_ID INT,
    @appointmentDate DATE,
    @appointmentTime TIME,
    @reason NVARCHAR(MAX) = NULL
    
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO appointments (patient_ID, doctor_ID, appointmentDate, appointmentTime, reason)
    VALUES (@patient_ID, @doctor_ID, @appointmentDate, @appointmentTime, @reason);
    return SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE updateAppointment
    @appointmentID INT,
    @patient_ID INT,
    @doctor_ID INT,
    @appointmentDate DATE,
    @appointmentTime TIME,
    @reason NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE appointments
    SET patient_ID      = @patient_ID,
        doctor_ID       = @doctor_ID,
        appointmentDate = @appointmentDate,
        appointmentTime = @appointmentTime,
        reason          = @reason
    WHERE appointmentID = @appointmentID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE deleteAppointment
    @appointmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM appointments WHERE appointmentID = @appointmentID;
        RETURN @@ROWCOUNT;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END;
GO

CREATE PROCEDURE viewAppointment
    @appointmentID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM appointments WHERE appointmentID = @appointmentID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE viewAllAppointments
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 500 * FROM appointments ORDER BY appointmentDate asc;
    RETURN @@ROWCOUNT;
END;
GO

CREATE procedure viewAppointmentSingle
@Date date
as
begin
set nocount on;
select * from appointments where appointmentDate = @Date
return @@rowcount;
end;
GO

CREATE procedure viewAppointmentRange
@from date,
@till date
as
begin
set nocount on;
select * from appointments where appointmentDate between @from and @till
return @@rowcount;
end;
GO

-- ------------- Bill Procedures -------------

CREATE PROCEDURE insertIntoBill
    @patientID INT,
    @amount DECIMAL(18,2),
    @paymentMethod VARCHAR(20) = NULL,
    @status VARCHAR(20) = NULL,
    @paid decimal(18,2)
    
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO bills (patientID, amount, paymentMethod, status, remaining, paid)
    VALUES (@patientID, @amount, @paymentMethod, @status, @amount-@paid, @paid);
    return SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE viewBill
    @billID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT b.billID, b.billDate, b.patientID, b.amount, b.paymentMethod, b.status, b.paid, b.remaining, p.name AS PatientName
    FROM bills b
    INNER JOIN patients p ON b.patientID = p.patientID
    WHERE b.billID = @billID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE searchBillWithPatient
    @name VARCHAR(50) = NULL,
    @phone VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT p.patientID, p.name, p.phone, b.billID
    FROM patients p
    INNER JOIN bills b ON b.patientID = p.patientID
    WHERE (@name IS NULL OR [name] LIKE '%' + @name + '%')
      AND (@phone IS NULL OR phone = @phone);
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE viewAllBills
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 500 * FROM bills ORDER BY billID DESC;
    RETURN @@ROWCOUNT;
END;
GO



create procedure payInstallment
    @billID int,
    @amount decimal(18,2)
AS
BEGIN
    set nocount on;
    insert into installments (billID, amount) values (@billID, @amount) update bills set remaining = remaining-@amount, paid = paid + @amount where billID = @billID;
    return @@rowcount;
end;
GO


create procedure installmentHistory
    @billID int
AS
BEGIN
    set nocount on;
    select * from installments where billID = @billID;
    return @@rowcount;
END;
GO


-- ------------- User Procedures -------------

CREATE PROCEDURE insertIntoUser
    @name VARCHAR(50),
    @username VARCHAR(50),
    @password VARCHAR(50),
    @role VARCHAR(20),
    @email VARCHAR(50) = NULL,
    @phone VARCHAR(15) = NULL,
    @status VARCHAR(10) = NULL
    
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO users ([name], username, [password], [role], email, phone, [status])
        VALUES (@name, @username, @password, @role, @email, @phone, @status);
        return SCOPE_IDENTITY();
    END TRY
    BEGIN CATCH
        return -1;
    END CATCH
END;
GO

CREATE PROCEDURE updateUser
    @userID INT,
    @name VARCHAR(50),
    @username VARCHAR(50),
    @password VARCHAR(50),
    @role VARCHAR(20),
    @email VARCHAR(50) = NULL,
    @phone VARCHAR(15) = NULL,
    @status VARCHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE users
        SET [name] = @name,
            username = @username,
            [password] = @password,
            [role] = @role,
            email = @email,
            phone = @phone,
            [status] = @status
        WHERE userID = @userID;
        RETURN @@ROWCOUNT;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END;
GO

CREATE PROCEDURE deleteUser
    @userID INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        DELETE FROM users WHERE userID = @userID;
        RETURN @@ROWCOUNT;
    END TRY
    BEGIN CATCH
        RETURN -1;
    END CATCH
END;
GO

CREATE PROCEDURE viewUser
    @userID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM users WHERE userID = @userID;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE viewAllUsers
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 500 * FROM users ORDER BY createdON DESC;
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE userLogin
    @username VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT [name], [role]
    FROM users
    WHERE username = @username
      AND [password] = @password
      AND ([status] IS NULL OR [status] = 'Active');
    RETURN @@ROWCOUNT;
END;
GO

-- ------------- Search Procedures -------------

CREATE PROCEDURE searchPatientsWithDetails
    @name VARCHAR(50) = NULL,
    @phone VARCHAR(15) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM patients
    WHERE (@name IS NULL OR [name] LIKE '%' + @name + '%')
      AND (@phone IS NULL OR phone = @phone);
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE searchDoctorsWithDetails
    @name VARCHAR(50) = NULL,
    @specialization VARCHAR(15) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM doctors
    WHERE (@name IS NULL OR [name] LIKE '%' + @name + '%')
      AND (@specialization IS NULL OR specialization = @specialization);
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE searchAppWithPatient
    @name VARCHAR(50) = NULL,
    @phone VARCHAR(20) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT a.appointmentID, p.patientID, p.name, p.phone
    FROM appointments a
    INNER JOIN patients p ON a.patient_ID = p.patientID
    WHERE (@name IS NULL OR p.name LIKE '%' + @name + '%')
      AND (@phone IS NULL OR p.phone LIKE '%' + @phone + '%');
    RETURN @@ROWCOUNT;
END;
GO

CREATE PROCEDURE searchUsersWithDetails
    @name NVARCHAR(50) = NULL,
    @username NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM users
    WHERE (@name IS NULL OR [name] LIKE '%' + @name + '%')
      AND (@username IS NULL OR username = @username);
    RETURN @@ROWCOUNT;
END;
GO

GO
CREATE PROCEDURE checkLicense
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @updated DATE;
    DECLARE @days INT;

    SELECT TOP 1 @updated = updated
    FROM license
    ORDER BY id DESC;

    IF @updated IS NULL
    BEGIN
        RETURN -1;
    END

    SET @days = DATEDIFF(DAY, @updated, CAST(GETDATE() AS DATE));

    RETURN @days;
END;
GO

-- Services procedures --

create procedure insertIntoServices
@serviceName varchar(50),
@serviceAmount decimal(18,2)
as
begin
    set nocount on;
    insert into [services](serviceName, serviceAmount) values (@serviceName, @serviceAmount);
    return scope_identity();
end;
GO

create procedure updateServices
@serviceID int,
@serviceName varchar(50),
@serviceAmount decimal(18,2)
as
begin
    set nocount on;
    update [services] set serviceName = @serviceName, serviceAmount = @serviceAmount where serviceID = @serviceID;
    return @@rowcount;
end;
GO

create procedure deleteServices
@serviceID int
as
begin
    set nocount on;
    delete from [services] where serviceID = @serviceID;
    return @@rowcount;
end;
GO

create procedure allServices
as
begin
    set nocount on;
    select * from [services] order by serviceID asc
    return @@rowcount;
end;
GO

create procedure searchServiceName
@servName varchar(50)
as
begin
    set nocount on;
    select * from [services] where serviceName like @servName + '%';
    return @@rowcount;
end;
GO

--- Detailed Bill Procedures --

create procedure insertIntoDetailedBill
@billID int,
@servID int,
@servName varchar(50),
@unitPrice decimal(18,2),
@qty int
as
begin
    set nocount on;
    insert into detailedBill(billID, serviceID, serviceName, cost, qty, totalCost) values (@billID, @servID, @servName, @unitPrice, @qty, (@unitPrice*@qty));
    return @@rowcount;
end;
GO

create procedure getDetailedBill
@billID int
as
begin
    set nocount on;
    select * from detailedBill where billID = @billID;
    return @@rowcount;
end;
GO
