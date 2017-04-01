USE Clinic;
SELECT * FROM patients pt
	JOIN People ppl ON pt.peopleID = ppl.peopleID;
SELECT * FROM doctors d
	JOIN people ppl ON d.peopleID = ppl.peopleID;
SELECT * FROM appointment;
SELECT * FROM appointment_has_tests;

-------- Patients DAL --------
--GetSelectedPatients

DECLARE
@firstName varchar(45) = '%',
@lastName  varchar(45) = '%',
@dateOfBirth varchar(45) = '%'

SELECT ppl.*, 
	   pt.patientID
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
WHERE ppl.firstName LIKE @firstName
	AND ppl.lastName LIKE @lastName
	AND ppl.dateOfBirth LIKE @dateOfBirth
ORDER BY ppl.lastName, ppl.firstName;

-- GetPatientByID
SELECT ppl.*, pt.patientID 
FROM patients pt
	JOIN people ppl ON ppl.peopleID = pt.peopleID 
WHERE patientID = 12;

-------- Appointments DAL --------
-- GetAppointmentsByPatient
SELECT apt.*, 
	CONCAT(p.firstName, ' ', p.lastName) AS 'Doctor'
FROM appointment apt
	JOIN patients pt ON apt.patientID = pt.patientID
	JOIN doctors d   ON d.doctorID    = apt.doctorID
	JOIN people p    ON p.peopleID    = d.peopleID
WHERE pt.patientID = 6
ORDER BY apt.date DESC;

SELECT d.doctorID, d.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'Doctor'
FROM doctors d
	JOIN people p ON d.peopleID = p.peopleID;

-- Create Appointment
DECLARE 
@date DATETIME = '2017-08-30 11:35:00',
@doctorID INT = 2,
@patientID INT = 6,
@reason VARCHAR(150) = 'Torn ACL'


INSERT INTO appointment
	VALUES (@date, @doctorID, @patientID, @reason);

SELECT * FROM appointment
	ORDER BY date DESC;

-------- Doctors DAL -------- 
-- GetDoctorList
SELECT d.doctorID, d.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'Doctor'
FROM doctors d
	JOIN people p ON d.peopleID = p.peopleID;
