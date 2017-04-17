USE  "CS6232-g3";

SELECT * FROM clinicemployees;
SELECT username from nurses;
SELECT username from doctors;
SELECT username from administrators;
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
@dateOfBirth varchar(45) = ''

SELECT ppl.*, 
	   pt.patientID
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
WHERE (ppl.firstName LIKE @firstName AND ppl.lastName LIKE @lastName)
	OR (ppl.dateOfBirth = CAST(@dateOfBirth as datetime) AND ppl.lastName LIKE @lastName)
	OR (ppl.dateOfBirth = CAST(@dateOfBirth as datetime))
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

-- Update Appointment
DECLARE 
@olddate DATETIME = '2017-05-06 12:00:00',
@olddoctorID INT = 1,
@oldpatientID INT = 6,
@oldreason VARCHAR(150) = 'Fever'

DECLARE 
@newdate DATETIME = '2017-05-06 13:45:00',
@newdoctorID INT = 2,
@newpatientID INT = 6,
@newreason VARCHAR(150) = 'Measles'

UPDATE appointment SET
	date = @newdate,
	doctorID = @newdoctorID,
	patientID = @newpatientID, 
	reasonForVisit = @newreason
WHERE date = @olddate
	AND doctorID = @olddoctorID
	AND patientID = @oldpatientID 
	AND reasonForVisit = @oldreason;

-- GetTestsForAppointment
SELECT * FROM appointment_has_tests;
SELECT aht.*
FROM appointment_has_tests aht
WHERE aht.appointment_patientID = 6
	AND aht.appointment_doctorID = 4 
	AND aht.appointment_date = '2015-02-10 09:00:00.000';

-------- Vitals DAL -------- 
-- GetVitalsForAppointment
SELECT * FROM vitals;
SELECT d.nurseID, d.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'Nurse'
FROM nurses d
	JOIN people p ON d.peopleID = p.peopleID;

SELECT v.*, CONCAT(ppl.firstName, ' ', ppl.lastName) AS 'Nurse'
FROM vitals v
	JOIN nurses n ON v.nurses_nurseID = n.nurseID
	JOIN people ppl ON n.peopleID = ppl.peopleID
WHERE v.appointment_patientID = 6
	AND v.appointment_doctorID = 4 
	AND v.appointment_date = '2015-02-10 09:00:00.000';

-------- ComboBoxPulling -------- 
-- GetDoctorList
SELECT d.doctorID, d.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'Doctor'
FROM doctors d
	JOIN people p ON d.peopleID = p.peopleID;

-- GetNurseList
SELECT n.nurseID, n.peopleID, CONCAT(p.firstName, ' ', p.lastName) AS 'fullName'
FROM nurses n
	JOIN people p ON n.peopleID = p.peopleID

-- GetTestList
SELECT * FROM tests;


-------- Login Testing -------- 
-- Test the login
SELECT COUNT(*) AS 'count' FROM clinicemployees " +
"WHERE username = 'jake' AND passwords = 'haha';

-------- Admin SP Testing -------- 
-- Case 1 works
EXEC usp_mostPerformedTestsDuringDates '2016-10-01', '2017-04-16';

-- Case 2 start/end date is null
EXEC usp_mostPerformedTestsDuringDates null, '2015-12-30';
EXEC usp_mostPerformedTestsDuringDates '2015-01-01', null;

-- Case 3 start/end date is empty
EXEC usp_mostPerformedTestsDuringDates '', '2015-12-30';
EXEC usp_mostPerformedTestsDuringDates '2015-01-01', '';

-- Case 4 start is after end date
EXEC usp_mostPerformedTestsDuringDates '2015-12-30', '2015-01-01';

-- Case 5 same start and end date
EXEC usp_mostPerformedTestsDuringDates '2015-12-30', '2015-12-30';

