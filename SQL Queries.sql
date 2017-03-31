USE Clinic;
SELECT * FROM patients pt
	JOIN People ppl ON pt.peopleID = ppl.peopleID;
SELECT * FROM doctors d
	JOIN People ppl ON d.peopleID = ppl.peopleID;
SELECT * FROM appointment;
SELECT * FROM appointment_has_tests;

-------- Patients DAL --------
--'GetSelectedPatients()' method

DECLARE
@firstName varchar(45) = '%',
@lastName  varchar(45) = 'Mayden%',
@dateOfBirth varchar(45) = '%'

SELECT ppl.*, 
	   pt.patientID
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
WHERE ppl.firstName LIKE @firstName
	AND ppl.lastName LIKE @lastName
	AND ppl.dateOfBirth LIKE @dateOfBirth
ORDER BY ppl.lastName;

-------- Appointments DAL --------
-- GetAppointmentsByPatient