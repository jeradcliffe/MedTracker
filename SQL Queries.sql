USE Clinic;
SELECT * FROM patients pt
	JOIN People ppl ON pt.peopleID = ppl.peopleID;
SELECT * FROM doctors d
	JOIN People ppl ON d.peopleID = ppl.peopleID;
SELECT * FROM appointment;
SELECT * FROM appointment_has_tests;

-------- Patients DAL --------
-- Used in 'GetSelectedPatients()' method

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

-- Scrap work used to pull ALL info for search table
-- Get better picture of why so many of same apt dates from this angles
SELECT pt.patientID,
	   ppl.firstName,
	   ppl.lastName,
	   ppl.dateOfBirth, 
	   a.reasonForVisit,
	   aht.* 
FROM patients pt 
	JOIN people ppl ON ppl.peopleID = pt.peopleID
	JOIN appointment a ON a.patientID = pt.patientID
	JOIN appointment_has_tests aht ON aht.appointment_patientID = pt.patientID;